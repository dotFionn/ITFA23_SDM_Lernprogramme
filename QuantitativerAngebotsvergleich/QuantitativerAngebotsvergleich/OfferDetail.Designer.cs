namespace QuantitativerAngebotsvergleich
{
    partial class OfferDetail
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
            this.buttonAddOffer = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxInputListPrice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPriceDelivered = new System.Windows.Forms.Label();
            this.labelOutputDiscount = new System.Windows.Forms.Label();
            this.labelField = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInputListPrice = new System.Windows.Forms.Label();
            this.labelOutputListPrice = new System.Windows.Forms.Label();
            this.textBoxInputDiscount = new System.Windows.Forms.TextBox();
            this.labelInputDiscount = new System.Windows.Forms.Label();
            this.labelPriceTargetPurchase = new System.Windows.Forms.Label();
            this.labelInputEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelPriceEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelInputDeliveryFee = new System.Windows.Forms.Label();
            this.textBoxInputEarlyPayDiscount = new System.Windows.Forms.TextBox();
            this.textBoxInputDeliveryFee = new System.Windows.Forms.TextBox();
            this.labelOutputPriceTargetPurchase = new System.Windows.Forms.Label();
            this.labelOutputEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelOutputPriceEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelOutputDeliveryFee = new System.Windows.Forms.Label();
            this.labelOutputPriceDelivered = new System.Windows.Forms.Label();
            this.labelInputLabel = new System.Windows.Forms.Label();
            this.textBoxInputLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddOffer
            // 
            this.buttonAddOffer.Location = new System.Drawing.Point(247, 283);
            this.buttonAddOffer.Name = "buttonAddOffer";
            this.buttonAddOffer.Size = new System.Drawing.Size(226, 23);
            this.buttonAddOffer.TabIndex = 0;
            this.buttonAddOffer.Text = "Hinzufügen";
            this.buttonAddOffer.UseVisualStyleBackColor = true;
            this.buttonAddOffer.Click += new System.EventHandler(this.buttonAddOffer_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(229, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxInputListPrice
            // 
            this.textBoxInputListPrice.Location = new System.Drawing.Point(156, 23);
            this.textBoxInputListPrice.Name = "textBoxInputListPrice";
            this.textBoxInputListPrice.Size = new System.Drawing.Size(146, 23);
            this.textBoxInputListPrice.TabIndex = 2;
            this.textBoxInputListPrice.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.labelPriceDelivered, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputDiscount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInputListPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelField, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOutput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInputListPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputListPrice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInputDiscount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelInputDiscount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPriceTargetPurchase, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelInputEarlyPayDiscount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPriceEarlyPayDiscount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelInputDeliveryFee, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInputEarlyPayDiscount, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInputDeliveryFee, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputPriceTargetPurchase, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputEarlyPayDiscount, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputPriceEarlyPayDiscount, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputDeliveryFee, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelOutputPriceDelivered, 2, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 242);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelPriceDelivered
            // 
            this.labelPriceDelivered.AutoSize = true;
            this.labelPriceDelivered.Location = new System.Drawing.Point(3, 200);
            this.labelPriceDelivered.Name = "labelPriceDelivered";
            this.labelPriceDelivered.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelPriceDelivered.Size = new System.Drawing.Size(69, 21);
            this.labelPriceDelivered.TabIndex = 14;
            this.labelPriceDelivered.Text = "Bezugspreis";
            // 
            // labelOutputDiscount
            // 
            this.labelOutputDiscount.AutoSize = true;
            this.labelOutputDiscount.Location = new System.Drawing.Point(309, 50);
            this.labelOutputDiscount.Name = "labelOutputDiscount";
            this.labelOutputDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputDiscount.Size = new System.Drawing.Size(117, 21);
            this.labelOutputDiscount.TabIndex = 10;
            this.labelOutputDiscount.Text = "labelOutputDiscount";
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelField.Location = new System.Drawing.Point(3, 0);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(30, 15);
            this.labelField.TabIndex = 3;
            this.labelField.Text = "Feld";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.Location = new System.Drawing.Point(156, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(50, 15);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Eingabe";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(309, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(54, 15);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "Ausgabe";
            // 
            // labelInputListPrice
            // 
            this.labelInputListPrice.AutoSize = true;
            this.labelInputListPrice.Location = new System.Drawing.Point(3, 20);
            this.labelInputListPrice.Name = "labelInputListPrice";
            this.labelInputListPrice.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelInputListPrice.Size = new System.Drawing.Size(107, 21);
            this.labelInputListPrice.TabIndex = 6;
            this.labelInputListPrice.Text = "Listeneinkaufspreis";
            // 
            // labelOutputListPrice
            // 
            this.labelOutputListPrice.AutoSize = true;
            this.labelOutputListPrice.Location = new System.Drawing.Point(309, 20);
            this.labelOutputListPrice.Name = "labelOutputListPrice";
            this.labelOutputListPrice.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputListPrice.Size = new System.Drawing.Size(114, 21);
            this.labelOutputListPrice.TabIndex = 7;
            this.labelOutputListPrice.Text = "labelOutputListPrice";
            // 
            // textBoxInputDiscount
            // 
            this.textBoxInputDiscount.Location = new System.Drawing.Point(156, 53);
            this.textBoxInputDiscount.Name = "textBoxInputDiscount";
            this.textBoxInputDiscount.Size = new System.Drawing.Size(146, 23);
            this.textBoxInputDiscount.TabIndex = 8;
            this.textBoxInputDiscount.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // labelInputDiscount
            // 
            this.labelInputDiscount.AutoSize = true;
            this.labelInputDiscount.Location = new System.Drawing.Point(3, 50);
            this.labelInputDiscount.Name = "labelInputDiscount";
            this.labelInputDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelInputDiscount.Size = new System.Drawing.Size(67, 21);
            this.labelInputDiscount.TabIndex = 9;
            this.labelInputDiscount.Text = "Lieferrabatt";
            // 
            // labelPriceTargetPurchase
            // 
            this.labelPriceTargetPurchase.AutoSize = true;
            this.labelPriceTargetPurchase.Location = new System.Drawing.Point(3, 80);
            this.labelPriceTargetPurchase.Name = "labelPriceTargetPurchase";
            this.labelPriceTargetPurchase.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelPriceTargetPurchase.Size = new System.Drawing.Size(95, 21);
            this.labelPriceTargetPurchase.TabIndex = 11;
            this.labelPriceTargetPurchase.Text = "Zieleinkaufspreis";
            // 
            // labelInputEarlyPayDiscount
            // 
            this.labelInputEarlyPayDiscount.AutoSize = true;
            this.labelInputEarlyPayDiscount.Location = new System.Drawing.Point(3, 110);
            this.labelInputEarlyPayDiscount.Name = "labelInputEarlyPayDiscount";
            this.labelInputEarlyPayDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelInputEarlyPayDiscount.Size = new System.Drawing.Size(72, 21);
            this.labelInputEarlyPayDiscount.TabIndex = 12;
            this.labelInputEarlyPayDiscount.Text = "Lieferskonto";
            // 
            // labelPriceEarlyPayDiscount
            // 
            this.labelPriceEarlyPayDiscount.AutoSize = true;
            this.labelPriceEarlyPayDiscount.Location = new System.Drawing.Point(3, 140);
            this.labelPriceEarlyPayDiscount.Name = "labelPriceEarlyPayDiscount";
            this.labelPriceEarlyPayDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelPriceEarlyPayDiscount.Size = new System.Drawing.Size(93, 21);
            this.labelPriceEarlyPayDiscount.TabIndex = 13;
            this.labelPriceEarlyPayDiscount.Text = "Bareinkaufspreis";
            // 
            // labelInputDeliveryFee
            // 
            this.labelInputDeliveryFee.AutoSize = true;
            this.labelInputDeliveryFee.Location = new System.Drawing.Point(3, 170);
            this.labelInputDeliveryFee.Name = "labelInputDeliveryFee";
            this.labelInputDeliveryFee.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelInputDeliveryFee.Size = new System.Drawing.Size(79, 21);
            this.labelInputDeliveryFee.TabIndex = 15;
            this.labelInputDeliveryFee.Text = "Bezugskosten";
            // 
            // textBoxInputEarlyPayDiscount
            // 
            this.textBoxInputEarlyPayDiscount.Location = new System.Drawing.Point(156, 113);
            this.textBoxInputEarlyPayDiscount.Name = "textBoxInputEarlyPayDiscount";
            this.textBoxInputEarlyPayDiscount.Size = new System.Drawing.Size(146, 23);
            this.textBoxInputEarlyPayDiscount.TabIndex = 17;
            this.textBoxInputEarlyPayDiscount.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // textBoxInputDeliveryFee
            // 
            this.textBoxInputDeliveryFee.Location = new System.Drawing.Point(156, 173);
            this.textBoxInputDeliveryFee.Name = "textBoxInputDeliveryFee";
            this.textBoxInputDeliveryFee.Size = new System.Drawing.Size(146, 23);
            this.textBoxInputDeliveryFee.TabIndex = 19;
            this.textBoxInputDeliveryFee.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // labelOutputPriceTargetPurchase
            // 
            this.labelOutputPriceTargetPurchase.AutoSize = true;
            this.labelOutputPriceTargetPurchase.Location = new System.Drawing.Point(309, 80);
            this.labelOutputPriceTargetPurchase.Name = "labelOutputPriceTargetPurchase";
            this.labelOutputPriceTargetPurchase.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputPriceTargetPurchase.Size = new System.Drawing.Size(146, 30);
            this.labelOutputPriceTargetPurchase.TabIndex = 21;
            this.labelOutputPriceTargetPurchase.Text = "labelOutputPriceTargetPurchase";
            // 
            // labelOutputEarlyPayDiscount
            // 
            this.labelOutputEarlyPayDiscount.AutoSize = true;
            this.labelOutputEarlyPayDiscount.Location = new System.Drawing.Point(309, 110);
            this.labelOutputEarlyPayDiscount.Name = "labelOutputEarlyPayDiscount";
            this.labelOutputEarlyPayDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputEarlyPayDiscount.Size = new System.Drawing.Size(143, 30);
            this.labelOutputEarlyPayDiscount.TabIndex = 22;
            this.labelOutputEarlyPayDiscount.Text = "labelOutputEarlyPayDiscount";
            // 
            // labelOutputPriceEarlyPayDiscount
            // 
            this.labelOutputPriceEarlyPayDiscount.AutoSize = true;
            this.labelOutputPriceEarlyPayDiscount.Location = new System.Drawing.Point(309, 140);
            this.labelOutputPriceEarlyPayDiscount.Name = "labelOutputPriceEarlyPayDiscount";
            this.labelOutputPriceEarlyPayDiscount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputPriceEarlyPayDiscount.Size = new System.Drawing.Size(148, 30);
            this.labelOutputPriceEarlyPayDiscount.TabIndex = 23;
            this.labelOutputPriceEarlyPayDiscount.Text = "labelOutputPriceEarlyPayDiscount";
            // 
            // labelOutputDeliveryFee
            // 
            this.labelOutputDeliveryFee.AutoSize = true;
            this.labelOutputDeliveryFee.Location = new System.Drawing.Point(309, 170);
            this.labelOutputDeliveryFee.Name = "labelOutputDeliveryFee";
            this.labelOutputDeliveryFee.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputDeliveryFee.Size = new System.Drawing.Size(130, 21);
            this.labelOutputDeliveryFee.TabIndex = 24;
            this.labelOutputDeliveryFee.Text = "labelOutputDeliveryFee";
            // 
            // labelOutputPriceDelivered
            // 
            this.labelOutputPriceDelivered.AutoSize = true;
            this.labelOutputPriceDelivered.Location = new System.Drawing.Point(309, 200);
            this.labelOutputPriceDelivered.Name = "labelOutputPriceDelivered";
            this.labelOutputPriceDelivered.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelOutputPriceDelivered.Size = new System.Drawing.Size(145, 21);
            this.labelOutputPriceDelivered.TabIndex = 25;
            this.labelOutputPriceDelivered.Text = "labelOutputPriceDelivered";
            // 
            // labelInputLabel
            // 
            this.labelInputLabel.AutoSize = true;
            this.labelInputLabel.Location = new System.Drawing.Point(15, 9);
            this.labelInputLabel.Name = "labelInputLabel";
            this.labelInputLabel.Size = new System.Drawing.Size(35, 15);
            this.labelInputLabel.TabIndex = 4;
            this.labelInputLabel.Text = "Label";
            // 
            // textBoxInputLabel
            // 
            this.textBoxInputLabel.Location = new System.Drawing.Point(168, 6);
            this.textBoxInputLabel.Name = "textBoxInputLabel";
            this.textBoxInputLabel.Size = new System.Drawing.Size(305, 23);
            this.textBoxInputLabel.TabIndex = 26;
            this.textBoxInputLabel.TextChanged += new System.EventHandler(this.FormFieldUpdate);
            // 
            // OfferDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 314);
            this.Controls.Add(this.textBoxInputLabel);
            this.Controls.Add(this.labelInputLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddOffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OfferDetail";
            this.Text = "Angebotsdetails";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddOffer;
        private Button buttonCancel;
        private TextBox textBoxInputListPrice;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelOutputDiscount;
        private Label labelField;
        private Label labelInput;
        private Label labelOutput;
        private Label labelInputListPrice;
        private Label labelOutputListPrice;
        private TextBox textBoxInputDiscount;
        private Label labelInputDiscount;
        private Label labelPriceDelivered;
        private Label labelPriceTargetPurchase;
        private Label labelInputEarlyPayDiscount;
        private Label labelPriceEarlyPayDiscount;
        private Label labelInputDeliveryFee;
        private TextBox textBoxInputEarlyPayDiscount;
        private TextBox textBoxInputDeliveryFee;
        private Label labelOutputPriceTargetPurchase;
        private Label labelOutputEarlyPayDiscount;
        private Label labelOutputPriceEarlyPayDiscount;
        private Label labelOutputDeliveryFee;
        private Label labelOutputPriceDelivered;
        private Label labelInputLabel;
        private TextBox textBoxInputLabel;
    }
}