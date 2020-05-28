namespace ProgramTest
{
    partial class CreatePreset
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.createPresetButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(11, 11);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(11, 68);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 39);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 15;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(175, 19);
            this.nameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 96);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.MaxLength = 100;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(229, 19);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // createPresetButton
            // 
            this.createPresetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPresetButton.Location = new System.Drawing.Point(16, 137);
            this.createPresetButton.Margin = new System.Windows.Forms.Padding(4);
            this.createPresetButton.Name = "createPresetButton";
            this.createPresetButton.Size = new System.Drawing.Size(117, 46);
            this.createPresetButton.TabIndex = 4;
            this.createPresetButton.Text = "Create";
            this.createPresetButton.UseVisualStyleBackColor = true;
            this.createPresetButton.Click += new System.EventHandler(this.CreatePresetButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(141, 137);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(116, 46);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreatePreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(417, 208);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createPresetButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePreset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button createPresetButton;
        private System.Windows.Forms.Button backButton;
    }
}