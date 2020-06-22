namespace PaymentBussinesRuleEngine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnMambership = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewMembership = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantityUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.DvPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DvPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.txtCustomerAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembership)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(116, 258);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(158, 23);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Payment Physical ";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(116, 312);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(158, 23);
            this.btnBooking.TabIndex = 8;
            this.btnBooking.Text = "Payment for Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnMambership
            // 
            this.btnMambership.Location = new System.Drawing.Point(442, 183);
            this.btnMambership.Name = "btnMambership";
            this.btnMambership.Size = new System.Drawing.Size(158, 23);
            this.btnMambership.TabIndex = 13;
            this.btnMambership.Text = "Payment for Membership";
            this.btnMambership.UseVisualStyleBackColor = true;
            this.btnMambership.Click += new System.EventHandler(this.btnMambership_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(666, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Payment for Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewMembership
            // 
            this.dataGridViewMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembership.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.customerAdd,
            this.customerNo,
            this.customerEmail});
            this.dataGridViewMembership.Location = new System.Drawing.Point(417, 239);
            this.dataGridViewMembership.Name = "dataGridViewMembership";
            this.dataGridViewMembership.Size = new System.Drawing.Size(443, 156);
            this.dataGridViewMembership.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(116, 20);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(185, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(116, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name";
            // 
            // txtQuantityUnit
            // 
            this.txtQuantityUnit.Location = new System.Drawing.Point(116, 121);
            this.txtQuantityUnit.Name = "txtQuantityUnit";
            this.txtQuantityUnit.Size = new System.Drawing.Size(185, 20);
            this.txtQuantityUnit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(116, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "QuantityUnit";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(116, 156);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(185, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 159);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // txtCommision
            // 
            this.txtCommision.Location = new System.Drawing.Point(116, 195);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.ReadOnly = true;
            this.txtCommision.Size = new System.Drawing.Size(185, 20);
            this.txtCommision.TabIndex = 6;
            this.txtCommision.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Agent Commision";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(816, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DvPrintPreviewDialog
            // 
            this.DvPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DvPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DvPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DvPrintPreviewDialog.Enabled = true;
            this.DvPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DvPrintPreviewDialog.Icon")));
            this.DvPrintPreviewDialog.Name = "DvPrintPreviewDialog";
            this.DvPrintPreviewDialog.Visible = false;
            // 
            // DvPrintDocument
            // 
            this.DvPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DvPrintDocument_PrintPage);
            // 
            // txtCustomerAdd
            // 
            this.txtCustomerAdd.Location = new System.Drawing.Point(576, 51);
            this.txtCustomerAdd.Name = "txtCustomerAdd";
            this.txtCustomerAdd.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerAdd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 54);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Customer Address";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(576, 21);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 24);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer ID";
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(576, 85);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerNo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 88);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer No";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(576, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 126);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Customer Email";
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Customer ID";
            this.customerId.Name = "customerId";
            // 
            // customerAdd
            // 
            this.customerAdd.HeaderText = "Customer Address";
            this.customerAdd.Name = "customerAdd";
            // 
            // customerNo
            // 
            this.customerNo.HeaderText = "Customer Mob. No.";
            this.customerNo.Name = "customerNo";
            // 
            // customerEmail
            // 
            this.customerEmail.HeaderText = "Customer Email";
            this.customerEmail.Name = "customerEmail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 452);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantityUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMembership);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMambership);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnPayment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembership)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnMambership;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewMembership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantityUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PrintPreviewDialog DvPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument DvPrintDocument;
        private System.Windows.Forms.TextBox txtCustomerAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmail;
    }
}

