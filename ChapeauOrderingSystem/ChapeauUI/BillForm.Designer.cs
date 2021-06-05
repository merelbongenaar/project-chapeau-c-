
namespace ChapeauUI
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BillPanel = new System.Windows.Forms.Panel();
            this.BtnFinishPayment = new System.Windows.Forms.Button();
            this.txtBoxFeedback = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnPin = new System.Windows.Forms.RadioButton();
            this.radioBtnCash = new System.Windows.Forms.RadioButton();
            this.radioBtnCredit = new System.Windows.Forms.RadioButton();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWaiterID = new System.Windows.Forms.Label();
            this.lblTableID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BillPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(930, 114);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BillPanel
            // 
            this.BillPanel.Controls.Add(this.BtnFinishPayment);
            this.BillPanel.Controls.Add(this.txtBoxFeedback);
            this.BillPanel.Controls.Add(this.label7);
            this.BillPanel.Controls.Add(this.groupBox1);
            this.BillPanel.Controls.Add(this.listViewOrderItems);
            this.BillPanel.Location = new System.Drawing.Point(-11, 115);
            this.BillPanel.Name = "BillPanel";
            this.BillPanel.Size = new System.Drawing.Size(930, 475);
            this.BillPanel.TabIndex = 3;
            // 
            // BtnFinishPayment
            // 
            this.BtnFinishPayment.Location = new System.Drawing.Point(748, 252);
            this.BtnFinishPayment.Name = "BtnFinishPayment";
            this.BtnFinishPayment.Size = new System.Drawing.Size(144, 80);
            this.BtnFinishPayment.TabIndex = 4;
            this.BtnFinishPayment.Text = "&Finish payment";
            this.BtnFinishPayment.UseVisualStyleBackColor = true;
            this.BtnFinishPayment.Click += new System.EventHandler(this.BtnFinishPayment_Click);
            // 
            // txtBoxFeedback
            // 
            this.txtBoxFeedback.Location = new System.Drawing.Point(520, 215);
            this.txtBoxFeedback.Multiline = true;
            this.txtBoxFeedback.Name = "txtBoxFeedback";
            this.txtBoxFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxFeedback.Size = new System.Drawing.Size(188, 172);
            this.txtBoxFeedback.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Feedback";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radioBtnPin);
            this.groupBox1.Controls.Add(this.radioBtnCash);
            this.groupBox1.Controls.Add(this.radioBtnCredit);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblVAT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxTip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblWaiterID);
            this.groupBox1.Controls.Add(this.lblTableID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "€";
            // 
            // radioBtnPin
            // 
            this.radioBtnPin.AutoSize = true;
            this.radioBtnPin.Location = new System.Drawing.Point(23, 92);
            this.radioBtnPin.Name = "radioBtnPin";
            this.radioBtnPin.Size = new System.Drawing.Size(40, 17);
            this.radioBtnPin.TabIndex = 16;
            this.radioBtnPin.TabStop = true;
            this.radioBtnPin.Text = "Pin";
            this.radioBtnPin.UseVisualStyleBackColor = true;
            // 
            // radioBtnCash
            // 
            this.radioBtnCash.AutoSize = true;
            this.radioBtnCash.Location = new System.Drawing.Point(23, 115);
            this.radioBtnCash.Name = "radioBtnCash";
            this.radioBtnCash.Size = new System.Drawing.Size(49, 17);
            this.radioBtnCash.TabIndex = 15;
            this.radioBtnCash.TabStop = true;
            this.radioBtnCash.Text = "Cash";
            this.radioBtnCash.UseVisualStyleBackColor = true;
            // 
            // radioBtnCredit
            // 
            this.radioBtnCredit.AutoSize = true;
            this.radioBtnCredit.Location = new System.Drawing.Point(23, 69);
            this.radioBtnCredit.Name = "radioBtnCredit";
            this.radioBtnCredit.Size = new System.Drawing.Size(76, 17);
            this.radioBtnCredit.TabIndex = 14;
            this.radioBtnCredit.TabStop = true;
            this.radioBtnCredit.Text = "Credit card";
            this.radioBtnCredit.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(678, 86);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(25, 13);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "___";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total amount of bill";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(474, 86);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(19, 13);
            this.lblVAT.TabIndex = 11;
            this.lblVAT.Text = "__";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "VAT";
            // 
            // txtBoxTip
            // 
            this.txtBoxTip.Location = new System.Drawing.Point(268, 82);
            this.txtBoxTip.Name = "txtBoxTip";
            this.txtBoxTip.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTip.TabIndex = 9;
            this.txtBoxTip.TextChanged += new System.EventHandler(this.txtBoxTip_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Choose a payment method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waiter";
            // 
            // lblWaiterID
            // 
            this.lblWaiterID.AutoSize = true;
            this.lblWaiterID.Location = new System.Drawing.Point(235, 16);
            this.lblWaiterID.Name = "lblWaiterID";
            this.lblWaiterID.Size = new System.Drawing.Size(19, 13);
            this.lblWaiterID.TabIndex = 3;
            this.lblWaiterID.Text = "__";
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Location = new System.Drawing.Point(62, 16);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(19, 13);
            this.lblTableID.TabIndex = 1;
            this.lblTableID.Text = "__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemID,
            this.itemName,
            this.itemPrice,
            this.quantity,
            this.category,
            this.subCategory,
            this.comment});
            this.listViewOrderItems.HideSelection = false;
            this.listViewOrderItems.Location = new System.Drawing.Point(16, 215);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(493, 233);
            this.listViewOrderItems.TabIndex = 0;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // itemID
            // 
            this.itemID.Text = "ItemID";
            this.itemID.Width = 43;
            // 
            // itemName
            // 
            this.itemName.Text = "Item name";
            this.itemName.Width = 116;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "Price";
            this.itemPrice.Width = 55;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 57;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 56;
            // 
            // subCategory
            // 
            this.subCategory.Text = "SubCategory";
            this.subCategory.Width = 75;
            // 
            // comment
            // 
            this.comment.Text = "Comment";
            this.comment.Width = 92;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 589);
            this.Controls.Add(this.BillPanel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "BillForm";
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BillPanel.ResumeLayout(false);
            this.BillPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BillPanel;
        private System.Windows.Forms.Button BtnFinishPayment;
        private System.Windows.Forms.TextBox txtBoxFeedback;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnPin;
        private System.Windows.Forms.RadioButton radioBtnCash;
        private System.Windows.Forms.RadioButton radioBtnCredit;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWaiterID;
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader subCategory;
        private System.Windows.Forms.ColumnHeader comment;
    }
}