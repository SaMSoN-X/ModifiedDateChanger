using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ModifiedDateChanger
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            // Получаем версию программы и копирайт.
            Assembly assembly = Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fileVersionInfo = 
                System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            // Получаем версию программы.
            string version = assembly.GetName().Version.ToString();

            // Полученная версия программы выглядит следующим образом: x.y.z.0,
            // где x - мажорная версия, y - минорная версия, z - номер сборки (билда),
            // а последнее значение нулевое - оно нами не используется, поэтому вырежем его.
            version = version.Remove(version.Length - 2);

            AboutTextLabel.Text =
                "Версия: " + version + "\n" +
                "Дата компиляции: " + File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)
                                          .ToString("dd.MM.yyyy HH:mm:ss") + "\n" +
                "Автор: SaMSoN\n\n" +

                "Утилита предназначена для изменения\n" +
                "дат и времени модификаций файлов.\n\n" +

                fileVersionInfo.LegalCopyright;
        }
    }
}