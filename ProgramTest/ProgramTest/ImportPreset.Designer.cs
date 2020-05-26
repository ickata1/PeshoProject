namespace ProgramTest
{
    partial class ImportPreset
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
            this.exportButton = new System.Windows.Forms.Button();
            this.filePathButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.FilePathImportLabel = new System.Windows.Forms.Label();
            this.filePathImportTextBox = new System.Windows.Forms.TextBox();
            this.filePathImportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.MainMenuDataGrid = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 67);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 23);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export Preset";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // filePathButton
            // 
            this.filePathButton.Location = new System.Drawing.Point(182, 39);
            this.filePathButton.Name = "filePathButton";
            this.filePathButton.Size = new System.Drawing.Size(24, 20);
            this.filePathButton.TabIndex = 3;
            this.filePathButton.Text = "...";
            this.filePathButton.UseVisualStyleBackColor = true;
            this.filePathButton.Click += new System.EventHandler(this.filePathButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 39);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(164, 20);
            this.filePathTextBox.TabIndex = 4;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(13, 20);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(48, 13);
            this.filePathLabel.TabIndex = 5;
            this.filePathLabel.Text = "File Path";
            // 
            // FilePathImportLabel
            // 
            this.FilePathImportLabel.AutoSize = true;
            this.FilePathImportLabel.Location = new System.Drawing.Point(13, 110);
            this.FilePathImportLabel.Name = "FilePathImportLabel";
            this.FilePathImportLabel.Size = new System.Drawing.Size(48, 13);
            this.FilePathImportLabel.TabIndex = 9;
            this.FilePathImportLabel.Text = "File Path";
            // 
            // filePathImportTextBox
            // 
            this.filePathImportTextBox.Location = new System.Drawing.Point(12, 129);
            this.filePathImportTextBox.Name = "filePathImportTextBox";
            this.filePathImportTextBox.Size = new System.Drawing.Size(164, 20);
            this.filePathImportTextBox.TabIndex = 8;
            // 
            // filePathImportButton
            // 
            this.filePathImportButton.Location = new System.Drawing.Point(182, 129);
            this.filePathImportButton.Name = "filePathImportButton";
            this.filePathImportButton.Size = new System.Drawing.Size(24, 20);
            this.filePathImportButton.TabIndex = 7;
            this.filePathImportButton.Text = "...";
            this.filePathImportButton.UseVisualStyleBackColor = true;
            this.filePathImportButton.Click += new System.EventHandler(this.filePathImportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(12, 157);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(100, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import Preset";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // MainMenuDataGrid
            // 
            this.MainMenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuDataGrid.Location = new System.Drawing.Point(242, 12);
            this.MainMenuDataGrid.Name = "MainMenuDataGrid";
            this.MainMenuDataGrid.Size = new System.Drawing.Size(344, 168);
            this.MainMenuDataGrid.TabIndex = 10;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(242, 187);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ImportPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(603, 252);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.MainMenuDataGrid);
            this.Controls.Add(this.FilePathImportLabel);
            this.Controls.Add(this.filePathImportTextBox);
            this.Controls.Add(this.filePathImportButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.filePathButton);
            this.Controls.Add(this.exportButton);
            this.Name = "ImportPreset";
            this.Text = "Debug";
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button filePathButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label FilePathImportLabel;
        private System.Windows.Forms.TextBox filePathImportTextBox;
        private System.Windows.Forms.Button filePathImportButton;
        private System.Windows.Forms.Button importButton;
        public System.Windows.Forms.DataGridView MainMenuDataGrid;
        private System.Windows.Forms.Button refreshButton;
    }
}