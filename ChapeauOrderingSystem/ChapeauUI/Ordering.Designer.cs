
namespace ChapeauUI
{
    partial class Ordering
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
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblTableNr = new System.Windows.Forms.Label();
            this.bttnLunch = new System.Windows.Forms.Button();
            this.bttnDiner = new System.Windows.Forms.Button();
            this.bttnDrinks = new System.Windows.Forms.Button();
            this.listViewOrderOrder = new System.Windows.Forms.ListView();
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItemQNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnSend = new System.Windows.Forms.Button();
            this.bttnRemoveItem = new System.Windows.Forms.Button();
            this.bttnAddQNT = new System.Windows.Forms.Button();
            this.bttnAddComment = new System.Windows.Forms.Button();
            this.flowPnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.bttnHotDrinks = new System.Windows.Forms.Button();
            this.bttnSoftDrinks = new System.Windows.Forms.Button();
            this.bttnAlcDrinks = new System.Windows.Forms.Button();
            this.bttnLunchMain = new System.Windows.Forms.Button();
            this.bttnSpecials = new System.Windows.Forms.Button();
            this.bttnBites = new System.Windows.Forms.Button();
            this.bttnStarters = new System.Windows.Forms.Button();
            this.bttnMain = new System.Windows.Forms.Button();
            this.bttnDesserts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(1066, 68);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(62, 25);
            this.lbltxt.TabIndex = 4;
            this.lbltxt.Text = "Table";
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.Location = new System.Drawing.Point(1161, 68);
            this.lblTableNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(27, 25);
            this.lblTableNr.TabIndex = 3;
            this.lblTableNr.Text = "...";
            // 
            // bttnLunch
            // 
            this.bttnLunch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnLunch.Location = new System.Drawing.Point(331, 27);
            this.bttnLunch.Margin = new System.Windows.Forms.Padding(4);
            this.bttnLunch.Name = "bttnLunch";
            this.bttnLunch.Size = new System.Drawing.Size(138, 145);
            this.bttnLunch.TabIndex = 0;
            this.bttnLunch.Text = "Lunch";
            this.bttnLunch.UseVisualStyleBackColor = false;
            this.bttnLunch.Click += new System.EventHandler(this.bttnLunch_Click);
            // 
            // bttnDiner
            // 
            this.bttnDiner.BackColor = System.Drawing.SystemColors.Info;
            this.bttnDiner.Location = new System.Drawing.Point(684, 27);
            this.bttnDiner.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDiner.Name = "bttnDiner";
            this.bttnDiner.Size = new System.Drawing.Size(138, 147);
            this.bttnDiner.TabIndex = 1;
            this.bttnDiner.Text = "Diner";
            this.bttnDiner.UseVisualStyleBackColor = false;
            this.bttnDiner.Click += new System.EventHandler(this.bttnDiner_Click);
            // 
            // bttnDrinks
            // 
            this.bttnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnDrinks.Location = new System.Drawing.Point(12, 27);
            this.bttnDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDrinks.Name = "bttnDrinks";
            this.bttnDrinks.Size = new System.Drawing.Size(138, 147);
            this.bttnDrinks.TabIndex = 2;
            this.bttnDrinks.Text = "Drinks";
            this.bttnDrinks.UseVisualStyleBackColor = false;
            this.bttnDrinks.Click += new System.EventHandler(this.bttnDrinks_Click);
            // 
            // listViewOrderOrder
            // 
            this.listViewOrderOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItem,
            this.orderItemQNT});
            this.listViewOrderOrder.HideSelection = false;
            this.listViewOrderOrder.Location = new System.Drawing.Point(1068, 119);
            this.listViewOrderOrder.Margin = new System.Windows.Forms.Padding(6);
            this.listViewOrderOrder.Name = "listViewOrderOrder";
            this.listViewOrderOrder.Size = new System.Drawing.Size(549, 906);
            this.listViewOrderOrder.TabIndex = 8;
            this.listViewOrderOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrderOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrderOrder_SelectedIndexChanged);
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
            // bttnSend
            // 
            this.bttnSend.BackColor = System.Drawing.Color.Red;
            this.bttnSend.Location = new System.Drawing.Point(1461, 1035);
            this.bttnSend.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(156, 188);
            this.bttnSend.TabIndex = 9;
            this.bttnSend.Text = "Send";
            this.bttnSend.UseVisualStyleBackColor = false;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // bttnRemoveItem
            // 
            this.bttnRemoveItem.BackColor = System.Drawing.Color.SeaShell;
            this.bttnRemoveItem.Location = new System.Drawing.Point(1268, 1035);
            this.bttnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.bttnRemoveItem.Name = "bttnRemoveItem";
            this.bttnRemoveItem.Size = new System.Drawing.Size(185, 90);
            this.bttnRemoveItem.TabIndex = 10;
            this.bttnRemoveItem.Text = "-";
            this.bttnRemoveItem.UseVisualStyleBackColor = false;
            this.bttnRemoveItem.Click += new System.EventHandler(this.bttnRemoveItem_Click);
            // 
            // bttnAddQNT
            // 
            this.bttnAddQNT.BackColor = System.Drawing.Color.SeaShell;
            this.bttnAddQNT.Location = new System.Drawing.Point(1068, 1035);
            this.bttnAddQNT.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAddQNT.Name = "bttnAddQNT";
            this.bttnAddQNT.Size = new System.Drawing.Size(192, 90);
            this.bttnAddQNT.TabIndex = 11;
            this.bttnAddQNT.Text = "+";
            this.bttnAddQNT.UseVisualStyleBackColor = false;
            this.bttnAddQNT.Click += new System.EventHandler(this.bttnAddQNT_Click);
            // 
            // bttnAddComment
            // 
            this.bttnAddComment.BackColor = System.Drawing.Color.SeaShell;
            this.bttnAddComment.Location = new System.Drawing.Point(1068, 1133);
            this.bttnAddComment.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAddComment.Name = "bttnAddComment";
            this.bttnAddComment.Size = new System.Drawing.Size(385, 90);
            this.bttnAddComment.TabIndex = 13;
            this.bttnAddComment.Text = "add comment";
            this.bttnAddComment.UseVisualStyleBackColor = false;
            this.bttnAddComment.Click += new System.EventHandler(this.bttnAddComment_Click);
            // 
            // flowPnlItems
            // 
            this.flowPnlItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowPnlItems.Location = new System.Drawing.Point(1, 200);
            this.flowPnlItems.Margin = new System.Windows.Forms.Padding(4);
            this.flowPnlItems.Name = "flowPnlItems";
            this.flowPnlItems.Size = new System.Drawing.Size(1057, 982);
            this.flowPnlItems.TabIndex = 15;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(1574, 44);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(27, 25);
            this.lblEmployeeName.TabIndex = 16;
            this.lblEmployeeName.Text = "...";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(1369, 9);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(67, 25);
            this.lblDrinks.TabIndex = 17;
            this.lblDrinks.Text = "Drinks";
            // 
            // bttnHotDrinks
            // 
            this.bttnHotDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnHotDrinks.Location = new System.Drawing.Point(154, 27);
            this.bttnHotDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnHotDrinks.Name = "bttnHotDrinks";
            this.bttnHotDrinks.Size = new System.Drawing.Size(99, 71);
            this.bttnHotDrinks.TabIndex = 20;
            this.bttnHotDrinks.Text = "Hot Drinks";
            this.bttnHotDrinks.UseVisualStyleBackColor = false;
            // 
            // bttnSoftDrinks
            // 
            this.bttnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnSoftDrinks.Location = new System.Drawing.Point(154, 103);
            this.bttnSoftDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSoftDrinks.Name = "bttnSoftDrinks";
            this.bttnSoftDrinks.Size = new System.Drawing.Size(99, 71);
            this.bttnSoftDrinks.TabIndex = 21;
            this.bttnSoftDrinks.Text = "Soft Drinks";
            this.bttnSoftDrinks.UseVisualStyleBackColor = false;
            // 
            // bttnAlcDrinks
            // 
            this.bttnAlcDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnAlcDrinks.Location = new System.Drawing.Point(261, 29);
            this.bttnAlcDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAlcDrinks.Name = "bttnAlcDrinks";
            this.bttnAlcDrinks.Size = new System.Drawing.Size(62, 142);
            this.bttnAlcDrinks.TabIndex = 22;
            this.bttnAlcDrinks.Text = "Beers/wines";
            this.bttnAlcDrinks.UseVisualStyleBackColor = false;
            // 
            // bttnLunchMain
            // 
            this.bttnLunchMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnLunchMain.Location = new System.Drawing.Point(477, 27);
            this.bttnLunchMain.Margin = new System.Windows.Forms.Padding(4);
            this.bttnLunchMain.Name = "bttnLunchMain";
            this.bttnLunchMain.Size = new System.Drawing.Size(99, 69);
            this.bttnLunchMain.TabIndex = 23;
            this.bttnLunchMain.Text = "Lunch Main";
            this.bttnLunchMain.UseVisualStyleBackColor = false;
            // 
            // bttnSpecials
            // 
            this.bttnSpecials.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnSpecials.Location = new System.Drawing.Point(477, 106);
            this.bttnSpecials.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSpecials.Name = "bttnSpecials";
            this.bttnSpecials.Size = new System.Drawing.Size(99, 66);
            this.bttnSpecials.TabIndex = 24;
            this.bttnSpecials.Text = "Specials";
            this.bttnSpecials.UseVisualStyleBackColor = false;
            // 
            // bttnBites
            // 
            this.bttnBites.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnBites.Location = new System.Drawing.Point(584, 28);
            this.bttnBites.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBites.Name = "bttnBites";
            this.bttnBites.Size = new System.Drawing.Size(94, 144);
            this.bttnBites.TabIndex = 25;
            this.bttnBites.Text = "Bites";
            this.bttnBites.UseVisualStyleBackColor = false;
            // 
            // bttnStarters
            // 
            this.bttnStarters.BackColor = System.Drawing.SystemColors.Info;
            this.bttnStarters.Location = new System.Drawing.Point(830, 26);
            this.bttnStarters.Margin = new System.Windows.Forms.Padding(4);
            this.bttnStarters.Name = "bttnStarters";
            this.bttnStarters.Size = new System.Drawing.Size(99, 69);
            this.bttnStarters.TabIndex = 26;
            this.bttnStarters.Text = "Starters";
            this.bttnStarters.UseVisualStyleBackColor = false;
            // 
            // bttnMain
            // 
            this.bttnMain.BackColor = System.Drawing.SystemColors.Info;
            this.bttnMain.Location = new System.Drawing.Point(830, 103);
            this.bttnMain.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMain.Name = "bttnMain";
            this.bttnMain.Size = new System.Drawing.Size(99, 69);
            this.bttnMain.TabIndex = 27;
            this.bttnMain.Text = "Main";
            this.bttnMain.UseVisualStyleBackColor = false;
            // 
            // bttnDesserts
            // 
            this.bttnDesserts.BackColor = System.Drawing.SystemColors.Info;
            this.bttnDesserts.Location = new System.Drawing.Point(937, 25);
            this.bttnDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDesserts.Name = "bttnDesserts";
            this.bttnDesserts.Size = new System.Drawing.Size(102, 147);
            this.bttnDesserts.TabIndex = 28;
            this.bttnDesserts.Text = "Desserts";
            this.bttnDesserts.UseVisualStyleBackColor = false;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1670, 1246);
            this.Controls.Add(this.bttnAlcDrinks);
            this.Controls.Add(this.bttnDesserts);
            this.Controls.Add(this.bttnMain);
            this.Controls.Add(this.bttnStarters);
            this.Controls.Add(this.bttnBites);
            this.Controls.Add(this.bttnSpecials);
            this.Controls.Add(this.bttnLunchMain);
            this.Controls.Add(this.bttnSoftDrinks);
            this.Controls.Add(this.bttnHotDrinks);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.bttnDiner);
            this.Controls.Add(this.bttnLunch);
            this.Controls.Add(this.bttnDrinks);
            this.Controls.Add(this.flowPnlItems);
            this.Controls.Add(this.bttnAddComment);
            this.Controls.Add(this.bttnAddQNT);
            this.Controls.Add(this.bttnRemoveItem);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.listViewOrderOrder);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lblTableNr);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblTableNr;
        private System.Windows.Forms.Button bttnLunch;
        private System.Windows.Forms.Button bttnDiner;
        private System.Windows.Forms.Button bttnDrinks;
        private System.Windows.Forms.ListView listViewOrderOrder;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.ColumnHeader orderItemQNT;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.Button bttnRemoveItem;
        private System.Windows.Forms.Button bttnAddQNT;
        private System.Windows.Forms.Button bttnAddComment;
        private System.Windows.Forms.FlowLayoutPanel flowPnlItems;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Button bttnHotDrinks;
        private System.Windows.Forms.Button bttnSoftDrinks;
        private System.Windows.Forms.Button bttnAlcDrinks;
        private System.Windows.Forms.Button bttnLunchMain;
        private System.Windows.Forms.Button bttnSpecials;
        private System.Windows.Forms.Button bttnBites;
        private System.Windows.Forms.Button bttnStarters;
        private System.Windows.Forms.Button bttnMain;
        private System.Windows.Forms.Button bttnDesserts;
    }
}