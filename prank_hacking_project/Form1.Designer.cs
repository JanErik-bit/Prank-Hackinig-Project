namespace prank_hacking_project
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
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.progresslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(189, 298);
            this.progressBar.Maximum = 10000000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(378, 23);
            this.progressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retrieving Data";
            // 
            // progressTimer
            // 
            this.progressTimer.Enabled = true;
            this.progressTimer.Interval = 10;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.Location = new System.Drawing.Point(189, 279);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(35, 13);
            this.progresslabel.TabIndex = 2;
            this.progresslabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Prank Hacking Fenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label progresslabel;
    }
}

