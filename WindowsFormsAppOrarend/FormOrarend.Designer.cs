namespace WindowsFormsAppOrarend
{
    partial class FormOrarend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrarend));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_hetfo = new System.Windows.Forms.ListBox();
            this.listBox_kedd = new System.Windows.Forms.ListBox();
            this.listBox_szerda = new System.Windows.Forms.ListBox();
            this.listBox_csutortok = new System.Windows.Forms.ListBox();
            this.listBox_pentek = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(82, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hétfő";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(246, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kedd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(410, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Szerda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(569, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Csütörtök";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(740, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Péntek";
            // 
            // listBox_hetfo
            // 
            this.listBox_hetfo.FormattingEnabled = true;
            this.listBox_hetfo.Location = new System.Drawing.Point(45, 76);
            this.listBox_hetfo.Name = "listBox_hetfo";
            this.listBox_hetfo.Size = new System.Drawing.Size(120, 303);
            this.listBox_hetfo.TabIndex = 1;
            this.listBox_hetfo.SelectedIndexChanged += new System.EventHandler(this.listBox_hetfo_SelectedIndexChanged);
            // 
            // listBox_kedd
            // 
            this.listBox_kedd.FormattingEnabled = true;
            this.listBox_kedd.Location = new System.Drawing.Point(209, 76);
            this.listBox_kedd.Name = "listBox_kedd";
            this.listBox_kedd.Size = new System.Drawing.Size(120, 303);
            this.listBox_kedd.TabIndex = 1;
            this.listBox_kedd.SelectedIndexChanged += new System.EventHandler(this.listBox_kedd_SelectedIndexChanged);
            // 
            // listBox_szerda
            // 
            this.listBox_szerda.FormattingEnabled = true;
            this.listBox_szerda.Location = new System.Drawing.Point(374, 76);
            this.listBox_szerda.Name = "listBox_szerda";
            this.listBox_szerda.Size = new System.Drawing.Size(120, 303);
            this.listBox_szerda.TabIndex = 1;
            this.listBox_szerda.SelectedIndexChanged += new System.EventHandler(this.listBox_szerda_SelectedIndexChanged);
            // 
            // listBox_csutortok
            // 
            this.listBox_csutortok.FormattingEnabled = true;
            this.listBox_csutortok.Location = new System.Drawing.Point(545, 76);
            this.listBox_csutortok.Name = "listBox_csutortok";
            this.listBox_csutortok.Size = new System.Drawing.Size(120, 303);
            this.listBox_csutortok.TabIndex = 1;
            this.listBox_csutortok.SelectedIndexChanged += new System.EventHandler(this.listBox_csutortok_SelectedIndexChanged);
            // 
            // listBox_pentek
            // 
            this.listBox_pentek.FormattingEnabled = true;
            this.listBox_pentek.Location = new System.Drawing.Point(710, 76);
            this.listBox_pentek.Name = "listBox_pentek";
            this.listBox_pentek.Size = new System.Drawing.Size(120, 303);
            this.listBox_pentek.TabIndex = 1;
            this.listBox_pentek.SelectedIndexChanged += new System.EventHandler(this.listBox_pentek_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.törlésToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Delete";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // FormOrarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 495);
            this.Controls.Add(this.listBox_pentek);
            this.Controls.Add(this.listBox_csutortok);
            this.Controls.Add(this.listBox_szerda);
            this.Controls.Add(this.listBox_kedd);
            this.Controls.Add(this.listBox_hetfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrarend";
            this.Text = "Orarend";
            this.Load += new System.EventHandler(this.FormOrarend_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_hetfo;
        private System.Windows.Forms.ListBox listBox_kedd;
        private System.Windows.Forms.ListBox listBox_szerda;
        private System.Windows.Forms.ListBox listBox_csutortok;
        private System.Windows.Forms.ListBox listBox_pentek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
    }
}