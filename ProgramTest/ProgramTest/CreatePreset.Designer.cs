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
            this.Name = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.PresetName = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(8, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(8, 55);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(89, 20);
            this.Description.TabIndex = 1;
            this.Description.Text = "Description";
            // 
            // PresetName
            // 
            this.PresetName.Location = new System.Drawing.Point(12, 32);
            this.PresetName.Name = "PresetName";
            this.PresetName.Size = new System.Drawing.Size(132, 20);
            this.PresetName.TabIndex = 2;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(12, 78);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(173, 20);
            this.DescriptionBox.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 111);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 37);
            this.Save.TabIndex = 4;
            this.Save.Text = "Create";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(106, 111);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(87, 37);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreatePreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 217);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PresetName);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Name);
            this.Text = "CreatePreset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox PresetName;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
    }
}