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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_sorszam = new System.Windows.Forms.NumericUpDown();
            this.comboBox_tantargy = new System.Windows.Forms.ComboBox();
            this.comboBox_nap = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tantárgy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sorszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Melyik nap";
            // 
            // numericUpDown_sorszam
            // 
            this.numericUpDown_sorszam.Location = new System.Drawing.Point(174, 362);
            this.numericUpDown_sorszam.Name = "numericUpDown_sorszam";
            this.numericUpDown_sorszam.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_sorszam.TabIndex = 3;
            this.numericUpDown_sorszam.ValueChanged += new System.EventHandler(this.numericUpDown_sorszam_ValueChanged);
            // 
            // comboBox_tantargy
            // 
            this.comboBox_tantargy.FormattingEnabled = true;
            this.comboBox_tantargy.Location = new System.Drawing.Point(12, 362);
            this.comboBox_tantargy.Name = "comboBox_tantargy";
            this.comboBox_tantargy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tantargy.TabIndex = 4;
            this.comboBox_tantargy.SelectedIndexChanged += new System.EventHandler(this.comboBox_tantargy_SelectedIndexChanged);
            // 
            // comboBox_nap
            // 
            this.comboBox_nap.FormattingEnabled = true;
            this.comboBox_nap.Location = new System.Drawing.Point(275, 362);
            this.comboBox_nap.Name = "comboBox_nap";
            this.comboBox_nap.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nap.TabIndex = 4;
            this.comboBox_nap.SelectedIndexChanged += new System.EventHandler(this.comboBox_nap_SelectedIndexChanged);
            // 
            // FormOrarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 444);
            this.Controls.Add(this.comboBox_nap);
            this.Controls.Add(this.comboBox_tantargy);
            this.Controls.Add(this.numericUpDown_sorszam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrarend";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sorszam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_sorszam;
        private System.Windows.Forms.ComboBox comboBox_tantargy;
        private System.Windows.Forms.ComboBox comboBox_nap;
    }
}