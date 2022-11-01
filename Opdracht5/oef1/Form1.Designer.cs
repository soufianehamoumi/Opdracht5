namespace oef1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuCtrlBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smalCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redCtrlRToolStripMenuItem,
            this.bleuCtrlBToolStripMenuItem,
            this.greenCtrlGToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem.Text = "color";
            // 
            // redCtrlRToolStripMenuItem
            // 
            this.redCtrlRToolStripMenuItem.Name = "redCtrlRToolStripMenuItem";
            this.redCtrlRToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.redCtrlRToolStripMenuItem.Text = "Red        Ctrl + R";
            this.redCtrlRToolStripMenuItem.Click += new System.EventHandler(this.redCtrlRToolStripMenuItem_Click);
            // 
            // bleuCtrlBToolStripMenuItem
            // 
            this.bleuCtrlBToolStripMenuItem.Name = "bleuCtrlBToolStripMenuItem";
            this.bleuCtrlBToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.bleuCtrlBToolStripMenuItem.Text = "Bleu    Ctrl + B";
            this.bleuCtrlBToolStripMenuItem.Click += new System.EventHandler(this.bleuCtrlBToolStripMenuItem_Click);
            // 
            // greenCtrlGToolStripMenuItem
            // 
            this.greenCtrlGToolStripMenuItem.Name = "greenCtrlGToolStripMenuItem";
            this.greenCtrlGToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.greenCtrlGToolStripMenuItem.Text = "Green    Ctrl + G";
            this.greenCtrlGToolStripMenuItem.Click += new System.EventHandler(this.greenCtrlGToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.bleuToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backgroundColorToolStripMenuItem.Text = "Background-Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // bleuToolStripMenuItem
            // 
            this.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem";
            this.bleuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bleuToolStripMenuItem.Text = "Bleu";
            this.bleuToolStripMenuItem.Click += new System.EventHandler(this.bleuToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smalCtrlSToolStripMenuItem,
            this.normalCtrlNToolStripMenuItem,
            this.largeCtrlLToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smalCtrlSToolStripMenuItem
            // 
            this.smalCtrlSToolStripMenuItem.Name = "smalCtrlSToolStripMenuItem";
            this.smalCtrlSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.smalCtrlSToolStripMenuItem.Text = "Smal  Ctrl + S";
            this.smalCtrlSToolStripMenuItem.Click += new System.EventHandler(this.smalCtrlSToolStripMenuItem_Click);
            // 
            // normalCtrlNToolStripMenuItem
            // 
            this.normalCtrlNToolStripMenuItem.Name = "normalCtrlNToolStripMenuItem";
            this.normalCtrlNToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalCtrlNToolStripMenuItem.Text = "Normal Ctrl + N";
            this.normalCtrlNToolStripMenuItem.Click += new System.EventHandler(this.normalCtrlNToolStripMenuItem_Click);
            // 
            // largeCtrlLToolStripMenuItem
            // 
            this.largeCtrlLToolStripMenuItem.Name = "largeCtrlLToolStripMenuItem";
            this.largeCtrlLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.largeCtrlLToolStripMenuItem.Text = "Large Ctrl + L";
            this.largeCtrlLToolStripMenuItem.Click += new System.EventHandler(this.largeCtrlLToolStripMenuItem_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(0, 31);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(800, 418);
            this.text.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem redCtrlRToolStripMenuItem;
        private ToolStripMenuItem bleuCtrlBToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem greenCtrlGToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem bleuToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem smalCtrlSToolStripMenuItem;
        private ToolStripMenuItem normalCtrlNToolStripMenuItem;
        private ToolStripMenuItem largeCtrlLToolStripMenuItem;
        private TextBox text;
    }
}