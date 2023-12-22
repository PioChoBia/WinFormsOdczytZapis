namespace WinFormsOdczytZapis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOdczyt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZapis = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxOkno = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOdczyt,
            this.toolStripButtonZapis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(543, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOdczyt
            // 
            this.toolStripButtonOdczyt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOdczyt.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOdczyt.Image")));
            this.toolStripButtonOdczyt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOdczyt.Name = "toolStripButtonOdczyt";
            this.toolStripButtonOdczyt.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonOdczyt.Text = "odczyt";
            this.toolStripButtonOdczyt.Click += new System.EventHandler(this.toolStripButtonOdczyt_Click);
            // 
            // toolStripButtonZapis
            // 
            this.toolStripButtonZapis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonZapis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZapis.Image")));
            this.toolStripButtonZapis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZapis.Name = "toolStripButtonZapis";
            this.toolStripButtonZapis.Size = new System.Drawing.Size(37, 22);
            this.toolStripButtonZapis.Text = "zapis";
            this.toolStripButtonZapis.Click += new System.EventHandler(this.toolStripButtonZapis_Click);
            // 
            // richTextBoxOkno
            // 
            this.richTextBoxOkno.Location = new System.Drawing.Point(12, 28);
            this.richTextBoxOkno.Name = "richTextBoxOkno";
            this.richTextBoxOkno.Size = new System.Drawing.Size(519, 635);
            this.richTextBoxOkno.TabIndex = 1;
            this.richTextBoxOkno.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 675);
            this.Controls.Add(this.richTextBoxOkno);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonOdczyt;
        private ToolStripButton toolStripButtonZapis;
        private RichTextBox richTextBoxOkno;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}