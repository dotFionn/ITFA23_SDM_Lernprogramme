using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentsUi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            EmbedForm<Views.EmptyPage>();
        }

        internal void EmbedForm<T>() where T : Form, new()
        {
            T embedded = new T() { TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, AutoSize = false, Parent = this };
            embeddingContainer.Controls.Clear();
            embeddingContainer.Controls.Add(embedded);
            embedded.Show();
        }

        private void toolstripAboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vewry guud program mehd by finno");
        }

        private void tooltipAppointsmentsButton_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("appointments button click");
        }

        private void toolstripAppointsmentsAddNewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("appointments add button click");
        }

        private void toolstripContactsButton_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("contacts button click");
        }

        private void toolstripContactsAddNewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("contacts add button click");
        }

        private void toolstripCompaniesButton_ButtonClick(object sender, EventArgs e)
        {
            EmbedForm<Views.CompanyList>();
        }
    }
}
