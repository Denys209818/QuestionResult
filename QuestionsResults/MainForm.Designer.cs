
namespace QuestionsResults
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.succStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.sortStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(901, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Головне меню";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStripMenuItem});
            this.fileStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.fileStripMenuItem.Text = "Файл";
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.exitStripMenuItem.Text = "Вийти";
            this.exitStripMenuItem.Click += new System.EventHandler(this.exitStripMenuItem_Click);
            // 
            // sortStripMenuItem
            // 
            this.sortStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.succStripMenuItem,
            this.dateStripMenuItem});
            this.sortStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sortStripMenuItem.Name = "sortStripMenuItem";
            this.sortStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.sortStripMenuItem.Text = "Сортувати за ->";
            // 
            // succStripMenuItem
            // 
            this.succStripMenuItem.Name = "succStripMenuItem";
            this.succStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.succStripMenuItem.Text = "Успішністю";
            this.succStripMenuItem.Click += new System.EventHandler(this.succStripMenuItem_Click);
            // 
            // dateStripMenuItem
            // 
            this.dateStripMenuItem.Name = "dateStripMenuItem";
            this.dateStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.dateStripMenuItem.Text = "Датою";
            this.dateStripMenuItem.Click += new System.EventHandler(this.dateStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(901, 531);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сесій";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem succStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateStripMenuItem;
    }
}