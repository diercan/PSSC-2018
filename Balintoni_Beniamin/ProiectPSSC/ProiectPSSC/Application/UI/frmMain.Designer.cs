namespace ProiectPSSC.Application.UI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pboMain = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.btnShowAllLaptops = new System.Windows.Forms.Button();
            this.grdLaptops = new System.Windows.Forms.DataGridView();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnNewLaptop = new System.Windows.Forms.Button();
            this.btnNewEmployer = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLaptops)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Our DELL Shop";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Navy;
            this.lblLogin.Location = new System.Drawing.Point(276, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(179, 29);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Are you an employer? Login here!";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // pboMain
            // 
            this.pboMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboMain.Image = ((System.Drawing.Image)(resources.GetObject("pboMain.Image")));
            this.pboMain.Location = new System.Drawing.Point(0, 105);
            this.pboMain.Name = "pboMain";
            this.pboMain.Size = new System.Drawing.Size(464, 214);
            this.pboMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboMain.TabIndex = 2;
            this.pboMain.TabStop = false;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 5000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // btnShowAllLaptops
            // 
            this.btnShowAllLaptops.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllLaptops.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnShowAllLaptops.Location = new System.Drawing.Point(12, 325);
            this.btnShowAllLaptops.Name = "btnShowAllLaptops";
            this.btnShowAllLaptops.Size = new System.Drawing.Size(102, 23);
            this.btnShowAllLaptops.TabIndex = 3;
            this.btnShowAllLaptops.Text = "Show our models";
            this.btnShowAllLaptops.UseVisualStyleBackColor = true;
            this.btnShowAllLaptops.Click += new System.EventHandler(this.btnShowAllLaptops_Click);
            // 
            // grdLaptops
            // 
            this.grdLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLaptops.Location = new System.Drawing.Point(12, 354);
            this.grdLaptops.Name = "grdLaptops";
            this.grdLaptops.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdLaptops.Size = new System.Drawing.Size(439, 247);
            this.grdLaptops.TabIndex = 4;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewOrder.Location = new System.Drawing.Point(376, 325);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFilter.Location = new System.Drawing.Point(295, 325);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblFilter.Location = new System.Drawing.Point(242, 325);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(47, 23);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "No Filter";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogout
            // 
            this.lblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogout.Location = new System.Drawing.Point(276, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(179, 23);
            this.lblLogout.TabIndex = 8;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnNewLaptop
            // 
            this.btnNewLaptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLaptop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewLaptop.Location = new System.Drawing.Point(120, 325);
            this.btnNewLaptop.Name = "btnNewLaptop";
            this.btnNewLaptop.Size = new System.Drawing.Size(118, 23);
            this.btnNewLaptop.TabIndex = 9;
            this.btnNewLaptop.Text = "Add New Laptop";
            this.btnNewLaptop.UseVisualStyleBackColor = true;
            this.btnNewLaptop.Click += new System.EventHandler(this.btnNewLaptop_Click);
            // 
            // btnNewEmployer
            // 
            this.btnNewEmployer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmployer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNewEmployer.Location = new System.Drawing.Point(324, 76);
            this.btnNewEmployer.Name = "btnNewEmployer";
            this.btnNewEmployer.Size = new System.Drawing.Size(131, 23);
            this.btnNewEmployer.TabIndex = 10;
            this.btnNewEmployer.Text = "Create New Employer";
            this.btnNewEmployer.UseVisualStyleBackColor = true;
            this.btnNewEmployer.Click += new System.EventHandler(this.btnNewEmployer_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnViewOrders.Location = new System.Drawing.Point(12, 76);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(131, 23);
            this.btnViewOrders.TabIndex = 11;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(463, 616);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnNewEmployer);
            this.Controls.Add(this.btnNewLaptop);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.grdLaptops);
            this.Controls.Add(this.btnShowAllLaptops);
            this.Controls.Add(this.pboMain);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProiectPSSC";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLaptops)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pboMain;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button btnShowAllLaptops;
        private System.Windows.Forms.DataGridView grdLaptops;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnNewLaptop;
        private System.Windows.Forms.Button btnNewEmployer;
        private System.Windows.Forms.Button btnViewOrders;
    }
}