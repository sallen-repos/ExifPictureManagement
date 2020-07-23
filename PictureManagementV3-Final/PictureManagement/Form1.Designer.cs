namespace PictureManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageNumberLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.FileNameRadioButton = new System.Windows.Forms.RadioButton();
            this.commentsRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionRadioButton = new System.Windows.Forms.RadioButton();
            this.categoryRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.keyWordLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dateRangeLabel = new System.Windows.Forms.Label();
            this.formMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.infoLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UseExifButton = new System.Windows.Forms.Button();
            this.saveExifButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.formMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(351, 32);
            this.imageDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(540, 442);
            this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDisplay.TabIndex = 5;
            this.imageDisplay.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.imageNumberLabel);
            this.panel3.Controls.Add(this.imageLabel);
            this.panel3.Controls.Add(this.nextButton);
            this.panel3.Controls.Add(this.previousButton);
            this.panel3.Location = new System.Drawing.Point(351, 543);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 97);
            this.panel3.TabIndex = 4;
            // 
            // imageNumberLabel
            // 
            this.imageNumberLabel.AutoSize = true;
            this.imageNumberLabel.Location = new System.Drawing.Point(217, 47);
            this.imageNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageNumberLabel.Name = "imageNumberLabel";
            this.imageNumberLabel.Size = new System.Drawing.Size(86, 17);
            this.imageNumberLabel.TabIndex = 3;
            this.imageNumberLabel.Text = "image 0 of 0";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(241, 20);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(46, 17);
            this.imageLabel.TabIndex = 2;
            this.imageLabel.Text = "Image";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(355, 20);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 57);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "=>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(80, 20);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 57);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "<=";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterGroupBox);
            this.panel1.Controls.Add(this.toLabel);
            this.panel1.Controls.Add(this.fromLabel);
            this.panel1.Controls.Add(this.toDatePicker);
            this.panel1.Controls.Add(this.fromDatePicker);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.filterButton);
            this.panel1.Controls.Add(this.commentsTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.commentsLabel);
            this.panel1.Controls.Add(this.keyWordLabel);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.dateRangeLabel);
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 645);
            this.panel1.TabIndex = 3;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.FileNameRadioButton);
            this.filterGroupBox.Controls.Add(this.commentsRadioButton);
            this.filterGroupBox.Controls.Add(this.descriptionRadioButton);
            this.filterGroupBox.Controls.Add(this.categoryRadioButton);
            this.filterGroupBox.Controls.Add(this.dateRadioButton);
            this.filterGroupBox.Controls.Add(this.noneRadioButton);
            this.filterGroupBox.Location = new System.Drawing.Point(31, 26);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(200, 215);
            this.filterGroupBox.TabIndex = 16;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter Term";
            // 
            // FileNameRadioButton
            // 
            this.FileNameRadioButton.AutoSize = true;
            this.FileNameRadioButton.Location = new System.Drawing.Point(15, 174);
            this.FileNameRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.FileNameRadioButton.Name = "FileNameRadioButton";
            this.FileNameRadioButton.Size = new System.Drawing.Size(92, 21);
            this.FileNameRadioButton.TabIndex = 12;
            this.FileNameRadioButton.TabStop = true;
            this.FileNameRadioButton.Text = "File Name";
            this.FileNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // commentsRadioButton
            // 
            this.commentsRadioButton.AutoSize = true;
            this.commentsRadioButton.Location = new System.Drawing.Point(15, 145);
            this.commentsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.commentsRadioButton.Name = "commentsRadioButton";
            this.commentsRadioButton.Size = new System.Drawing.Size(95, 21);
            this.commentsRadioButton.TabIndex = 11;
            this.commentsRadioButton.TabStop = true;
            this.commentsRadioButton.Text = "Comments";
            this.commentsRadioButton.UseVisualStyleBackColor = true;
            // 
            // descriptionRadioButton
            // 
            this.descriptionRadioButton.AutoSize = true;
            this.descriptionRadioButton.Location = new System.Drawing.Point(15, 117);
            this.descriptionRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionRadioButton.Name = "descriptionRadioButton";
            this.descriptionRadioButton.Size = new System.Drawing.Size(100, 21);
            this.descriptionRadioButton.TabIndex = 10;
            this.descriptionRadioButton.TabStop = true;
            this.descriptionRadioButton.Text = "Description";
            this.descriptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoryRadioButton
            // 
            this.categoryRadioButton.AutoSize = true;
            this.categoryRadioButton.Location = new System.Drawing.Point(15, 89);
            this.categoryRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.categoryRadioButton.Name = "categoryRadioButton";
            this.categoryRadioButton.Size = new System.Drawing.Size(86, 21);
            this.categoryRadioButton.TabIndex = 9;
            this.categoryRadioButton.TabStop = true;
            this.categoryRadioButton.Text = "Category";
            this.categoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Location = new System.Drawing.Point(15, 60);
            this.dateRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(59, 21);
            this.dateRadioButton.TabIndex = 8;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "Date";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(15, 31);
            this.noneRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(63, 21);
            this.noneRadioButton.TabIndex = 7;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(52, 335);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(29, 17);
            this.toLabel.TabIndex = 15;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(39, 295);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 17);
            this.fromLabel.TabIndex = 14;
            this.fromLabel.Text = "From:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.toDatePicker.Location = new System.Drawing.Point(83, 335);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(100, 22);
            this.toDatePicker.TabIndex = 12;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.fromDatePicker.Location = new System.Drawing.Point(83, 295);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(100, 22);
            this.fromDatePicker.TabIndex = 11;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(43, 387);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(186, 24);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(83, 591);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(100, 28);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Apply Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(43, 531);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(185, 22);
            this.commentsTextBox.TabIndex = 7;
            this.commentsTextBox.TextChanged += new System.EventHandler(this.commentsTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(43, 479);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(185, 22);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(39, 458);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(44, 511);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(74, 17);
            this.commentsLabel.TabIndex = 4;
            this.commentsLabel.Text = "Comments";
            // 
            // keyWordLabel
            // 
            this.keyWordLabel.AutoSize = true;
            this.keyWordLabel.Location = new System.Drawing.Point(94, 431);
            this.keyWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyWordLabel.Name = "keyWordLabel";
            this.keyWordLabel.Size = new System.Drawing.Size(70, 17);
            this.keyWordLabel.TabIndex = 3;
            this.keyWordLabel.Text = "Key Word";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(39, 365);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(65, 17);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.AutoSize = true;
            this.dateRangeLabel.Location = new System.Drawing.Point(28, 260);
            this.dateRangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateRangeLabel.Name = "dateRangeLabel";
            this.dateRangeLabel.Size = new System.Drawing.Size(84, 17);
            this.dateRangeLabel.TabIndex = 1;
            this.dateRangeLabel.Text = "Date Range";
            // 
            // formMenuStrip
            // 
            this.formMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.formMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.formMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.formMenuStrip.Name = "formMenuStrip";
            this.formMenuStrip.Size = new System.Drawing.Size(1173, 28);
            this.formMenuStrip.TabIndex = 7;
            this.formMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "IMG_Data.txt";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(464, 511);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UseExifButton
            // 
            this.UseExifButton.Location = new System.Drawing.Point(971, 87);
            this.UseExifButton.Name = "UseExifButton";
            this.UseExifButton.Size = new System.Drawing.Size(135, 30);
            this.UseExifButton.TabIndex = 10;
            this.UseExifButton.Text = "Use Exif Data";
            this.UseExifButton.UseVisualStyleBackColor = true;
            this.UseExifButton.Click += new System.EventHandler(this.UseExifButton_Click);
            // 
            // saveExifButton
            // 
            this.saveExifButton.Location = new System.Drawing.Point(947, 147);
            this.saveExifButton.Name = "saveExifButton";
            this.saveExifButton.Size = new System.Drawing.Size(182, 30);
            this.saveExifButton.TabIndex = 11;
            this.saveExifButton.Text = "Save Exif Data to Images";
            this.saveExifButton.UseVisualStyleBackColor = true;
            this.saveExifButton.Click += new System.EventHandler(this.saveExifButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 690);
            this.Controls.Add(this.saveExifButton);
            this.Controls.Add(this.UseExifButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.formMenuStrip);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.formMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.formMenuStrip.ResumeLayout(false);
            this.formMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label imageNumberLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label keyWordLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dateRangeLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.MenuStrip formMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton FileNameRadioButton;
        private System.Windows.Forms.RadioButton commentsRadioButton;
        private System.Windows.Forms.RadioButton descriptionRadioButton;
        private System.Windows.Forms.RadioButton categoryRadioButton;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button UseExifButton;
        private System.Windows.Forms.Button saveExifButton;
    }
}

