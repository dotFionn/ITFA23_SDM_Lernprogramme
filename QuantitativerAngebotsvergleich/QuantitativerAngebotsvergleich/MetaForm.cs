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
    public partial class MetaForm : Form
    {
        OfferMeta meta;
        MainForm mainForm;

        internal MetaForm(MainForm mainForm, OfferMeta meta = null)
        {
            InitializeComponent();

            this.meta = meta;
            this.mainForm = mainForm;

            RedrawFields();
        }

        internal void RedrawFields()
        {
            textBoxAmount.Text = meta.Amount.ToString();
            textBoxCurrency.Text = meta.Currency;
        }

        private void FormFieldUpdate(Control sender)
        {
            try
            {
                if (sender == textBoxAmount)
                {
                    meta.Amount = int.Parse(sender.Text);
                }
                else if (sender == textBoxCurrency)
                {
                    meta.Currency = sender.Text;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mainForm.SaveMeta(meta);

            Close();
        }
    }
}
