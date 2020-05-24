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
            this.ProgramName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToEdit = new System.Windows.Forms.Button();
            this.SavePreset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.presetType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ProgramName
            // 
            this.ProgramName.Location = new System.Drawing.Point(12, 39);
            this.ProgramName.Margin = new System.Windows.Forms.Padding(4);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(132, 22);
            this.ProgramName.TabIndex = 0;
            this.ProgramName.TextChanged += new System.EventHandler(this.ProgramName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preset type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(148, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Browse";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackToEdit
            // 
            this.BackToEdit.Location = new System.Drawing.Point(64, 189);
            this.BackToEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BackToEdit.Name = "BackToEdit";
            this.BackToEdit.Size = new System.Drawing.Size(100, 28);
            this.BackToEdit.TabIndex = 8;
            this.BackToEdit.Text = "Back";
            this.BackToEdit.UseVisualStyleBackColor = true;
            this.BackToEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavePreset
            // 
            this.SavePreset.Location = new System.Drawing.Point(172, 189);
            this.SavePreset.Margin = new System.Windows.Forms.Padding(4);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(100, 28);
            this.SavePreset.TabIndex = 9;
            this.SavePreset.Text = "Save";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 94);
            this.FilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(132, 22);
            this.FilePathTextBox.TabIndex = 10;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // presetType
            // 
            this.presetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetType.FormattingEnabled = true;
            this.presetType.Items.AddRange(new object[] {
            "File",
            "URL",
            "Background"});
            this.presetType.Location = new System.Drawing.Point(12, 143);
            this.presetType.Name = "presetType";
            this.presetType.Size = new System.Drawing.Size(132, 24);
            this.presetType.TabIndex = 11;
            // 
            // AddPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(285, 230);
            this.Controls.Add(this.presetType);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.SavePreset);
            this.Controls.Add(this.BackToEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgramName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPreset";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProgramName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToEdit;
        private System.Windows.Forms.Button SavePreset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.ComboBox presetType;
    }
}