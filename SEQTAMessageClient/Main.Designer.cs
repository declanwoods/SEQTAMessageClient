namespace SEQTAMessageClient
{
    partial class Main
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
            this.btnselectrec = new System.Windows.Forms.Button();
            this.btnloaddata = new System.Windows.Forms.Button();
            this.rtbmessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnselectrec
            // 
            this.btnselectrec.Location = new System.Drawing.Point(12, 12);
            this.btnselectrec.Name = "btnselectrec";
            this.btnselectrec.Size = new System.Drawing.Size(108, 23);
            this.btnselectrec.TabIndex = 0;
            this.btnselectrec.Text = "Select Recipients";
            this.btnselectrec.UseVisualStyleBackColor = true;
            this.btnselectrec.Click += new System.EventHandler(this.btnselectrec_Click);
            // 
            // btnloaddata
            // 
            this.btnloaddata.Location = new System.Drawing.Point(126, 12);
            this.btnloaddata.Name = "btnloaddata";
            this.btnloaddata.Size = new System.Drawing.Size(100, 23);
            this.btnloaddata.TabIndex = 1;
            this.btnloaddata.Text = "Load Insert Data";
            this.btnloaddata.UseVisualStyleBackColor = true;
            this.btnloaddata.Click += new System.EventHandler(this.btnloaddata_Click);
            // 
            // rtbmessage
            // 
            this.rtbmessage.Location = new System.Drawing.Point(12, 66);
            this.rtbmessage.Name = "rtbmessage";
            this.rtbmessage.Size = new System.Drawing.Size(709, 379);
            this.rtbmessage.TabIndex = 2;
            this.rtbmessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(632, 451);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(89, 23);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btninfo
            // 
            this.btninfo.Location = new System.Drawing.Point(651, 12);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(70, 23);
            this.btninfo.TabIndex = 5;
            this.btninfo.Text = "Info";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(570, 12);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 483);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbmessage);
            this.Controls.Add(this.btnloaddata);
            this.Controls.Add(this.btnselectrec);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselectrec;
        private System.Windows.Forms.Button btnloaddata;
        private System.Windows.Forms.RichTextBox rtbmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnlogin;
    }
}

