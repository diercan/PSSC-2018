namespace ProiectPSSC.Application.UI
{
    partial class FrmFilter
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoModel = new System.Windows.Forms.RadioButton();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoPrice = new System.Windows.Forms.RadioButton();
            this.rdoId = new System.Windows.Forms.RadioButton();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.rdoNoFilter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnOk.Location = new System.Drawing.Point(256, 134);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(175, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdoModel
            // 
            this.rdoModel.AutoSize = true;
            this.rdoModel.ForeColor = System.Drawing.Color.White;
            this.rdoModel.Location = new System.Drawing.Point(12, 28);
            this.rdoModel.Name = "rdoModel";
            this.rdoModel.Size = new System.Drawing.Size(130, 17);
            this.rdoModel.TabIndex = 8;
            this.rdoModel.TabStop = true;
            this.rdoModel.Text = "Query laptop by model";
            this.rdoModel.UseVisualStyleBackColor = true;
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.ForeColor = System.Drawing.Color.White;
            this.rdoYear.Location = new System.Drawing.Point(12, 51);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(122, 17);
            this.rdoYear.TabIndex = 9;
            this.rdoYear.TabStop = true;
            this.rdoYear.Text = "Query laptop by year";
            this.rdoYear.UseVisualStyleBackColor = true;
            // 
            // rdoPrice
            // 
            this.rdoPrice.AutoSize = true;
            this.rdoPrice.ForeColor = System.Drawing.Color.White;
            this.rdoPrice.Location = new System.Drawing.Point(12, 74);
            this.rdoPrice.Name = "rdoPrice";
            this.rdoPrice.Size = new System.Drawing.Size(125, 17);
            this.rdoPrice.TabIndex = 10;
            this.rdoPrice.TabStop = true;
            this.rdoPrice.Text = "Query laptop by price";
            this.rdoPrice.UseVisualStyleBackColor = true;
            // 
            // rdoId
            // 
            this.rdoId.AutoSize = true;
            this.rdoId.ForeColor = System.Drawing.Color.White;
            this.rdoId.Location = new System.Drawing.Point(12, 97);
            this.rdoId.Name = "rdoId";
            this.rdoId.Size = new System.Drawing.Size(111, 17);
            this.rdoId.TabIndex = 11;
            this.rdoId.TabStop = true;
            this.rdoId.Text = "Query laptop by Id";
            this.rdoId.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(139, 27);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(192, 20);
            this.txtModel.TabIndex = 12;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(139, 50);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(192, 20);
            this.txtYear.TabIndex = 13;
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Location = new System.Drawing.Point(256, 73);
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(75, 20);
            this.txtPriceTo.TabIndex = 15;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 96);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(192, 20);
            this.txtId.TabIndex = 16;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(136, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "From                         to";
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.Location = new System.Drawing.Point(165, 73);
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Size = new System.Drawing.Size(67, 20);
            this.txtPriceFrom.TabIndex = 18;
            // 
            // rdoNoFilter
            // 
            this.rdoNoFilter.AutoSize = true;
            this.rdoNoFilter.Checked = true;
            this.rdoNoFilter.ForeColor = System.Drawing.Color.White;
            this.rdoNoFilter.Location = new System.Drawing.Point(12, 120);
            this.rdoNoFilter.Name = "rdoNoFilter";
            this.rdoNoFilter.Size = new System.Drawing.Size(61, 17);
            this.rdoNoFilter.TabIndex = 19;
            this.rdoNoFilter.TabStop = true;
            this.rdoNoFilter.Text = "No filter";
            this.rdoNoFilter.UseVisualStyleBackColor = true;
            // 
            // FrmFilter
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(343, 169);
            this.Controls.Add(this.rdoNoFilter);
            this.Controls.Add(this.txtPriceFrom);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPriceTo);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.rdoId);
            this.Controls.Add(this.rdoPrice);
            this.Controls.Add(this.rdoYear);
            this.Controls.Add(this.rdoModel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilter";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter Laptops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoModel;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoPrice;
        private System.Windows.Forms.RadioButton rdoId;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.RadioButton rdoNoFilter;
    }
}