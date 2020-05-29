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
            this.presetType = new System.Windows.Forms.ComboBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.SavePreset = new System.Windows.Forms.Button();
            this.BackToEdit = new System.Windows.Forms.Button();
            this.getFilePathButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // presetType
            // 
            this.presetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetType.FormattingEnabled = true;
            this.presetType.Items.AddRange(new object[] {
            "File",
            "URL",
            "Background"});
            this.presetType.Location = new System.Drawing.Point(12, 113);
            this.presetType.Margin = new System.Windows.Forms.Padding(2);
            this.presetType.Name = "presetType";
            this.presetType.Size = new System.Drawing.Size(100, 21);
            this.presetType.TabIndex = 21;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(12, 73);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueTextBox.TabIndex = 20;
            // 
            // SavePreset
            // 
            this.SavePreset.Location = new System.Drawing.Point(132, 151);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(75, 23);
            this.SavePreset.TabIndex = 19;
            this.SavePreset.Text = "Save";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // BackToEdit
            // 
            this.BackToEdit.Location = new System.Drawing.Point(51, 151);
            this.BackToEdit.Name = "BackToEdit";
            this.BackToEdit.Size = new System.Drawing.Size(75, 23);
            this.BackToEdit.TabIndex = 18;
            this.BackToEdit.Text = "Back";
            this.BackToEdit.UseVisualStyleBackColor = true;
            // 
            // getFilePathButton
            // 
            this.getFilePathButton.Location = new System.Drawing.Point(118, 73);
            this.getFilePathButton.Name = "getFilePathButton";
            this.getFilePathButton.Size = new System.Drawing.Size(28, 20);
            this.getFilePathButton.TabIndex = 17;
            this.getFilePathButton.Text = "...";
            this.getFilePathButton.UseVisualStyleBackColor = true;
            this.getFilePathButton.Click += new System.EventHandler(this.getFilePathButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(114, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Browse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preset type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
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
            this.Controls.Add(this.presetType);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.SavePreset);
            this.Controls.Add(this.BackToEdit);
            this.Controls.Add(this.getFilePathButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EditPresetSetting";
            this.Text = "EditPresetSetting";
            this.Load += new System.EventHandler(this.EditPresetSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox presetType;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button SavePreset;
        private System.Windows.Forms.Button BackToEdit;
        private System.Windows.Forms.Button getFilePathButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}