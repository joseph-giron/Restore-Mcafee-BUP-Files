namespace Restore_Mcafee_BUP_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.AllowDrop = true;
            this.tbFile.Location = new System.Drawing.Point(5, 27);
            this.tbFile.Multiline = true;
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(276, 254);
            this.tbFile.TabIndex = 1;
            this.tbFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFile_DragDrop);
            this.tbFile.DragOver += new System.Windows.Forms.DragEventHandler(this.tbFile_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drag && Drop Files Here";
            // 
            // tbresult
            // 
            this.tbresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbresult.Location = new System.Drawing.Point(5, 287);
            this.tbresult.Multiline = true;
            this.tbresult.Name = "tbresult";
            this.tbresult.ReadOnly = true;
            this.tbresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbresult.Size = new System.Drawing.Size(276, 48);
            this.tbresult.TabIndex = 1;
            this.tbresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.tbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Restore McAfee BUP Files";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbresult;
    }
}

