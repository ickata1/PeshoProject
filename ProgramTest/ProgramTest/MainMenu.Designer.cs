namespace ProgramTest
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EditPreset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.runPreset = new System.Windows.Forms.Button();
            this.MainMenuDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateGrid = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Preset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(22, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Preset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditPreset
            // 
            this.EditPreset.Location = new System.Drawing.Point(22, 59);
            this.EditPreset.Name = "EditPreset";
            this.EditPreset.Size = new System.Drawing.Size(132, 37);
            this.EditPreset.TabIndex = 3;
            this.EditPreset.Text = "Edit Preset";
            this.EditPreset.UseVisualStyleBackColor = true;
            this.EditPreset.Click += new System.EventHandler(this.EditPreset_Click);
            // 
            // runPreset
            // 
            this.runPreset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.runPreset.Location = new System.Drawing.Point(22, 264);
            this.runPreset.Name = "runPreset";
            this.runPreset.Size = new System.Drawing.Size(132, 37);
            this.runPreset.TabIndex = 4;
            this.runPreset.Text = "Run Preset";
            this.runPreset.UseVisualStyleBackColor = false;
            this.runPreset.Click += new System.EventHandler(this.runPreset_Click);
            // 
            // MainMenuDataGrid
            // 
            this.MainMenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuDataGrid.Location = new System.Drawing.Point(160, 12);
            this.MainMenuDataGrid.Name = "MainMenuDataGrid";
            this.MainMenuDataGrid.Size = new System.Drawing.Size(344, 213);
            this.MainMenuDataGrid.TabIndex = 5;
            this.MainMenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainMenuDataGrid_CellContentClick);
            // 
            // UpdateGrid
            // 
            this.UpdateGrid.Location = new System.Drawing.Point(160, 231);
            this.UpdateGrid.Name = "UpdateGrid";
            this.UpdateGrid.Size = new System.Drawing.Size(96, 23);
            this.UpdateGrid.TabIndex = 6;
            this.UpdateGrid.Text = "Refresh";
            this.UpdateGrid.UseVisualStyleBackColor = true;
            this.UpdateGrid.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "CloseButton";
            this.button4.Location = new System.Drawing.Point(332, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "ForceCloseButton";
            this.button3.Location = new System.Drawing.Point(421, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Force Close All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ForceCloseButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(516, 314);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.UpdateGrid);
            this.Controls.Add(this.MainMenuDataGrid);
            this.Controls.Add(this.runPreset);
            this.Controls.Add(this.EditPreset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button EditPreset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button runPreset;
        public System.Windows.Forms.DataGridView MainMenuDataGrid;
        private System.Windows.Forms.Button UpdateGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

