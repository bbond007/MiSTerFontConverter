
namespace MiSTerFontConverter
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialogTTF = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxPrv = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownFont = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialogPNG = new System.Windows.Forms.SaveFileDialog();
            this.labelFontNo = new System.Windows.Forms.Label();
            this.labelFontSizeNo = new System.Windows.Forms.Label();
            this.labelCursorCharNo = new System.Windows.Forms.Label();
            this.numericUpDownCursorChar = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxPrvZoom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCursorChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrvZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogTTF
            // 
            this.openFileDialogTTF.DefaultExt = "TTF";
            this.openFileDialogTTF.FileName = "openFileDialog1";
            this.openFileDialogTTF.Filter = "TTF Files|*.TTF";
            // 
            // pictureBoxPrv
            // 
            this.pictureBoxPrv.Location = new System.Drawing.Point(7, 138);
            this.pictureBoxPrv.Name = "pictureBoxPrv";
            this.pictureBoxPrv.Size = new System.Drawing.Size(176, 48);
            this.pictureBoxPrv.TabIndex = 2;
            this.pictureBoxPrv.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(51, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.savePNGToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadToolStripMenuItem.Text = "Load (TTF)";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // savePNGToolStripMenuItem
            // 
            this.savePNGToolStripMenuItem.Name = "savePNGToolStripMenuItem";
            this.savePNGToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.savePNGToolStripMenuItem.Text = "Save (PNG)";
            this.savePNGToolStripMenuItem.Click += new System.EventHandler(this.savePNGToolStripMenuItem_Click);
            // 
            // numericUpDownFont
            // 
            this.numericUpDownFont.Location = new System.Drawing.Point(51, 60);
            this.numericUpDownFont.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownFont.Name = "numericUpDownFont";
            this.numericUpDownFont.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownFont.TabIndex = 6;
            this.numericUpDownFont.ValueChanged += new System.EventHandler(this.numericUpDownFont_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 7;
            // 
            // saveFileDialogPNG
            // 
            this.saveFileDialogPNG.DefaultExt = "PNG";
            // 
            // labelFontNo
            // 
            this.labelFontNo.AutoSize = true;
            this.labelFontNo.Location = new System.Drawing.Point(12, 63);
            this.labelFontNo.Name = "labelFontNo";
            this.labelFontNo.Size = new System.Drawing.Size(34, 13);
            this.labelFontNo.TabIndex = 8;
            this.labelFontNo.Text = "Font :";
            // 
            // labelFontSizeNo
            // 
            this.labelFontSizeNo.AutoSize = true;
            this.labelFontSizeNo.Location = new System.Drawing.Point(12, 88);
            this.labelFontSizeNo.Name = "labelFontSizeNo";
            this.labelFontSizeNo.Size = new System.Drawing.Size(33, 13);
            this.labelFontSizeNo.TabIndex = 9;
            this.labelFontSizeNo.Text = "Size :";
            // 
            // labelCursorCharNo
            // 
            this.labelCursorCharNo.AutoSize = true;
            this.labelCursorCharNo.Location = new System.Drawing.Point(2, 114);
            this.labelCursorCharNo.Name = "labelCursorCharNo";
            this.labelCursorCharNo.Size = new System.Drawing.Size(43, 13);
            this.labelCursorCharNo.TabIndex = 11;
            this.labelCursorCharNo.Text = "Cursor :";
            // 
            // numericUpDownCursorChar
            // 
            this.numericUpDownCursorChar.Location = new System.Drawing.Point(51, 112);
            this.numericUpDownCursorChar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownCursorChar.Name = "numericUpDownCursorChar";
            this.numericUpDownCursorChar.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownCursorChar.TabIndex = 10;
            this.numericUpDownCursorChar.ValueChanged += new System.EventHandler(this.numericUpDownCursorChar_ValueChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Location = new System.Drawing.Point(0, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(305, 13);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "MiSTer TTF to PNG font converter - BBond007";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.labelTitle_Paint);
            // 
            // pictureBoxPrvZoom
            // 
            this.pictureBoxPrvZoom.Location = new System.Drawing.Point(7, 190);
            this.pictureBoxPrvZoom.Name = "pictureBoxPrvZoom";
            this.pictureBoxPrvZoom.Size = new System.Drawing.Size(290, 110);
            this.pictureBoxPrvZoom.TabIndex = 13;
            this.pictureBoxPrvZoom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 308);
            this.Controls.Add(this.pictureBoxPrvZoom);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCursorCharNo);
            this.Controls.Add(this.numericUpDownCursorChar);
            this.Controls.Add(this.labelFontSizeNo);
            this.Controls.Add(this.labelFontNo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDownFont);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBoxPrv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCursorChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrvZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTTF;
        private System.Windows.Forms.PictureBox pictureBoxPrv;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownFont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem savePNGToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPNG;
        private System.Windows.Forms.Label labelFontNo;
        private System.Windows.Forms.Label labelFontSizeNo;
        private System.Windows.Forms.Label labelCursorCharNo;
        private System.Windows.Forms.NumericUpDown numericUpDownCursorChar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxPrvZoom;
    }
}

