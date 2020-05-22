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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToEdit = new System.Windows.Forms.Button();
            this.SavePreset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProgramName
            // 
            this.ProgramName.Location = new System.Drawing.Point(12, 36);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(100, 20);
            this.ProgramName.TabIndex = 0;
            this.ProgramName.TextChanged += new System.EventHandler(this.ProgramName_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "File",
            "URL",
            "BG"});
            this.listBox1.Location = new System.Drawing.Point(12, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 17);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preset type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "File path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackToEdit
            // 
            this.BackToEdit.Location = new System.Drawing.Point(12, 190);
            this.BackToEdit.Name = "BackToEdit";
            this.BackToEdit.Size = new System.Drawing.Size(75, 23);
            this.BackToEdit.TabIndex = 8;
            this.BackToEdit.Text = "Back";
            this.BackToEdit.UseVisualStyleBackColor = true;
            this.BackToEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // SavePreset
            // 
            this.SavePreset.Location = new System.Drawing.Point(93, 190);
            this.SavePreset.Name = "SavePreset";
            this.SavePreset.Size = new System.Drawing.Size(75, 23);
            this.SavePreset.TabIndex = 9;
            this.SavePreset.Text = "Save";
            this.SavePreset.UseVisualStyleBackColor = true;
            this.SavePreset.Click += new System.EventHandler(this.SavePreset_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 94);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilePathTextBox.TabIndex = 10;
            this.FilePathTextBox.TextChanged += new System.EventHandler(this.FilePathTextBox_TextChanged);
            // 
            // AddPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 302);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.SavePreset);
            this.Controls.Add(this.BackToEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ProgramName);
            this.Name = "AddPreset";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProgramName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToEdit;
        private System.Windows.Forms.Button SavePreset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox FilePathTextBox;
    }
}