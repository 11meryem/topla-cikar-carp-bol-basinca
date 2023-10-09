namespace button._20
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
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCikar = new System.Windows.Forms.RadioButton();
            this.rbCarp = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(13, 26);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(52, 17);
            this.rbTopla.TabIndex = 0;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "Topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCikar
            // 
            this.rbCikar.AutoSize = true;
            this.rbCikar.Location = new System.Drawing.Point(107, 26);
            this.rbCikar.Name = "rbCikar";
            this.rbCikar.Size = new System.Drawing.Size(49, 17);
            this.rbCikar.TabIndex = 1;
            this.rbCikar.TabStop = true;
            this.rbCikar.Text = "Çıkar";
            this.rbCikar.UseVisualStyleBackColor = true;
            // 
            // rbCarp
            // 
            this.rbCarp.AutoSize = true;
            this.rbCarp.Location = new System.Drawing.Point(195, 26);
            this.rbCarp.Name = "rbCarp";
            this.rbCarp.Size = new System.Drawing.Size(47, 17);
            this.rbCarp.TabIndex = 2;
            this.rbCarp.TabStop = true;
            this.rbCarp.Text = "Çarp";
            this.rbCarp.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(286, 26);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(40, 17);
            this.rbBol.TabIndex = 3;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "Böl";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sayı 2";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(160, 164);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(38, 13);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "Sonuç";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(75, 62);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 8;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(75, 98);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 248);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbCarp);
            this.Controls.Add(this.rbCikar);
            this.Controls.Add(this.rbTopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCikar;
        private System.Windows.Forms.RadioButton rbCarp;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
    }
}

