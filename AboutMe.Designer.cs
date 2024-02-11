
namespace Notepad
{
    partial class AboutBox
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
            this.Linker = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Program is made by:";
            // 
            // Linker
            // 
            this.Linker.AutoSize = true;
            this.Linker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Linker.Location = new System.Drawing.Point(12, 58);
            this.Linker.Name = "Linker";
            this.Linker.Size = new System.Drawing.Size(322, 31);
            this.Linker.TabIndex = 1;
            this.Linker.TabStop = true;
            this.Linker.Text = "MrJay Minecrafter Official";
            this.Linker.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linker_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 120);
            this.Controls.Add(this.Linker);
            this.Controls.Add(this.label1);
            this.Name = "AboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Linker;
    }
}