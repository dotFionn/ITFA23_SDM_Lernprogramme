namespace QuantitativerAngebotsvergleich
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddNewOffer = new System.Windows.Forms.Button();
            this.offersTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelOfferTitle = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelListPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelPriceTargetPurchase = new System.Windows.Forms.Label();
            this.labelEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelPriceEarlyPayDiscount = new System.Windows.Forms.Label();
            this.labelDeliveryFee = new System.Windows.Forms.Label();
            this.labelPriceDelivered = new System.Windows.Forms.Label();
            this.buttonMetaData = new System.Windows.Forms.Button();
            this.offersTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewOffer
            // 
            this.buttonAddNewOffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewOffer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNewOffer.Location = new System.Drawing.Point(656, 12);
            this.buttonAddNewOffer.Name = "buttonAddNewOffer";
            this.buttonAddNewOffer.Size = new System.Drawing.Size(132, 25);
            this.buttonAddNewOffer.TabIndex = 0;
            this.buttonAddNewOffer.Text = "Angebot hinzufügen";
            this.buttonAddNewOffer.UseVisualStyleBackColor = true;
            this.buttonAddNewOffer.Click += new System.EventHandler(this.buttonAddNewOffer_Click);
            // 
            // offersTablePanel
            // 
            this.offersTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offersTablePanel.AutoSize = true;
            this.offersTablePanel.ColumnCount = 2;
            this.offersTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.offersTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.offersTablePanel.Controls.Add(this.labelOfferTitle, 0, 0);
            this.offersTablePanel.Controls.Add(this.labelEdit, 0, 1);
            this.offersTablePanel.Controls.Add(this.labelListPrice, 0, 2);
            this.offersTablePanel.Controls.Add(this.labelDiscount, 0, 3);
            this.offersTablePanel.Controls.Add(this.labelPriceTargetPurchase, 0, 4);
            this.offersTablePanel.Controls.Add(this.labelEarlyPayDiscount, 0, 5);
            this.offersTablePanel.Controls.Add(this.labelPriceEarlyPayDiscount, 0, 6);
            this.offersTablePanel.Controls.Add(this.labelDeliveryFee, 0, 7);
            this.offersTablePanel.Controls.Add(this.labelPriceDelivered, 0, 8);
            this.offersTablePanel.Location = new System.Drawing.Point(12, 41);
            this.offersTablePanel.Name = "offersTablePanel";
            this.offersTablePanel.RowCount = 11;
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.offersTablePanel.Size = new System.Drawing.Size(776, 220);
            this.offersTablePanel.TabIndex = 1;
            // 
            // labelOfferTitle
            // 
            this.labelOfferTitle.AutoSize = true;
            this.labelOfferTitle.Location = new System.Drawing.Point(3, 0);
            this.labelOfferTitle.Name = "labelOfferTitle";
            this.labelOfferTitle.Size = new System.Drawing.Size(78, 15);
            this.labelOfferTitle.TabIndex = 0;
            this.labelOfferTitle.Text = "Angebotstitel";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(3, 20);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(112, 15);
            this.labelEdit.TabIndex = 1;
            this.labelEdit.Text = "Bearbeiten/Löschen";
            // 
            // labelListPrice
            // 
            this.labelListPrice.AutoSize = true;
            this.labelListPrice.Location = new System.Drawing.Point(3, 35);
            this.labelListPrice.Name = "labelListPrice";
            this.labelListPrice.Size = new System.Drawing.Size(107, 15);
            this.labelListPrice.TabIndex = 2;
            this.labelListPrice.Text = "Listeneinkaufspreis";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(3, 55);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(67, 15);
            this.labelDiscount.TabIndex = 3;
            this.labelDiscount.Text = "Lieferrabatt";
            // 
            // labelPriceTargetPurchase
            // 
            this.labelPriceTargetPurchase.AutoSize = true;
            this.labelPriceTargetPurchase.Location = new System.Drawing.Point(3, 75);
            this.labelPriceTargetPurchase.Name = "labelPriceTargetPurchase";
            this.labelPriceTargetPurchase.Size = new System.Drawing.Size(95, 15);
            this.labelPriceTargetPurchase.TabIndex = 4;
            this.labelPriceTargetPurchase.Text = "Zieleinkaufspreis";
            // 
            // labelEarlyPayDiscount
            // 
            this.labelEarlyPayDiscount.AutoSize = true;
            this.labelEarlyPayDiscount.Location = new System.Drawing.Point(3, 95);
            this.labelEarlyPayDiscount.Name = "labelEarlyPayDiscount";
            this.labelEarlyPayDiscount.Size = new System.Drawing.Size(82, 15);
            this.labelEarlyPayDiscount.TabIndex = 5;
            this.labelEarlyPayDiscount.Text = "Liefererskonto";
            // 
            // labelPriceEarlyPayDiscount
            // 
            this.labelPriceEarlyPayDiscount.AutoSize = true;
            this.labelPriceEarlyPayDiscount.Location = new System.Drawing.Point(3, 115);
            this.labelPriceEarlyPayDiscount.Name = "labelPriceEarlyPayDiscount";
            this.labelPriceEarlyPayDiscount.Size = new System.Drawing.Size(93, 15);
            this.labelPriceEarlyPayDiscount.TabIndex = 6;
            this.labelPriceEarlyPayDiscount.Text = "Bareinkaufspreis";
            // 
            // labelDeliveryFee
            // 
            this.labelDeliveryFee.AutoSize = true;
            this.labelDeliveryFee.Location = new System.Drawing.Point(3, 135);
            this.labelDeliveryFee.Name = "labelDeliveryFee";
            this.labelDeliveryFee.Size = new System.Drawing.Size(79, 15);
            this.labelDeliveryFee.TabIndex = 7;
            this.labelDeliveryFee.Text = "Bezugskosten";
            // 
            // labelPriceDelivered
            // 
            this.labelPriceDelivered.AutoSize = true;
            this.labelPriceDelivered.Location = new System.Drawing.Point(3, 155);
            this.labelPriceDelivered.Name = "labelPriceDelivered";
            this.labelPriceDelivered.Size = new System.Drawing.Size(69, 15);
            this.labelPriceDelivered.TabIndex = 8;
            this.labelPriceDelivered.Text = "Bezugspreis";
            // 
            // buttonMetaData
            // 
            this.buttonMetaData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMetaData.Location = new System.Drawing.Point(12, 12);
            this.buttonMetaData.Name = "buttonMetaData";
            this.buttonMetaData.Size = new System.Drawing.Size(638, 25);
            this.buttonMetaData.TabIndex = 2;
            this.buttonMetaData.Text = "Metadaten";
            this.buttonMetaData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMetaData.UseVisualStyleBackColor = true;
            this.buttonMetaData.Click += new System.EventHandler(this.buttonMetaData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMetaData);
            this.Controls.Add(this.offersTablePanel);
            this.Controls.Add(this.buttonAddNewOffer);
            this.Name = "MainForm";
            this.Text = "Quantitativer Angebotsvergleich";
            this.offersTablePanel.ResumeLayout(false);
            this.offersTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAddNewOffer;
        private TableLayoutPanel offersTablePanel;
        private Label labelOfferTitle;
        private Label labelEdit;
        private Label labelListPrice;
        private Label labelDiscount;
        private Label labelPriceTargetPurchase;
        private Label labelEarlyPayDiscount;
        private Label labelPriceEarlyPayDiscount;
        private Label labelDeliveryFee;
        private Label labelPriceDelivered;
        private Button buttonMetaData;
    }
}