namespace Lottojatekok
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szelvényekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ötösLottóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatosLottóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skandinávLottóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szelvényekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szelvényekToolStripMenuItem
            // 
            this.szelvényekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ötösLottóToolStripMenuItem,
            this.hatosLottóToolStripMenuItem,
            this.skandinávLottóToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.szelvényekToolStripMenuItem.Name = "szelvényekToolStripMenuItem";
            this.szelvényekToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.szelvényekToolStripMenuItem.Text = "Szelvények";
            // 
            // ötösLottóToolStripMenuItem
            // 
            this.ötösLottóToolStripMenuItem.Name = "ötösLottóToolStripMenuItem";
            this.ötösLottóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ötösLottóToolStripMenuItem.Text = "Ötös lottó";
            this.ötösLottóToolStripMenuItem.Click += new System.EventHandler(this.ötösLottóToolStripMenuItem_Click);
            // 
            // hatosLottóToolStripMenuItem
            // 
            this.hatosLottóToolStripMenuItem.Name = "hatosLottóToolStripMenuItem";
            this.hatosLottóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hatosLottóToolStripMenuItem.Text = "Hatos lottó";
            this.hatosLottóToolStripMenuItem.Click += new System.EventHandler(this.hatosLottóToolStripMenuItem_Click);
            // 
            // skandinávLottóToolStripMenuItem
            // 
            this.skandinávLottóToolStripMenuItem.Name = "skandinávLottóToolStripMenuItem";
            this.skandinávLottóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skandinávLottóToolStripMenuItem.Text = "Skandináv lottó";
            this.skandinávLottóToolStripMenuItem.Click += new System.EventHandler(this.skandinávLottóToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Szerencsejáték Zrt.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szelvényekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ötösLottóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatosLottóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skandinávLottóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}

