namespace YT_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_url = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Rockwell Nova Cond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(35, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(254, 36);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "YouTube Downloader";
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(38, 150);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(281, 79);
            this.btn_download.TabIndex = 1;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(35, 79);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(29, 13);
            this.lbl_url.TabIndex = 2;
            this.lbl_url.Text = "URL";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(38, 111);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(281, 20);
            this.txt_url.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 312);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox txt_url;
    }
}

