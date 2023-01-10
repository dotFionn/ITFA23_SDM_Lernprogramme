
namespace AppointmentsUi.Views
{
    partial class EmptyPage
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
            this.noPageSelectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noPageSelectedLabel
            // 
            this.noPageSelectedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noPageSelectedLabel.Location = new System.Drawing.Point(0, 0);
            this.noPageSelectedLabel.Name = "noPageSelectedLabel";
            this.noPageSelectedLabel.Size = new System.Drawing.Size(800, 450);
            this.noPageSelectedLabel.TabIndex = 0;
            this.noPageSelectedLabel.Text = "No Page selected...";
            this.noPageSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmptyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noPageSelectedLabel);
            this.Name = "EmptyPage";
            this.Text = "EmptyPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noPageSelectedLabel;
    }
}