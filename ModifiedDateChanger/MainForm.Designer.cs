namespace ModifiedDateChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.pathToFileOrFolderGroupBox = new System.Windows.Forms.GroupBox();
            this.thisFileExtensionsOnlyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.fileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifiedDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectFolderGroupBox = new System.Windows.Forms.GroupBox();
            this.searchInNestedFoldersСheckBox = new System.Windows.Forms.CheckBox();
            this.thisFileExtensionsOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.getModifiedDateTimeFromFileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.changeModifierDateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.changeModifiedDateTimeButton = new System.Windows.Forms.Button();
            this.clearFilesListButton = new System.Windows.Forms.Button();
            this.deleteSelectedFilesButton = new System.Windows.Forms.Button();
            this.selectFilesButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.pathToFileOrFolderGroupBox.SuspendLayout();
            this.selectFolderGroupBox.SuspendLayout();
            this.changeModifierDateTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "dir_16.png");
            this.imageList.Images.SetKeyName(1, "file_16.png");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(748, 24);
            this.menuStrip.TabIndex = 3;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(12, 19);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(700, 132);
            this.logRichTextBox.TabIndex = 4;
            this.logRichTextBox.Text = "";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.clearLogButton);
            this.logGroupBox.Controls.Add(this.logRichTextBox);
            this.logGroupBox.Location = new System.Drawing.Point(12, 422);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(724, 192);
            this.logGroupBox.TabIndex = 5;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Лог";
            // 
            // pathToFileOrFolderGroupBox
            // 
            this.pathToFileOrFolderGroupBox.Controls.Add(this.clearFilesListButton);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.deleteSelectedFilesButton);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.thisFileExtensionsOnlyRichTextBox);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.listView);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.selectFilesButton);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.selectFolderButton);
            this.pathToFileOrFolderGroupBox.Controls.Add(this.selectFolderGroupBox);
            this.pathToFileOrFolderGroupBox.Location = new System.Drawing.Point(12, 27);
            this.pathToFileOrFolderGroupBox.Name = "pathToFileOrFolderGroupBox";
            this.pathToFileOrFolderGroupBox.Size = new System.Drawing.Size(724, 319);
            this.pathToFileOrFolderGroupBox.TabIndex = 6;
            this.pathToFileOrFolderGroupBox.TabStop = false;
            this.pathToFileOrFolderGroupBox.Text = "Файлы";
            // 
            // thisFileExtensionsOnlyRichTextBox
            // 
            this.thisFileExtensionsOnlyRichTextBox.Location = new System.Drawing.Point(566, 254);
            this.thisFileExtensionsOnlyRichTextBox.Name = "thisFileExtensionsOnlyRichTextBox";
            this.thisFileExtensionsOnlyRichTextBox.Size = new System.Drawing.Size(134, 49);
            this.thisFileExtensionsOnlyRichTextBox.TabIndex = 4;
            this.thisFileExtensionsOnlyRichTextBox.Text = ".txt .log";
            this.thisFileExtensionsOnlyRichTextBox.TextChanged += new System.EventHandler(this.thisFileExtensionsOnlyRichTextBox_TextChanged);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColumnHeader,
            this.modifiedDateColumnHeader,
            this.pathColumnHeader});
            this.listView.Location = new System.Drawing.Point(12, 19);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(700, 216);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // fileNameColumnHeader
            // 
            this.fileNameColumnHeader.Text = "Имя";
            this.fileNameColumnHeader.Width = 350;
            // 
            // modifiedDateColumnHeader
            // 
            this.modifiedDateColumnHeader.Text = "Изменён";
            this.modifiedDateColumnHeader.Width = 120;
            // 
            // pathColumnHeader
            // 
            this.pathColumnHeader.Text = "Путь";
            this.pathColumnHeader.Width = 700;
            // 
            // selectFolderGroupBox
            // 
            this.selectFolderGroupBox.Controls.Add(this.searchInNestedFoldersСheckBox);
            this.selectFolderGroupBox.Controls.Add(this.thisFileExtensionsOnlyCheckBox);
            this.selectFolderGroupBox.Location = new System.Drawing.Point(247, 237);
            this.selectFolderGroupBox.Name = "selectFolderGroupBox";
            this.selectFolderGroupBox.Size = new System.Drawing.Size(464, 73);
            this.selectFolderGroupBox.TabIndex = 10;
            this.selectFolderGroupBox.TabStop = false;
            // 
            // searchInNestedFoldersСheckBox
            // 
            this.searchInNestedFoldersСheckBox.AutoSize = true;
            this.searchInNestedFoldersСheckBox.Checked = true;
            this.searchInNestedFoldersСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchInNestedFoldersСheckBox.Location = new System.Drawing.Point(34, 49);
            this.searchInNestedFoldersСheckBox.Name = "searchInNestedFoldersСheckBox";
            this.searchInNestedFoldersСheckBox.Size = new System.Drawing.Size(117, 17);
            this.searchInNestedFoldersСheckBox.TabIndex = 1;
            this.searchInNestedFoldersСheckBox.Text = "вложенные папки";
            this.searchInNestedFoldersСheckBox.UseVisualStyleBackColor = true;
            // 
            // thisFileExtensionsOnlyCheckBox
            // 
            this.thisFileExtensionsOnlyCheckBox.AutoSize = true;
            this.thisFileExtensionsOnlyCheckBox.Location = new System.Drawing.Point(186, 25);
            this.thisFileExtensionsOnlyCheckBox.Name = "thisFileExtensionsOnlyCheckBox";
            this.thisFileExtensionsOnlyCheckBox.Size = new System.Drawing.Size(134, 30);
            this.thisFileExtensionsOnlyCheckBox.TabIndex = 0;
            this.thisFileExtensionsOnlyCheckBox.Text = "Искать только след. \r\nрасширен. файлов:";
            this.thisFileExtensionsOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // getModifiedDateTimeFromFileNameCheckBox
            // 
            this.getModifiedDateTimeFromFileNameCheckBox.AutoSize = true;
            this.getModifiedDateTimeFromFileNameCheckBox.Checked = true;
            this.getModifiedDateTimeFromFileNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.getModifiedDateTimeFromFileNameCheckBox.Location = new System.Drawing.Point(12, 45);
            this.getModifiedDateTimeFromFileNameCheckBox.Name = "getModifiedDateTimeFromFileNameCheckBox";
            this.getModifiedDateTimeFromFileNameCheckBox.Size = new System.Drawing.Size(338, 17);
            this.getModifiedDateTimeFromFileNameCheckBox.TabIndex = 8;
            this.getModifiedDateTimeFromFileNameCheckBox.Text = "Прочитать дату и время  из имени файла (если они там есть)";
            this.getModifiedDateTimeFromFileNameCheckBox.UseVisualStyleBackColor = true;
            this.getModifiedDateTimeFromFileNameCheckBox.CheckedChanged += new System.EventHandler(this.getModifiedDateTimeFromFileNameCheckBox_CheckedChanged);
            // 
            // changeModifierDateTimeGroupBox
            // 
            this.changeModifierDateTimeGroupBox.Controls.Add(this.dateTimePicker);
            this.changeModifierDateTimeGroupBox.Controls.Add(this.getModifiedDateTimeFromFileNameCheckBox);
            this.changeModifierDateTimeGroupBox.Controls.Add(this.changeModifiedDateTimeButton);
            this.changeModifierDateTimeGroupBox.Location = new System.Drawing.Point(12, 347);
            this.changeModifierDateTimeGroupBox.Name = "changeModifierDateTimeGroupBox";
            this.changeModifierDateTimeGroupBox.Size = new System.Drawing.Size(724, 73);
            this.changeModifierDateTimeGroupBox.TabIndex = 7;
            this.changeModifierDateTimeGroupBox.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd MMMM yyyy HH:mm:ss";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 16);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // changeModifiedDateTimeButton
            // 
            this.changeModifiedDateTimeButton.Image = ((System.Drawing.Image)(resources.GetObject("changeModifiedDateTimeButton.Image")));
            this.changeModifiedDateTimeButton.Location = new System.Drawing.Point(377, 16);
            this.changeModifiedDateTimeButton.Name = "changeModifiedDateTimeButton";
            this.changeModifiedDateTimeButton.Size = new System.Drawing.Size(334, 31);
            this.changeModifiedDateTimeButton.TabIndex = 7;
            this.changeModifiedDateTimeButton.Text = "Изменить дату и время модификации файлов";
            this.changeModifiedDateTimeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeModifiedDateTimeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeModifiedDateTimeButton.UseVisualStyleBackColor = true;
            this.changeModifiedDateTimeButton.Click += new System.EventHandler(this.changeModifiedDateTimeButton_Click);
            // 
            // clearFilesListButton
            // 
            this.clearFilesListButton.Image = ((System.Drawing.Image)(resources.GetObject("clearFilesListButton.Image")));
            this.clearFilesListButton.Location = new System.Drawing.Point(132, 283);
            this.clearFilesListButton.Name = "clearFilesListButton";
            this.clearFilesListButton.Size = new System.Drawing.Size(109, 27);
            this.clearFilesListButton.TabIndex = 12;
            this.clearFilesListButton.Text = "Очистить";
            this.clearFilesListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearFilesListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearFilesListButton.UseVisualStyleBackColor = true;
            this.clearFilesListButton.Click += new System.EventHandler(this.clearFilesListButton_Click);
            // 
            // deleteSelectedFilesButton
            // 
            this.deleteSelectedFilesButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedFilesButton.Image")));
            this.deleteSelectedFilesButton.Location = new System.Drawing.Point(12, 283);
            this.deleteSelectedFilesButton.Name = "deleteSelectedFilesButton";
            this.deleteSelectedFilesButton.Size = new System.Drawing.Size(115, 27);
            this.deleteSelectedFilesButton.TabIndex = 11;
            this.deleteSelectedFilesButton.Text = "Удалить выдел.";
            this.deleteSelectedFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteSelectedFilesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteSelectedFilesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedFilesButton.Click += new System.EventHandler(this.deleteSelectedFilesButton_Click);
            // 
            // selectFilesButton
            // 
            this.selectFilesButton.Image = global::ModifiedDateChanger.Properties.Resources.file_16;
            this.selectFilesButton.Location = new System.Drawing.Point(12, 242);
            this.selectFilesButton.Name = "selectFilesButton";
            this.selectFilesButton.Size = new System.Drawing.Size(229, 35);
            this.selectFilesButton.TabIndex = 0;
            this.selectFilesButton.Text = "Добавить файлы...";
            this.selectFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectFilesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectFilesButton.UseVisualStyleBackColor = true;
            this.selectFilesButton.Click += new System.EventHandler(this.selectFilesButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Image = global::ModifiedDateChanger.Properties.Resources.dir_16;
            this.selectFolderButton.Location = new System.Drawing.Point(258, 252);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(160, 30);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Выбрать папку...";
            this.selectFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.Image = global::ModifiedDateChanger.Properties.Resources.blank_16;
            this.clearLogButton.Location = new System.Drawing.Point(551, 157);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(160, 27);
            this.clearLogButton.TabIndex = 4;
            this.clearLogButton.Text = "Очистить лог...";
            this.clearLogButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearLogButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 626);
            this.Controls.Add(this.changeModifierDateTimeGroupBox);
            this.Controls.Add(this.pathToFileOrFolderGroupBox);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 665);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(764, 665);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить даты и время модификаций файлов";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.pathToFileOrFolderGroupBox.ResumeLayout(false);
            this.selectFolderGroupBox.ResumeLayout(false);
            this.selectFolderGroupBox.PerformLayout();
            this.changeModifierDateTimeGroupBox.ResumeLayout(false);
            this.changeModifierDateTimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button selectFilesButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.GroupBox pathToFileOrFolderGroupBox;
        private System.Windows.Forms.Button changeModifiedDateTimeButton;
        private System.Windows.Forms.CheckBox getModifiedDateTimeFromFileNameCheckBox;
        private System.Windows.Forms.GroupBox changeModifierDateTimeGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader fileNameColumnHeader;
        private System.Windows.Forms.ColumnHeader modifiedDateColumnHeader;
        private System.Windows.Forms.ColumnHeader pathColumnHeader;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.RichTextBox thisFileExtensionsOnlyRichTextBox;
        private System.Windows.Forms.GroupBox selectFolderGroupBox;
        private System.Windows.Forms.CheckBox thisFileExtensionsOnlyCheckBox;
        private System.Windows.Forms.CheckBox searchInNestedFoldersСheckBox;
        private System.Windows.Forms.Button deleteSelectedFilesButton;
        private System.Windows.Forms.Button clearFilesListButton;
    }
}

