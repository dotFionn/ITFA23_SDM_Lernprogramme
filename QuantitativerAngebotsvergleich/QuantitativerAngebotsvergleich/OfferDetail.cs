using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantitativerAngebotsvergleich
{
    public partial class OfferDetail : Form
    {
        private MainForm mainForm;
        private Offer offer;
        private int existingOfferId;

        internal OfferDetail(MainForm mainForm, Offer existingOffer = null)
        {
            InitializeComponent();

            this.existingOfferId = existingOffer == null ? -1 : existingOffer.offerId;
            this.mainForm = mainForm;

            if (existingOffer == null)
            {
                this.Text = "Angebot hinzufügen";
                offer = new();

                // disable delete button
                buttonDelete.Enabled = false;
            }
            else
            {
                offer = existingOffer;

                // fill input boxes with given values
                textBoxInputLabel.Text = offer.Label;
                textBoxInputListPrice.Text = String.Format("{0}", offer.ListPrice);
                textBoxInputDiscount.Text = String.Format("{0}", offer.Discount);
                textBoxInputEarlyPayDiscount.Text = String.Format("{0}", offer.EarlyPayDiscount);
                textBoxInputDeliveryFee.Text = String.Format("{0}", offer.DeliveryFee);

                // set add offer button to save
                buttonAddOffer.Text = "Speichern";
            }

            RedrawFields();
        }

        private void RedrawFields()
        {
            labelOutputListPrice.Text = $"{mainForm.Meta.Currency} {offer.ListPrice}";
            labelOutputDiscount.Text = $"{mainForm.Meta.Currency} {offer.DiscountAmount}";
            labelOutputPriceTargetPurchase.Text = $"{mainForm.Meta.Currency} {offer.PriceTargetPurchase}";
            labelOutputEarlyPayDiscount.Text = $"{mainForm.Meta.Currency} {offer.EarlyPayDiscountAmount}";
            labelOutputPriceEarlyPayDiscount.Text = $"{mainForm.Meta.Currency} {offer.PriceEarlyPayDiscount}";
            labelOutputDeliveryFee.Text = $"{mainForm.Meta.Currency} {offer.DeliveryFee}";
            labelOutputPriceDelivered.Text = $"{mainForm.Meta.Currency} {offer.PriceDelivered}";
        }

        private void FormFieldUpdate(Control sender)
        {
            try
            {
                if (sender == textBoxInputDiscount)
                {
                    offer.Discount = double.Parse(sender.Text);
                }
                else if (sender == textBoxInputListPrice)
                {
                    offer.ListPrice = double.Parse(sender.Text);
                }
                else if (sender == textBoxInputEarlyPayDiscount)
                {
                    offer.EarlyPayDiscount = double.Parse(sender.Text);
                }
                else if (sender == textBoxInputDeliveryFee)
                {
                    offer.DeliveryFee = double.Parse(sender.Text);
                }
                else if (sender == textBoxInputLabel)
                {
                    offer.Label = sender.Text;
                }
            }
            catch (Exception e) { }


            RedrawFields();
        }

        private void FormFieldUpdate(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                FormFieldUpdate(c);
            }

            return;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteOffer(existingOfferId);

            Close();
        }

        private void buttonAddOffer_Click(object sender, EventArgs e)
        {
            if (existingOfferId == -1)
            {
                mainForm.AddOffer(offer);
            }
            else
            {
                mainForm.OverwriteOffer(existingOfferId, offer);
            }
            Close();
        }
    }
}
