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
            this.label1 = new System.Windows.Forms.Label();
            this.PresetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.presetDescription = new System.Windows.Forms.TextBox();
            this.CreatePreset = new System.Windows.Forms.Button();
            this.Dismiss = new System.Windows.Forms.Button();
            this.AddNewPresetSetting = new System.Windows.Forms.Button();
            this.presetSettingsGridBox = new System.Windows.Forms.DataGridView();
            this.testButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presetSettingsGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PresetName
            // 
            this.PresetName.Location = new System.Drawing.Point(21, 39);
            this.PresetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresetName.Name = "PresetName";
            this.PresetName.Size = new System.Drawing.Size(163, 22);
            this.PresetName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // presetDescription
            // 
            this.presetDescription.Location = new System.Drawing.Point(21, 96);
            this.presetDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetDescription.Name = "presetDescription";
            this.presetDescription.Size = new System.Drawing.Size(163, 22);
            this.presetDescription.TabIndex = 3;
            // 
            // CreatePreset
            // 
            this.CreatePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePreset.Location = new System.Drawing.Point(307, 312);
            this.CreatePreset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreatePreset.Name = "CreatePreset";
            this.CreatePreset.Size = new System.Drawing.Size(152, 37);
            this.CreatePreset.TabIndex = 4;
            this.CreatePreset.Text = "Save";
            this.CreatePreset.UseVisualStyleBackColor = true;
            this.CreatePreset.Click += new System.EventHandler(this.CreatePreset_Click);
            // 
            // Dismiss
            // 
            this.Dismiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dismiss.Location = new System.Drawing.Point(476, 312);
            this.Dismiss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dismiss.Name = "Dismiss";
            this.Dismiss.Size = new System.Drawing.Size(152, 37);
            this.Dismiss.TabIndex = 5;
            this.Dismiss.Text = "Back";
            this.Dismiss.UseVisualStyleBackColor = true;
            this.Dismiss.Click += new System.EventHandler(this.Dismiss_Click);
            // 
            // AddNewPresetSetting
            // 
            this.AddNewPresetSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewPresetSetting.Location = new System.Drawing.Point(21, 137);
            this.AddNewPresetSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddNewPresetSetting.Name = "AddNewPresetSetting";
            this.AddNewPresetSetting.Size = new System.Drawing.Size(163, 37);
            this.AddNewPresetSetting.TabIndex = 6;
            this.AddNewPresetSetting.Text = "AddPresetSetting";
            this.AddNewPresetSetting.UseVisualStyleBackColor = true;
            this.AddNewPresetSetting.Click += new System.EventHandler(this.AddNewPresetSetting_Click);
            // 
            // presetSettingsGridBox
            // 
            this.presetSettingsGridBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presetSettingsGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presetSettingsGridBox.Location = new System.Drawing.Point(205, 39);
            this.presetSettingsGridBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.presetSettingsGridBox.Name = "presetSettingsGridBox";
            this.presetSettingsGridBox.RowHeadersWidth = 51;
            this.presetSettingsGridBox.Size = new System.Drawing.Size(423, 246);
            this.presetSettingsGridBox.TabIndex = 7;
            this.presetSettingsGridBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testButton.Location = new System.Drawing.Point(21, 248);
            this.testButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(163, 37);
            this.testButton.TabIndex = 8;
            this.testButton.Text = "Refresh";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(21, 192);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(163, 36);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Preset Setting";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(641, 362);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.presetSettingsGridBox);
            this.Controls.Add(this.AddNewPresetSetting);
            this.Controls.Add(this.Dismiss);
            this.Controls.Add(this.CreatePreset);
            this.Controls.Add(this.presetDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PresetName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditPreset";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EditPreset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presetSettingsGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PresetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox presetDescription;
        private System.Windows.Forms.Button CreatePreset;
        private System.Windows.Forms.Button Dismiss;
        private System.Windows.Forms.Button AddNewPresetSetting;
        private System.Windows.Forms.DataGridView presetSettingsGridBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}