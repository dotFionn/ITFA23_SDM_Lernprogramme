
namespace AppointmentsUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.tooltipAppointsmentsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripAppointsmentsAddNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripContactsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripContactsAddNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripCompaniesButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripCompaniesAddNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripSalutationsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripSalutationsAddNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripPostalsButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripPostalsAddNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripAboutButton = new System.Windows.Forms.ToolStripButton();
            this.embeddingContainer = new System.Windows.Forms.Panel();
            this.toolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltipAppointsmentsButton,
            this.toolstripContactsButton,
            this.toolstripCompaniesButton,
            this.toolStripSplitButton1,
            this.toolstripSalutationsButton,
            this.toolstripPostalsButton,
            this.toolstripAboutButton});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(800, 25);
            this.toolstrip.TabIndex = 0;
            this.toolstrip.Text = "toolstrip";
            // 
            // tooltipAppointsmentsButton
            // 
            this.tooltipAppointsmentsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tooltipAppointsmentsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripAppointsmentsAddNewButton});
            this.tooltipAppointsmentsButton.Image = ((System.Drawing.Image)(resources.GetObject("tooltipAppointsmentsButton.Image")));
            this.tooltipAppointsmentsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltipAppointsmentsButton.Name = "tooltipAppointsmentsButton";
            this.tooltipAppointsmentsButton.Size = new System.Drawing.Size(99, 22);
            this.tooltipAppointsmentsButton.Text = "Appointments";
            this.tooltipAppointsmentsButton.ButtonClick += new System.EventHandler(this.tooltipAppointsmentsButton_ButtonClick);
            // 
            // toolstripAppointsmentsAddNewButton
            // 
            this.toolstripAppointsmentsAddNewButton.Name = "toolstripAppointsmentsAddNewButton";
            this.toolstripAppointsmentsAddNewButton.Size = new System.Drawing.Size(121, 22);
            this.toolstripAppointsmentsAddNewButton.Text = "Add new";
            this.toolstripAppointsmentsAddNewButton.Click += new System.EventHandler(this.toolstripAppointsmentsAddNewButton_Click);
            // 
            // toolstripContactsButton
            // 
            this.toolstripContactsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripContactsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripContactsAddNewButton});
            this.toolstripContactsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripContactsButton.Image")));
            this.toolstripContactsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripContactsButton.Name = "toolstripContactsButton";
            this.toolstripContactsButton.Size = new System.Drawing.Size(70, 22);
            this.toolstripContactsButton.Text = "Contacts";
            this.toolstripContactsButton.ButtonClick += new System.EventHandler(this.toolstripContactsButton_ButtonClick);
            // 
            // toolstripContactsAddNewButton
            // 
            this.toolstripContactsAddNewButton.Name = "toolstripContactsAddNewButton";
            this.toolstripContactsAddNewButton.Size = new System.Drawing.Size(121, 22);
            this.toolstripContactsAddNewButton.Text = "Add new";
            this.toolstripContactsAddNewButton.Click += new System.EventHandler(this.toolstripContactsAddNewButton_Click);
            // 
            // toolstripCompaniesButton
            // 
            this.toolstripCompaniesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripCompaniesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripCompaniesAddNewButton});
            this.toolstripCompaniesButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripCompaniesButton.Image")));
            this.toolstripCompaniesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripCompaniesButton.Name = "toolstripCompaniesButton";
            this.toolstripCompaniesButton.Size = new System.Drawing.Size(83, 22);
            this.toolstripCompaniesButton.Text = "Companies";
            this.toolstripCompaniesButton.ButtonClick += new System.EventHandler(this.toolstripCompaniesButton_ButtonClick);
            // 
            // toolstripCompaniesAddNewButton
            // 
            this.toolstripCompaniesAddNewButton.Name = "toolstripCompaniesAddNewButton";
            this.toolstripCompaniesAddNewButton.Size = new System.Drawing.Size(180, 22);
            this.toolstripCompaniesAddNewButton.Text = "Add new";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripSplitButton1.Text = "PhoneTypes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItem1.Text = "Add new";
            // 
            // toolstripSalutationsButton
            // 
            this.toolstripSalutationsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripSalutationsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripSalutationsAddNewButton});
            this.toolstripSalutationsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripSalutationsButton.Image")));
            this.toolstripSalutationsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripSalutationsButton.Name = "toolstripSalutationsButton";
            this.toolstripSalutationsButton.Size = new System.Drawing.Size(81, 22);
            this.toolstripSalutationsButton.Text = "Salutations";
            // 
            // toolstripSalutationsAddNewButton
            // 
            this.toolstripSalutationsAddNewButton.Name = "toolstripSalutationsAddNewButton";
            this.toolstripSalutationsAddNewButton.Size = new System.Drawing.Size(121, 22);
            this.toolstripSalutationsAddNewButton.Text = "Add new";
            // 
            // toolstripPostalsButton
            // 
            this.toolstripPostalsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripPostalsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripPostalsAddNewButton});
            this.toolstripPostalsButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripPostalsButton.Image")));
            this.toolstripPostalsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripPostalsButton.Name = "toolstripPostalsButton";
            this.toolstripPostalsButton.Size = new System.Drawing.Size(60, 22);
            this.toolstripPostalsButton.Text = "Postals";
            // 
            // toolstripPostalsAddNewButton
            // 
            this.toolstripPostalsAddNewButton.Name = "toolstripPostalsAddNewButton";
            this.toolstripPostalsAddNewButton.Size = new System.Drawing.Size(121, 22);
            this.toolstripPostalsAddNewButton.Text = "Add new";
            // 
            // toolstripAboutButton
            // 
            this.toolstripAboutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolstripAboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripAboutButton.Image = ((System.Drawing.Image)(resources.GetObject("toolstripAboutButton.Image")));
            this.toolstripAboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripAboutButton.Name = "toolstripAboutButton";
            this.toolstripAboutButton.Size = new System.Drawing.Size(44, 22);
            this.toolstripAboutButton.Text = "About";
            this.toolstripAboutButton.Click += new System.EventHandler(this.toolstripAboutButton_Click);
            // 
            // embeddingContainer
            // 
            this.embeddingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embeddingContainer.BackColor = System.Drawing.SystemColors.Control;
            this.embeddingContainer.Location = new System.Drawing.Point(12, 28);
            this.embeddingContainer.Name = "embeddingContainer";
            this.embeddingContainer.Size = new System.Drawing.Size(776, 410);
            this.embeddingContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.embeddingContainer);
            this.Controls.Add(this.toolstrip);
            this.Name = "MainForm";
            this.Text = "AppointmentsUi";
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripSplitButton tooltipAppointsmentsButton;
        private System.Windows.Forms.ToolStripMenuItem toolstripAppointsmentsAddNewButton;
        private System.Windows.Forms.ToolStripSplitButton toolstripContactsButton;
        private System.Windows.Forms.ToolStripMenuItem toolstripContactsAddNewButton;
        private System.Windows.Forms.ToolStripSplitButton toolstripCompaniesButton;
        private System.Windows.Forms.ToolStripMenuItem toolstripCompaniesAddNewButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolstripSalutationsButton;
        private System.Windows.Forms.ToolStripMenuItem toolstripSalutationsAddNewButton;
        private System.Windows.Forms.ToolStripSplitButton toolstripPostalsButton;
        private System.Windows.Forms.ToolStripMenuItem toolstripPostalsAddNewButton;
        private System.Windows.Forms.ToolStripButton toolstripAboutButton;
        private System.Windows.Forms.Panel embeddingContainer;
    }
}
