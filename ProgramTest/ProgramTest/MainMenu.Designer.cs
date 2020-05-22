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
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Preset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Preset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditPreset
            // 
            this.EditPreset.Location = new System.Drawing.Point(22, 102);
            this.EditPreset.Name = "EditPreset";
            this.EditPreset.Size = new System.Drawing.Size(132, 37);
            this.EditPreset.TabIndex = 3;
            this.EditPreset.Text = "Edit Preset";
            this.EditPreset.UseVisualStyleBackColor = true;
            this.EditPreset.Click += new System.EventHandler(this.EditPreset_Click);
            // 
            // runPreset
            // 
            this.runPreset.Location = new System.Drawing.Point(22, 145);
            this.runPreset.Name = "runPreset";
            this.runPreset.Size = new System.Drawing.Size(132, 37);
            this.runPreset.TabIndex = 4;
            this.runPreset.Text = "Run Preset";
            this.runPreset.UseVisualStyleBackColor = true;
            this.runPreset.Click += new System.EventHandler(this.runPreset_Click);
            // 
            // MainMenuDataGrid
            // 
            this.MainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuDataGrid.Location = new System.Drawing.Point(160, 12);
            this.MainMenuDataGrid.Name = "MainMenuDataGrid";
            this.MainMenuDataGrid.Size = new System.Drawing.Size(344, 213);
            this.MainMenuDataGrid.TabIndex = 5;
            this.MainMenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainMenuDataGrid_CellContentClick);
            // 
            // UpdateGrid
            // 
            this.UpdateGrid.Location = new System.Drawing.Point(22, 188);
            this.UpdateGrid.Name = "UpdateGrid";
            this.UpdateGrid.Size = new System.Drawing.Size(132, 37);
            this.UpdateGrid.TabIndex = 6;
            this.UpdateGrid.Text = "Update Table";
            this.UpdateGrid.UseVisualStyleBackColor = true;
            this.UpdateGrid.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 242);
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
    }
}

