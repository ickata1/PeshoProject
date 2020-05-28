namespace ProgramTest
{
    partial class AddPreset
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.browseLabel = new System.Windows.Forms.Label();
            this.filePathButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(9, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel.Location = new System.Drawing.Point(10, 56);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(44, 17);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(9, 98);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(80, 17);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Preset type";
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseLabel.Location = new System.Drawing.Point(111, 53);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(54, 17);
            this.browseLabel.TabIndex = 6;
            this.browseLabel.Text = "Browse";
            // 
            // filePathButton
            // 
            this.filePathButton.Location = new System.Drawing.Point(115, 76);
            this.filePathButton.Name = "filePathButton";
            this.filePathButton.Size = new System.Drawing.Size(28, 20);
            this.filePathButton.TabIndex = 7;
            this.filePathButton.Text = "...";
            this.filePathButton.UseVisualStyleBackColor = true;
            this.filePathButton.Click += new System.EventHandler(this.FilePathButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(48, 154);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(129, 154);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(9, 75);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 10;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "File",
            "URL",
            "Background"});
            this.typeComboBox.Location = new System.Drawing.Point(9, 116);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // AddPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(214, 187);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.filePathButton);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddPreset";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Button filePathButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}