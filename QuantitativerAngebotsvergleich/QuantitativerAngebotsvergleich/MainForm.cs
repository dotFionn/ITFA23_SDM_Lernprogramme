namespace QuantitativerAngebotsvergleich
{
    public partial class MainForm : Form
    {
        internal OfferMeta Meta = new();
        private List<Offer> Offers = new();

        public MainForm()
        {
            InitializeComponent();
        }

        public void AddOffer(Offer offer)
        {
            Offers.Add(offer);
            RedrawFields();
        }

        public void OverwriteOffer(int index, Offer newOffer)
        {
            Offers[index] = newOffer;
            RedrawFields();
        }

        public void DeleteOffer(int index)
        {
            Offers.RemoveAt(index);
            RedrawFields();
        }

        public void SaveMeta(OfferMeta meta)
        {
            Meta = meta;

            buttonMetaData.Text = $"Metadaten | Währung: {Meta.Currency} | Menge: {Meta.Amount}";
        }

        public void RedrawFields()
        {

            // get rid of all controls ad column styles
            offersTablePanel.Controls.Clear();
            offersTablePanel.ColumnStyles.Clear();

            // add column style for label col
            offersTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            // set column count to fit all offers
            offersTablePanel.ColumnCount = Offers.Count + 1;

            // add all controls back
            offersTablePanel.Controls.Add(labelOfferTitle, 0, 0);
            offersTablePanel.Controls.Add(labelEdit, 0, 1);
            offersTablePanel.Controls.Add(labelListPrice, 0, 2);
            offersTablePanel.Controls.Add(labelDiscount, 0, 3);
            offersTablePanel.Controls.Add(labelPriceTargetPurchase, 0, 4);
            offersTablePanel.Controls.Add(labelEarlyPayDiscount, 0, 5);
            offersTablePanel.Controls.Add(labelPriceEarlyPayDiscount, 0, 6);
            offersTablePanel.Controls.Add(labelDeliveryFee, 0, 7);
            offersTablePanel.Controls.Add(labelPriceDelivered, 0, 8);

            // iterate through all offers and create controls and add them
            for (int i = 0; i < Offers.Count; i++)
            {
                // take offer and set offer id for later modification
                Offer offer = Offers[i];
                offer.offerId = i;



                // save column number
                int colNumber = i + 1;

                // create button and add click handler
                Button editButton = new() { Text = "Bearbeiten" };
                editButton.Click += (s, e) => { new OfferDetail(this, offer).Show(); };

                Label labelShowTitle = new() { Text = offer.Label };
                Label labelShowListPrice = new() { Text = FormatCurrency(offer.ListPrice) };
                Label labelShowDiscount = new() { Text = FormatCurrency(offer.DiscountAmount) };
                Label labelShowPriceTargetPurchase = new() { Text = FormatCurrency(offer.PriceTargetPurchase) };
                Label labelShowEarlyPayDiscount = new() { Text = FormatCurrency(offer.EarlyPayDiscountAmount) };
                Label labelShowPriceEarlyPay = new() { Text = FormatCurrency(offer.PriceEarlyPayDiscount) };
                Label labelShowDeliveryFee = new() { Text = FormatCurrency(offer.DeliveryFee) };
                Label labelShowPriceDelivered = new() { Text = FormatCurrency(offer.PriceDelivered) };

                Console.WriteLine("Adding Controls to Column {0}, ColumnCount is {1}", colNumber, offersTablePanel.ColumnCount);

                labelShowTitle.MinimumSize = labelShowTitle.GetPreferredSize(default);

                // add col styling
                offersTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                offersTablePanel.Controls.Add(labelShowTitle, colNumber, 0);
                offersTablePanel.Controls.Add(editButton, colNumber, 1);
                offersTablePanel.Controls.Add(labelShowListPrice, colNumber, 2);
                offersTablePanel.Controls.Add(labelShowDiscount, colNumber, 3);
                offersTablePanel.Controls.Add(labelShowPriceTargetPurchase, colNumber, 4);
                offersTablePanel.Controls.Add(labelShowEarlyPayDiscount, colNumber, 5);
                offersTablePanel.Controls.Add(labelShowPriceEarlyPay, colNumber, 6);
                offersTablePanel.Controls.Add(labelShowDeliveryFee, colNumber, 7);
                offersTablePanel.Controls.Add(labelShowPriceDelivered, colNumber, 8);
            }

            // disable add button if coutn of offers is 2 or more
            buttonAddNewOffer.Enabled = Offers.Count < 2;
        } 

        private void buttonAddNewOffer_Click(object sender, EventArgs e)
        {
            new OfferDetail(this, null).Show();
        }

        private string FormatCurrency(dynamic val)
        {
            return $"{Meta.Currency} {val}";
        }

        private void buttonMetaData_Click(object sender, EventArgs e)
        {
            new MetaForm(this, Meta).Show();
        }
    }

    public class OfferMeta
    {
        public int Amount { get; set; } = 0;
        public string Currency { get; set; } = "€";
    }
}