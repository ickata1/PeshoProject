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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EditPreset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.runPreset = new System.Windows.Forms.Button();
            this.MainMenuDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateGrid = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.presetSettingsPanel = new System.Windows.Forms.Panel();
            this.presetSettingsButton = new System.Windows.Forms.Button();
            this.presetSettingsTimerPreset = new System.Windows.Forms.Timer(this.components);
            this.presetSettingsTimerClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.closePanel.SuspendLayout();
            this.presetSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Preset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Preset";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditPreset
            // 
            this.EditPreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditPreset.FlatAppearance.BorderSize = 0;
            this.EditPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditPreset.Location = new System.Drawing.Point(0, 92);
            this.EditPreset.Margin = new System.Windows.Forms.Padding(4);
            this.EditPreset.Name = "EditPreset";
            this.EditPreset.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.EditPreset.Size = new System.Drawing.Size(200, 50);
            this.EditPreset.TabIndex = 3;
            this.EditPreset.Text = "Edit Preset";
            this.EditPreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditPreset.UseVisualStyleBackColor = false;
            this.EditPreset.Click += new System.EventHandler(this.EditPreset_Click);
            // 
            // runPreset
            // 
            this.runPreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runPreset.FlatAppearance.BorderSize = 0;
            this.runPreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runPreset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.runPreset.Location = new System.Drawing.Point(0, 47);
            this.runPreset.Margin = new System.Windows.Forms.Padding(4);
            this.runPreset.Name = "runPreset";
            this.runPreset.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.runPreset.Size = new System.Drawing.Size(200, 50);
            this.runPreset.TabIndex = 4;
            this.runPreset.Text = "Run Preset";
            this.runPreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runPreset.UseVisualStyleBackColor = false;
            this.runPreset.Click += new System.EventHandler(this.runPreset_Click);
            // 
            // MainMenuDataGrid
            // 
            this.MainMenuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainMenuDataGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.MainMenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MainMenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainMenuDataGrid.Location = new System.Drawing.Point(198, 0);
            this.MainMenuDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuDataGrid.Name = "MainMenuDataGrid";
            this.MainMenuDataGrid.RowHeadersWidth = 51;
            this.MainMenuDataGrid.Size = new System.Drawing.Size(472, 262);
            this.MainMenuDataGrid.TabIndex = 5;
            this.MainMenuDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainMenuDataGrid_CellContentClick);
            // 
            // UpdateGrid
            // 
            this.UpdateGrid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateGrid.FlatAppearance.BorderSize = 0;
            this.UpdateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateGrid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateGrid.Location = new System.Drawing.Point(0, 129);
            this.UpdateGrid.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateGrid.Name = "UpdateGrid";
            this.UpdateGrid.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.UpdateGrid.Size = new System.Drawing.Size(200, 50);
            this.UpdateGrid.TabIndex = 6;
            this.UpdateGrid.Text = "Refresh";
            this.UpdateGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGrid.UseVisualStyleBackColor = false;
            this.UpdateGrid.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "CloseButton";
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(0, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close All";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "ForceCloseButton";
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(0, 87);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Force Close All";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ForceCloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.closePanel);
            this.panel1.Controls.Add(this.UpdateGrid);
            this.panel1.Controls.Add(this.presetSettingsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 527);
            this.panel1.TabIndex = 10;
            // 
            // closePanel
            // 
            this.closePanel.Controls.Add(this.closeButton);
            this.closePanel.Controls.Add(this.button4);
            this.closePanel.Controls.Add(this.button3);
            this.closePanel.Location = new System.Drawing.Point(0, 87);
            this.closePanel.MaximumSize = new System.Drawing.Size(200, 141);
            this.closePanel.MinimumSize = new System.Drawing.Size(200, 43);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(200, 43);
            this.closePanel.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(0, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(200, 43);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // presetSettingsPanel
            // 
            this.presetSettingsPanel.Controls.Add(this.presetSettingsButton);
            this.presetSettingsPanel.Controls.Add(this.runPreset);
            this.presetSettingsPanel.Controls.Add(this.EditPreset);
            this.presetSettingsPanel.Controls.Add(this.button1);
            this.presetSettingsPanel.Controls.Add(this.button2);
            this.presetSettingsPanel.Location = new System.Drawing.Point(0, 41);
            this.presetSettingsPanel.MaximumSize = new System.Drawing.Size(200, 225);
            this.presetSettingsPanel.MinimumSize = new System.Drawing.Size(200, 50);
            this.presetSettingsPanel.Name = "presetSettingsPanel";
            this.presetSettingsPanel.Size = new System.Drawing.Size(200, 50);
            this.presetSettingsPanel.TabIndex = 11;
            // 
            // presetSettingsButton
            // 
            this.presetSettingsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presetSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.presetSettingsButton.FlatAppearance.BorderSize = 0;
            this.presetSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presetSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presetSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetSettingsButton.Location = new System.Drawing.Point(0, 0);
            this.presetSettingsButton.Name = "presetSettingsButton";
            this.presetSettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.presetSettingsButton.Size = new System.Drawing.Size(200, 50);
            this.presetSettingsButton.TabIndex = 12;
            this.presetSettingsButton.Text = "Preset Settings";
            this.presetSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.presetSettingsButton.UseVisualStyleBackColor = false;
            this.presetSettingsButton.Click += new System.EventHandler(this.presetSettingsButton_Click);
            // 
            // presetSettingsTimerPreset
            // 
            this.presetSettingsTimerPreset.Interval = 15;
            this.presetSettingsTimerPreset.Tick += new System.EventHandler(this.presetSettingsTimer_Tick);
            // 
            // presetSettingsTimerClose
            // 
            this.presetSettingsTimerClose.Interval = 10;
            this.presetSettingsTimerClose.Tick += new System.EventHandler(this.presetSettingsTimerClose_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(670, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.closePanel.ResumeLayout(false);
            this.presetSettingsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel presetSettingsPanel;
        private System.Windows.Forms.Button presetSettingsButton;
        private System.Windows.Forms.Timer presetSettingsTimerPreset;
        private System.Windows.Forms.Timer presetSettingsTimerClose;
    }
}

