using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using MultiTool;

namespace ModifiedDateChanger
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Имена файлов, выбранных пользователем для последующего изменения даты и времени их модификации.
        /// </summary>
        public List<string> FileNames { get; set; }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FileNames = new List<string>();
        }

        /// <summary>
        /// Вызывает OpenFileDialog для того, чтобы выбрать файлы.
        /// </summary>
        private void selectFilesButton_Click(object sender, EventArgs e)
        {
            // На время работы метода запретим доступ к кнопке, чтобы пользователь
            // не вешал программу, бесконечно клацая шаловливыми ручками.
            selectFilesButton.Enabled = false;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    // Директорией по умолчанию пусть будет "Рабочий стол" - ибо именно туда в 
                    // большинстве случаев кидают те файлы, с которыми необходимо работать.
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    openFileDialog.Filter = "Лог-файлы (*.log)|*.log|Все файлы (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;

                    // Перед закрытием диалогового окна вернуть значение текущей директории, которое было до вызова 
                    // диалогового окна (обычно это директория, в которой лежит исполняемый файл (exe) этой программы).
                    openFileDialog.RestoreDirectory = true;

                    // Разрешаем выбрать сразу несколько файлов.
                    openFileDialog.Multiselect = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Добавляем выбранные пользователем файлы в результирующий список, избегая дубликатов.
                        FileNames.AddRange(openFileDialog.FileNames
                            .Where(fn => !FileNames.Contains(fn))
                            .ToList());

                        // Обновляем список файлов в компоменте listView.
                        updateFilesListOnUI();
                    }
                }
            }
            catch (Exception ex)
            {
                logRichTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + $": Ошибка: " + ex.Message + Environment.NewLine);

                if (ex.Message.Contains("тказано в доступе"))
                    logRichTextBox.AppendText("Возможно, требуется запустить программу от имени администратора." + Environment.NewLine);
            }

            // Вернём доступ к кнопке.
            selectFilesButton.Enabled = true;
        }

        /// <summary>
        /// Вызывает FolderBrowserDialog для того, чтобы выбрать каталог (директорию, папку).
        /// </summary>
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            // На время работы метода запретим доступ к кнопке, чтобы пользователь
            // не вешал программу, бесконечно клацая шаловливыми ручками.
            selectFolderButton.Enabled = false;

            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    // Директорией по умолчанию пусть будет "Рабочий стол" - ибо именно туда в 
                    // большинстве случаев кидают те файлы, с которыми необходимо работать.
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Если установлена галочка "Искать только следующие расширения файлов", то парсим  
                        // строку с расширениями файлов и формируем список паттернов поиска; если 
                        // не установлена - тогда в списке паттернов будет только звёздочка (все файлы).
                        List<string> searchPatterns = new List<string>();

                        searchPatterns.AddRange(thisFileExtensionsOnlyCheckBox.Checked
                            ? thisFileExtensionsOnlyRichTextBox.Text
                                .Replace(" ", "")                          // удаляем все пробелы
                                .Replace(".", " *.")                       // конкатим к точке звёздочку, а также пробел для последующего сплита по нему
                                .Split(' ')                                // сплитим строку по пробелам
                                .Where(s => s != "")                       // игнорируем пустые строки, которые могут появиться после сплита
                                .ToList()                                  // IEnumarable<string> to List<string>
                                .Where(fn => !searchPatterns.Contains(fn)) // избегаем дубликатов
                            : new List<string>() { "*" });

                        // Перебираем указанные расширения файлов.
                        foreach (string searchPattern in searchPatterns)
                        {
                            // Формируем список соотвествующих требованиям файлов.
                            FileNames.AddRange(Directory.EnumerateFiles(
                                folderBrowserDialog.SelectedPath,
                                searchPattern,

                                // Если установлена галочка "вложенные директории" - ищем и в них.
                                searchInNestedFoldersСheckBox.Checked
                                    ? SearchOption.AllDirectories
                                    : SearchOption.TopDirectoryOnly)
                            
                            // Избегаем дубликатов.
                            .Where(fn => !FileNames.Contains(fn))
                            .ToList());
                        }

                        // Обновляем список файлов в компоменте listView.
                        updateFilesListOnUI();
                    }
                }
            }
            catch (Exception ex)
            {
                logRichTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + $": Ошибка: " + ex.Message + Environment.NewLine);

                if (ex.Message.Contains("тказано в доступе"))
                    logRichTextBox.AppendText("Возможно, требуется запустить программу от имени администратора." + Environment.NewLine);
            }

            // Вернём доступ к кнопке.
            selectFolderButton.Enabled = true;
        }

        /// <summary>
        /// Обновляет список файлов в компоненте listView в соответствии со свойством FilesList.
        /// </summary>
        private void updateFilesListOnUI()
        {
            listView.Items.Clear();

            // Обходим все выбранные пользователем файлы и добавляем их в listView на форме.
            foreach (string fileName in FileNames)
            {
                FileInfo fileInfo = new FileInfo(fileName);

                // Данные нулевого столбца конкретной строки listView.
                ListViewItem item;

                // Данные остальных столбцов конкретной строки listView.
                ListViewItem.ListViewSubItem[] subItems;

                // Извлекаем из данных о файле те данные, которые нам необходимы, и выводим их в listView. 
                item = new ListViewItem(Path.GetFileName(fileName), 1);
                subItems = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, fileInfo.LastWriteTime.ToString()),
                    new ListViewItem.ListViewSubItem(item, Path.GetFullPath(fileName))
                };

                item.SubItems.AddRange(subItems);
                listView.Items.Add(item);
            }
        }

        /// <summary>
        /// Установлен/снят флажок "Прочитать дату и время модификации из названия файла".
        /// </summary>
        private void getModifiedDateTimeFromFileNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Если установлен флажок "Прочитать дату и время модификации из названия файла",
            // то делаем поле ввода даты и времени недоступным - и наоборот.
            dateTimePicker.Enabled = !getModifiedDateTimeFromFileNameCheckBox.Checked;   
        }

        /// <summary>
        /// Нажатие на кнопку "Изменить дату и время модификации файлов". 
        /// </summary>
        private void changeModifiedDateTimeButton_Click(object sender, EventArgs e)
        {
            // На время работы метода запретим доступ к кнопке, чтобы пользователь
            // не вешал программу, бесконечно клацая шаловливыми ручками.
            changeModifiedDateTimeButton.Enabled = false;

            int errorsCount = 0;
            int success = 0;

            foreach (string fileName in FileNames)
            {
                DateTime dateTime = new DateTime();

                // Если установлена галочка "Прочитать дату и время из имени файла".
                if (getModifiedDateTimeFromFileNameCheckBox.Checked)
                {
                    // Ищем в названии файла дату и время.
                    if (!Tools.TryFindDateTime(Path.GetFileNameWithoutExtension(fileName), out dateTime))
                    {
                        logRichTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + $": В файле {fileName} не найдено даты и времени. Файл проигнорирован." + Environment.NewLine);
                        errorsCount++;
                        continue;
                    }
                }
                else // Если не установлена - читаем дату и время из dateTimePicker'а.
                {
                    dateTime = dateTimePicker.Value;
                }

                // Пытаемся перезаписать дату модификации файла.
                try
                {
                    File.SetLastWriteTime(fileName, dateTime);

                    logRichTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + $": Файл: {fileName}. Дата модификации изменена на {dateTime.ToString("dd.MM.yyyy HH:mm:ss")}." + Environment.NewLine);

                    success++;
                }
                catch (Exception ex)
                {
                    logRichTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + $": Ошибка: не удалось изменить дату модификации файла {fileName}. " + ex.Message + Environment.NewLine);

                    if (ex.Message.Contains("тказано в доступе"))
                        logRichTextBox.AppendText("Возможно, требуется запустить программу от имени администратора." + Environment.NewLine);

                    errorsCount++;
                }
            }

            if (errorsCount == 0)
            {
                MessageBox.Show(
                    "Даты модификации всех файлов были успешно изменены.",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    $"Попытка перезаписать даты модификаций файлов завершена с ошибками." + Environment.NewLine + Environment.NewLine +
                       "Не все файлы удалось обработать." + Environment.NewLine + Environment.NewLine +
                       $"Успешно обработано файлов: {success}." + Environment.NewLine + 
                       $"Не удалось обработать файлов: {errorsCount}.",
                    "Не все файлы удалось обработать",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Обновляем данные в списке файлов.
            updateFilesListOnUI();

            // Вернём доступ к кнопке.
            changeModifiedDateTimeButton.Enabled = true;
        }

        /// <summary>
        /// Клик по строке в ListView. 
        /// 
        /// Записывает в DateTimePicker дату и время соответствующие выбранной строке.
        /// </summary>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                DateTime oldValue = dateTimePicker.Value;

                try
                {
                    // Читаем из listView дату и время модификации выбранного файла.
                    int selectedIndex = listView.Items.IndexOf(listView.SelectedItems[0]);
                    string dateTimeString = listView.Items[selectedIndex].SubItems[1].Text;

                    // Записываем дату и время выбранного файла в dateTimePicker.
                    dateTimePicker.Value = DateTime.ParseExact(dateTimeString, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                { 
                    dateTimePicker.Value = oldValue;
                }
            }
        }

        /// <summary>
        /// Не позволяем пользователю вводить в поле ввода расширений файлов ничего кроме букв, цифр, точки и пробела.
        /// </summary>
        private void thisFileExtensionsOnlyRichTextBox_TextChanged(object sender, EventArgs e)
        {
            // После присвоения значения свойству Text объекта RichTextBox курсор будет установлен в 
            // начало строки. Нас это не устраивает, так как пользователь может производить редактирование 
            // строки в любом её месте, и если курсор постоянно будет прыгать в начало строки - это нехорошо. 
            // В связи с этим запоминаем положение курсора до проверки ввода.
            int cursorPosition = thisFileExtensionsOnlyRichTextBox.SelectionStart;
            int beforeVerifyTextLength = thisFileExtensionsOnlyRichTextBox.Text.Length;

            // К вводу допустимы только буквы, цифры, а также точка - этот набор символов используется 
            // в расширениях файлов, а также пробел - для разделения расширений друг от друга в строке.
            thisFileExtensionsOnlyRichTextBox.Text = string.Concat(thisFileExtensionsOnlyRichTextBox.Text
                .Where(ch => char.IsLetterOrDigit(ch) || ch == '.' || ch == ' '))
                .Replace(". ", "."); // После точки пробелов быть не должно.

            // Устанавливаем курсор в необходимую позицию после проверки ввода.
            thisFileExtensionsOnlyRichTextBox.SelectionStart = cursorPosition +
                thisFileExtensionsOnlyRichTextBox.Text.Length - beforeVerifyTextLength;
        }

        /// <summary>
        /// Удалить выделенные в listView файлы.
        /// </summary>
        private void deleteSelectedFilesButton_Click(object sender, EventArgs e)
        {
            // На время работы метода запретим доступ к кнопке, чтобы пользователь
            // не вешал программу, бесконечно клацая шаловливыми ручками.
            deleteSelectedFilesButton.Enabled = false;

            for (int i = 0; i < listView.SelectedItems.Count; i++)
                FileNames.RemoveAll(fn => fn.Contains(listView.SelectedItems[i].Text));

            updateFilesListOnUI();

            // Вернём доступ к кнопке.
            deleteSelectedFilesButton.Enabled = true;
        }

        /// <summary>
        /// Очистить список файлов.
        /// </summary>
        private void clearFilesListButton_Click(object sender, EventArgs e)
        {
            // На время работы метода запретим доступ к кнопке, чтобы пользователь
            // не вешал программу, бесконечно клацая шаловливыми ручками.
            clearFilesListButton.Enabled = false;

            FileNames.Clear();
            updateFilesListOnUI();

            // Вернём доступ к кнопке.
            clearFilesListButton.Enabled = true;
        }

        /// <summary>
        /// Очистить лог. 
        /// </summary>
        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Clear();
        }

        /// <summary>
        /// Вызов диалогового окна "О программе".
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
 