namespace ProgramTest
{
    partial class EditPresetSetting
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
            this.presetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.getFilePathButton = new System.Windows.Forms.Button();
            this.browseLabel = new System.Windows.Forms.Label();
            this.presentTypeLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // presetTypeComboBox
            // 
            this.presetTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetTypeComboBox.FormattingEnabled = true;
            this.presetTypeComboBox.Items.AddRange(new object[] {
            "File",
            "URL",
            "Background"});
            this.presetTypeComboBox.Location = new System.Drawing.Point(12, 113);
            this.presetTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.presetTypeComboBox.Name = "presetTypeComboBox";
            this.presetTypeComboBox.Size = new System.Drawing.Size(100, 21);
            this.presetTypeComboBox.TabIndex = 21;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(12, 73);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 151);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(51, 151);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // getFilePathButton
            // 
            this.getFilePathButton.Location = new System.Drawing.Point(118, 73);
            this.getFilePathButton.Name = "getFilePathButton";
            this.getFilePathButton.Size = new System.Drawing.Size(28, 20);
            this.getFilePathButton.TabIndex = 17;
            this.getFilePathButton.Text = "...";
            this.getFilePathButton.UseVisualStyleBackColor = true;
            this.getFilePathButton.Click += new System.EventHandler(this.GetFilePathButton_Click);
            // 
            // browseLabel
            // 
            this.browseLabel.AutoSize = true;
            this.browseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseLabel.Location = new System.Drawing.Point(114, 50);
            this.browseLabel.Name = "browseLabel";
            this.browseLabel.Size = new System.Drawing.Size(54, 17);
            this.browseLabel.TabIndex = 16;
            this.browseLabel.Text = "Browse";
            // 
            // presentTypeLabel
            // 
            this.presentTypeLabel.AutoSize = true;
            this.presentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presentTypeLabel.Location = new System.Drawing.Point(12, 95);
            this.presentTypeLabel.Name = "presentTypeLabel";
            this.presentTypeLabel.Size = new System.Drawing.Size(80, 17);
            this.presentTypeLabel.TabIndex = 15;
            this.presentTypeLabel.Text = "Preset type";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel.Location = new System.Drawing.Point(12, 50);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(44, 17);
            this.valueLabel.TabIndex = 14;
            this.valueLabel.Text = "Value";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // EditPresetSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(214, 184);
            this.Controls.Add(this.presetTypeComboBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.getFilePathButton);
            this.Controls.Add(this.browseLabel);
            this.Controls.Add(this.presentTypeLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EditPresetSetting";
            this.Text = "EditPresetSetting";
            this.Load += new System.EventHandler(this.EditPresetSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox presetTypeComboBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button getFilePathButton;
        private System.Windows.Forms.Label browseLabel;
        private System.Windows.Forms.Label presentTypeLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}