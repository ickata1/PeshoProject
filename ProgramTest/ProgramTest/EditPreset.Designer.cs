namespace ProgramTest
{
    partial class EditPreset
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addPresetSettingButton = new System.Windows.Forms.Button();
            this.presetSettingsGridBox = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deletePresetSettingButton = new System.Windows.Forms.Button();
            this.editPresetSettingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presetSettingsGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(123, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(12, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 78);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(123, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(230, 254);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 30);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(357, 254);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 30);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addPresetSettingButton
            // 
            this.addPresetSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPresetSettingButton.Location = new System.Drawing.Point(12, 111);
            this.addPresetSettingButton.Name = "addPresetSettingButton";
            this.addPresetSettingButton.Size = new System.Drawing.Size(132, 30);
            this.addPresetSettingButton.TabIndex = 6;
            this.addPresetSettingButton.Text = "Add Preset Setting";
            this.addPresetSettingButton.UseVisualStyleBackColor = true;
            this.addPresetSettingButton.Click += new System.EventHandler(this.AddNewPresetSetting_Click);
            // 
            // presetSettingsGridBox
            // 
            this.presetSettingsGridBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presetSettingsGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presetSettingsGridBox.Location = new System.Drawing.Point(154, 32);
            this.presetSettingsGridBox.Name = "presetSettingsGridBox";
            this.presetSettingsGridBox.RowHeadersWidth = 51;
            this.presetSettingsGridBox.Size = new System.Drawing.Size(317, 200);
            this.presetSettingsGridBox.TabIndex = 7;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshButton.Location = new System.Drawing.Point(12, 218);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(132, 29);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // deletePresetSettingButton
            // 
            this.deletePresetSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePresetSettingButton.Location = new System.Drawing.Point(12, 183);
            this.deletePresetSettingButton.Name = "deletePresetSettingButton";
            this.deletePresetSettingButton.Size = new System.Drawing.Size(132, 29);
            this.deletePresetSettingButton.TabIndex = 9;
            this.deletePresetSettingButton.Text = "Delete Preset Setting";
            this.deletePresetSettingButton.UseVisualStyleBackColor = true;
            this.deletePresetSettingButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editPresetSettingButton
            // 
            this.editPresetSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPresetSettingButton.Location = new System.Drawing.Point(12, 147);
            this.editPresetSettingButton.Name = "editPresetSettingButton";
            this.editPresetSettingButton.Size = new System.Drawing.Size(132, 30);
            this.editPresetSettingButton.TabIndex = 10;
            this.editPresetSettingButton.Text = "Edit Preset Setting";
            this.editPresetSettingButton.UseVisualStyleBackColor = true;
            this.editPresetSettingButton.Click += new System.EventHandler(this.EditPresetSettingButton_Click);
            // 
            // EditPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(481, 294);
            this.Controls.Add(this.editPresetSettingButton);
            this.Controls.Add(this.deletePresetSettingButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.presetSettingsGridBox);
            this.Controls.Add(this.addPresetSettingButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "EditPreset";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EditPreset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presetSettingsGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addPresetSettingButton;
        private System.Windows.Forms.DataGridView presetSettingsGridBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deletePresetSettingButton;
        private System.Windows.Forms.Button editPresetSettingButton;
    }
}