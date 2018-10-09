namespace SEQTAMessageClient
{
    partial class LoadData
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
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnprog = new System.Windows.Forms.Button();
            this.btncsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(12, 12);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(194, 23);
            this.btnexcel.TabIndex = 0;
            this.btnexcel.Text = "Excel (.xlsx)";
            this.btnexcel.UseVisualStyleBackColor = true;
            // 
            // btnprog
            // 
            this.btnprog.Location = new System.Drawing.Point(12, 41);
            this.btnprog.Name = "btnprog";
            this.btnprog.Size = new System.Drawing.Size(194, 23);
            this.btnprog.TabIndex = 1;
            this.btnprog.Text = "Program (STDIN/STDOUT)";
            this.btnprog.UseVisualStyleBackColor = true;
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(12, 70);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(194, 23);
            this.btncsv.TabIndex = 2;
            this.btncsv.Text = "CSV File";
            this.btncsv.UseVisualStyleBackColor = true;
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 106);
            this.Controls.Add(this.btncsv);
            this.Controls.Add(this.btnprog);
            this.Controls.Add(this.btnexcel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadData";
            this.Text = "Load Data";
            this.Load += new System.EventHandler(this.LoadData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnprog;
        private System.Windows.Forms.Button btncsv;
    }
}