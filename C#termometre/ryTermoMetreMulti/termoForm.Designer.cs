namespace ryTermoMetreMulti
{
    partial class termoForm
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
            this.lblFahrenheint = new System.Windows.Forms.Label();
            this.lblCentigrade = new System.Windows.Forms.Label();
            this.vsbSicaklik = new System.Windows.Forms.VScrollBar();
            this.btnKapat = new System.Windows.Forms.Button();
            this.termoMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termoMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheint";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(180, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Centigrade";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFahrenheint
            // 
            this.lblFahrenheint.BackColor = System.Drawing.SystemColors.Window;
            this.lblFahrenheint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFahrenheint.Location = new System.Drawing.Point(12, 131);
            this.lblFahrenheint.Name = "lblFahrenheint";
            this.lblFahrenheint.Size = new System.Drawing.Size(100, 24);
            this.lblFahrenheint.TabIndex = 0;
            this.lblFahrenheint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCentigrade
            // 
            this.lblCentigrade.BackColor = System.Drawing.SystemColors.Window;
            this.lblCentigrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCentigrade.Location = new System.Drawing.Point(180, 131);
            this.lblCentigrade.Name = "lblCentigrade";
            this.lblCentigrade.Size = new System.Drawing.Size(100, 24);
            this.lblCentigrade.TabIndex = 0;
            this.lblCentigrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vsbSicaklik
            // 
            this.vsbSicaklik.Location = new System.Drawing.Point(133, 31);
            this.vsbSicaklik.Maximum = 250;
            this.vsbSicaklik.Minimum = -40;
            this.vsbSicaklik.Name = "vsbSicaklik";
            this.vsbSicaklik.Size = new System.Drawing.Size(27, 217);
            this.vsbSicaklik.TabIndex = 1;
            this.vsbSicaklik.Value = 168;
            this.vsbSicaklik.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSicaklik_Scroll);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(205, 231);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 31);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // termoMenu
            // 
            this.termoMenu.Font = new System.Drawing.Font("Verdana", 9F);
            this.termoMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.termoMenu.Location = new System.Drawing.Point(0, 0);
            this.termoMenu.Name = "termoMenu";
            this.termoMenu.Size = new System.Drawing.Size(306, 24);
            this.termoMenu.TabIndex = 3;
            this.termoMenu.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.kapatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatMenuItem.Text = "Çı&kış";
            this.kapatMenuItem.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // termoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.vsbSicaklik);
            this.Controls.Add(this.lblCentigrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFahrenheint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.termoMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.termoMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "termoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sıcaklık Göster";
            this.Load += new System.EventHandler(this.termoForm_Load);
            this.termoMenu.ResumeLayout(false);
            this.termoMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFahrenheint;
        private System.Windows.Forms.Label lblCentigrade;
        private System.Windows.Forms.VScrollBar vsbSicaklik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.MenuStrip termoMenu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
    }
}

