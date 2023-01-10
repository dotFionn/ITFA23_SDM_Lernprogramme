using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentsUi.Views
{
    public partial class CompanyList : Form
    {
        public CompanyList()
        {
            InitializeComponent();

            var companies = AppointmentsLib.Models.Company.GetCompanies();

            for(int i = 0; i < companies.Count(); i++)
            {
                var company = companies.ElementAt(i);

                var labelCompanyId = new Label() { Text = company.CompanyId.ToString(), AutoSize = true, TextAlign = ContentAlignment.MiddleCenter };
                var textboxCompanyName = new TextBox() { Text = company.Label, AutoSize = true };
                var buttonApplyChanges = new Button() { Text = "Apply" };
                var buttonDelete = new Button() { Text = "Delete" };

                buttonApplyChanges.Click += new EventHandler(delegate (object sender, EventArgs e) {
                    company.Save();
                    Program.mainForm.EmbedForm<CompanyList>();
                });
                buttonDelete.Click += new EventHandler(delegate (object sender, EventArgs e) {
                    var res = MessageBox.Show($"Are you sure to delete the company\n{company.Label}\n?", "Delete company?", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        company.Delete();
                        Program.mainForm.EmbedForm<CompanyList>();
                    }
                });
                textboxCompanyName.TextChanged += new EventHandler(delegate (object sender, EventArgs e) {
                    company.Label = textboxCompanyName.Text;
                });

                tableLayoutPanelCompanies.Controls.Add(labelCompanyId, 0, 1 + i);
                tableLayoutPanelCompanies.Controls.Add(textboxCompanyName, 1, 1 + i);
                tableLayoutPanelCompanies.Controls.Add(buttonApplyChanges, 2, 1 + i);
                tableLayoutPanelCompanies.Controls.Add(buttonDelete, 3, 1 + i);
            }
        }

        private void buttonAddNewCompany_Click(object sender, EventArgs e)
        {
            AppointmentsLib.Models.Company.Create("New company");
            Program.mainForm.EmbedForm<CompanyList>();
        }
    }
}
