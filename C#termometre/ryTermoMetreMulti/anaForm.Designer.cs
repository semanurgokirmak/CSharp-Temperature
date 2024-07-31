namespace ryTermoMetreMulti
{
    partial class anaForm
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTermo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chbOnay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(24, 204);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 34);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTermo
            // 
            this.btnTermo.Location = new System.Drawing.Point(140, 204);
            this.btnTermo.Name = "btnTermo";
            this.btnTermo.Size = new System.Drawing.Size(107, 34);
            this.btnTermo.TabIndex = 1;
            this.btnTermo.Text = "Termometre";
            this.btnTermo.UseVisualStyleBackColor = true;
            this.btnTermo.Click += new System.EventHandler(this.btnTermo_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 132);
            this.label1.TabIndex = 2;
            this.label1.Text = "TERMOMETRE PROGRAMINA HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbOnay
            // 
            this.chbOnay.AutoSize = true;
            this.chbOnay.Location = new System.Drawing.Point(48, 167);
            this.chbOnay.Name = "chbOnay";
            this.chbOnay.Size = new System.Drawing.Size(171, 21);
            this.chbOnay.TabIndex = 3;
            this.chbOnay.Text = "Giriş için işaretleyiniz";
            this.chbOnay.UseVisualStyleBackColor = true;
            this.chbOnay.CheckedChanged += new System.EventHandler(this.chbOnay_CheckedChanged);
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 258);
            this.ControlBox = false;
            this.Controls.Add(this.chbOnay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTermo);
            this.Controls.Add(this.btnKapat);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termometre Ana Form";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTermo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbOnay;
    }
}