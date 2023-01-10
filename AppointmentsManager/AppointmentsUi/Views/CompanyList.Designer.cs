
namespace AppointmentsUi.Views
{
    partial class CompanyList
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
            this.tableLayoutPanelCompanies = new System.Windows.Forms.TableLayoutPanel();
            this.labelCompaniesHeader = new System.Windows.Forms.Label();
            this.buttonAddNewCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCompanies
            // 
            this.tableLayoutPanelCompanies.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanelCompanies.ColumnCount = 4;
            this.tableLayoutPanelCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCompanies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCompanies.Location = new System.Drawing.Point(-1, 29);
            this.tableLayoutPanelCompanies.Name = "tableLayoutPanelCompanies";
            this.tableLayoutPanelCompanies.RowCount = 1;
            this.tableLayoutPanelCompanies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCompanies.Size = new System.Drawing.Size(802, 423);
            this.tableLayoutPanelCompanies.TabIndex = 0;
            // 
            // labelCompaniesHeader
            // 
            this.labelCompaniesHeader.AutoSize = true;
            this.labelCompaniesHeader.Location = new System.Drawing.Point(-1, 4);
            this.labelCompaniesHeader.Name = "labelCompaniesHeader";
            this.labelCompaniesHeader.Size = new System.Drawing.Size(67, 15);
            this.labelCompaniesHeader.TabIndex = 1;
            this.labelCompaniesHeader.Text = "Companies";
            // 
            // buttonAddNewCompany
            // 
            this.buttonAddNewCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewCompany.Location = new System.Drawing.Point(725, 0);
            this.buttonAddNewCompany.Name = "buttonAddNewCompany";
            this.buttonAddNewCompany.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewCompany.TabIndex = 2;
            this.buttonAddNewCompany.Text = "Add new";
            this.buttonAddNewCompany.UseVisualStyleBackColor = true;
            this.buttonAddNewCompany.Click += new System.EventHandler(this.buttonAddNewCompany_Click);
            // 
            // CompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewCompany);
            this.Controls.Add(this.labelCompaniesHeader);
            this.Controls.Add(this.tableLayoutPanelCompanies);
            this.Name = "CompanyList";
            this.Text = "CompanyList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompanies;
        private System.Windows.Forms.Label labelCompaniesHeader;
        private System.Windows.Forms.Button buttonAddNewCompany;
    }
}