
namespace ChapeauUI
{
    partial class TableOverview
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
            this.pnlTableOverview = new System.Windows.Forms.Panel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblTableNR = new System.Windows.Forms.Label();
            this.btnPayForOrder = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.listViewOrderTableOverview = new System.Windows.Forms.ListView();
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItemQNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTable4 = new System.Windows.Forms.Button();
            this.lblEmployeeInfo = new System.Windows.Forms.Label();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable7 = new System.Windows.Forms.Button();
            this.bntTable8 = new System.Windows.Forms.Button();
            this.btnTable10 = new System.Windows.Forms.Button();
            this.btnTable9 = new System.Windows.Forms.Button();
            this.pnlTableOverview.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTableOverview
            // 
            this.pnlTableOverview.BackColor = System.Drawing.Color.Pink;
            this.pnlTableOverview.Controls.Add(this.btnTable9);
            this.pnlTableOverview.Controls.Add(this.btnTable10);
            this.pnlTableOverview.Controls.Add(this.bntTable8);
            this.pnlTableOverview.Controls.Add(this.btnTable7);
            this.pnlTableOverview.Controls.Add(this.btnTable6);
            this.pnlTableOverview.Controls.Add(this.btnTable5);
            this.pnlTableOverview.Controls.Add(this.btnTable1);
            this.pnlTableOverview.Controls.Add(this.btnRefresh);
            this.pnlTableOverview.Controls.Add(this.pnlOrder);
            this.pnlTableOverview.Controls.Add(this.btnTable4);
            this.pnlTableOverview.Controls.Add(this.lblEmployeeInfo);
            this.pnlTableOverview.Controls.Add(this.btnTable2);
            this.pnlTableOverview.Controls.Add(this.btnTable3);
            this.pnlTableOverview.Location = new System.Drawing.Point(12, 12);
            this.pnlTableOverview.Name = "pnlTableOverview";
            this.pnlTableOverview.Size = new System.Drawing.Size(887, 644);
            this.pnlTableOverview.TabIndex = 0;
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.Color.Yellow;
            this.btnTable1.Location = new System.Drawing.Point(152, 58);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(75, 72);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(17, 611);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlOrder.Controls.Add(this.lblTableNR);
            this.pnlOrder.Controls.Add(this.btnPayForOrder);
            this.pnlOrder.Controls.Add(this.btnAddItem);
            this.pnlOrder.Controls.Add(this.listViewOrderTableOverview);
            this.pnlOrder.Location = new System.Drawing.Point(605, 13);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(270, 620);
            this.pnlOrder.TabIndex = 7;
            // 
            // lblTableNR
            // 
            this.lblTableNR.AutoSize = true;
            this.lblTableNR.Location = new System.Drawing.Point(19, 12);
            this.lblTableNR.Name = "lblTableNR";
            this.lblTableNR.Size = new System.Drawing.Size(90, 13);
            this.lblTableNR.TabIndex = 11;
            this.lblTableNR.Text = "No table selected";
            // 
            // btnPayForOrder
            // 
            this.btnPayForOrder.Location = new System.Drawing.Point(135, 593);
            this.btnPayForOrder.Name = "btnPayForOrder";
            this.btnPayForOrder.Size = new System.Drawing.Size(114, 23);
            this.btnPayForOrder.TabIndex = 10;
            this.btnPayForOrder.Text = "&Pay for order";
            this.btnPayForOrder.UseVisualStyleBackColor = true;
            this.btnPayForOrder.Click += new System.EventHandler(this.btnPayForOrder_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(19, 593);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(114, 23);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "&Add items";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // listViewOrderTableOverview
            // 
            this.listViewOrderTableOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItem,
            this.orderItemQNT});
            this.listViewOrderTableOverview.HideSelection = false;
            this.listViewOrderTableOverview.Location = new System.Drawing.Point(19, 31);
            this.listViewOrderTableOverview.Name = "listViewOrderTableOverview";
            this.listViewOrderTableOverview.Size = new System.Drawing.Size(230, 558);
            this.listViewOrderTableOverview.TabIndex = 4;
            this.listViewOrderTableOverview.UseCompatibleStateImageBehavior = false;
            this.listViewOrderTableOverview.View = System.Windows.Forms.View.Details;
            this.listViewOrderTableOverview.SelectedIndexChanged += new System.EventHandler(this.listViewOrderTableOverview_SelectedIndexChanged);
            // 
            // orderItem
            // 
            this.orderItem.Text = "Items";
            this.orderItem.Width = 170;
            // 
            // orderItemQNT
            // 
            this.orderItemQNT.Text = "qnt";
            // 
            // btnTable4
            // 
            this.btnTable4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable4.Location = new System.Drawing.Point(294, 178);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(75, 72);
            this.btnTable4.TabIndex = 6;
            this.btnTable4.Text = "Table 4";
            this.btnTable4.UseVisualStyleBackColor = false;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // lblEmployeeInfo
            // 
            this.lblEmployeeInfo.AutoSize = true;
            this.lblEmployeeInfo.Location = new System.Drawing.Point(14, 611);
            this.lblEmployeeInfo.Name = "lblEmployeeInfo";
            this.lblEmployeeInfo.Size = new System.Drawing.Size(16, 13);
            this.lblEmployeeInfo.TabIndex = 5;
            this.lblEmployeeInfo.Text = "...";
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable2.Location = new System.Drawing.Point(294, 58);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(75, 72);
            this.btnTable2.TabIndex = 3;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable3.Location = new System.Drawing.Point(152, 178);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(75, 71);
            this.btnTable3.TabIndex = 2;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable5.Location = new System.Drawing.Point(152, 308);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(75, 72);
            this.btnTable5.TabIndex = 9;
            this.btnTable5.Text = "Table 5";
            this.btnTable5.UseVisualStyleBackColor = false;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable6.Location = new System.Drawing.Point(294, 308);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(75, 72);
            this.btnTable6.TabIndex = 10;
            this.btnTable6.Text = "Table 6";
            this.btnTable6.UseVisualStyleBackColor = false;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // btnTable7
            // 
            this.btnTable7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable7.Location = new System.Drawing.Point(152, 423);
            this.btnTable7.Name = "btnTable7";
            this.btnTable7.Size = new System.Drawing.Size(75, 72);
            this.btnTable7.TabIndex = 11;
            this.btnTable7.Text = "Table 7";
            this.btnTable7.UseVisualStyleBackColor = false;
            this.btnTable7.Click += new System.EventHandler(this.btnTable7_Click);
            // 
            // bntTable8
            // 
            this.bntTable8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bntTable8.Location = new System.Drawing.Point(294, 423);
            this.bntTable8.Name = "bntTable8";
            this.bntTable8.Size = new System.Drawing.Size(75, 72);
            this.bntTable8.TabIndex = 12;
            this.bntTable8.Text = "Table 8";
            this.bntTable8.UseVisualStyleBackColor = false;
            this.bntTable8.Click += new System.EventHandler(this.bntTable8_Click);
            // 
            // btnTable10
            // 
            this.btnTable10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable10.Location = new System.Drawing.Point(294, 530);
            this.btnTable10.Name = "btnTable10";
            this.btnTable10.Size = new System.Drawing.Size(75, 72);
            this.btnTable10.TabIndex = 13;
            this.btnTable10.Text = "Table 10";
            this.btnTable10.UseVisualStyleBackColor = false;
            this.btnTable10.Click += new System.EventHandler(this.btnTable10_Click);
            // 
            // btnTable9
            // 
            this.btnTable9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTable9.Location = new System.Drawing.Point(152, 530);
            this.btnTable9.Name = "btnTable9";
            this.btnTable9.Size = new System.Drawing.Size(75, 72);
            this.btnTable9.TabIndex = 14;
            this.btnTable9.Text = "Table 9";
            this.btnTable9.UseVisualStyleBackColor = false;
            this.btnTable9.Click += new System.EventHandler(this.btnTable9_Click);
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(911, 668);
            this.Controls.Add(this.pnlTableOverview);
            this.Name = "TableOverview";
            this.Text = "TableOverview";
            this.pnlTableOverview.ResumeLayout(false);
            this.pnlTableOverview.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableOverview;
        private System.Windows.Forms.Button btnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.ListView listViewOrderTableOverview;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.ColumnHeader orderItemQNT;
        private System.Windows.Forms.Label lblEmployeeInfo;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPayForOrder;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblTableNR;
        private System.Windows.Forms.Button btnTable9;
        private System.Windows.Forms.Button btnTable10;
        private System.Windows.Forms.Button bntTable8;
        private System.Windows.Forms.Button btnTable7;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable5;
    }
}