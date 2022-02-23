namespace QuantitativerAngebotsvergleich
{
    partial class MetaForm
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 9);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 15);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Anzahl";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(12, 38);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(56, 15);
            this.labelCurrency.TabIndex = 1;
            this.labelCurrency.Text = "Währung";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(114, 6);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(157, 23);
            this.textBoxAmount.TabIndex = 2;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(114, 35);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(157, 23);
            this.textBoxCurrency.TabIndex = 3;
            this.textBoxCurrency.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 64);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(259, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 95);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCurrency);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelAmount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetaForm";
            this.Text = "Metadaten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAmount;
        private Label labelCurrency;
        private TextBox textBoxAmount;
        private TextBox textBoxCurrency;
        private Button buttonSave;
    }
}