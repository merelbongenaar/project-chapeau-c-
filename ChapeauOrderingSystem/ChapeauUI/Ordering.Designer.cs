
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
            this.bttnMenuCategory = new System.Windows.Forms.Button();
            this.listViewOrderOrder = new System.Windows.Forms.ListView();
            this.orderItemQNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItemComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bttnSend = new System.Windows.Forms.Button();
            this.bttnRemoveItem = new System.Windows.Forms.Button();
            this.bttnAddQNT = new System.Windows.Forms.Button();
            this.bttnAddComment = new System.Windows.Forms.Button();
            this.flowPnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.bttnMenuSubCatgory = new System.Windows.Forms.Button();
            this.bttnSoftDrinks = new System.Windows.Forms.Button();
            this.bttnAlcDrinks = new System.Windows.Forms.Button();
            this.bttnLunchMain = new System.Windows.Forms.Button();
            this.bttnSpecials = new System.Windows.Forms.Button();
            this.bttnBites = new System.Windows.Forms.Button();
            this.bttnStarters = new System.Windows.Forms.Button();
            this.bttnMain = new System.Windows.Forms.Button();
            this.bttnDesserts = new System.Windows.Forms.Button();
            this.bttnWines = new System.Windows.Forms.Button();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.lbltxt.Location = new System.Drawing.Point(20, 26);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(63, 34);
            this.lbltxt.TabIndex = 4;
            this.lbltxt.Text = "Table";
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.lblTableNr.Location = new System.Drawing.Point(114, 26);
            this.lblTableNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(30, 34);
            this.lblTableNr.TabIndex = 3;
            this.lblTableNr.Text = "...";
            // 
            // bttnLunch
            // 
            this.bttnLunch.BackColor = System.Drawing.SystemColors.Info;
            this.bttnLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnLunch.Location = new System.Drawing.Point(395, 59);
            this.bttnLunch.Margin = new System.Windows.Forms.Padding(4);
            this.bttnLunch.Name = "bttnLunch";
            this.bttnLunch.Size = new System.Drawing.Size(344, 92);
            this.bttnLunch.TabIndex = 0;
            this.bttnLunch.Tag = "1";
            this.bttnLunch.Text = "Lunch";
            this.bttnLunch.UseVisualStyleBackColor = false;
            this.bttnLunch.Click += new System.EventHandler(this.bttnMenuCategory_Click);
            // 
            // bttnDiner
            // 
            this.bttnDiner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttnDiner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnDiner.Location = new System.Drawing.Point(773, 56);
            this.bttnDiner.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDiner.Name = "bttnDiner";
            this.bttnDiner.Size = new System.Drawing.Size(344, 94);
            this.bttnDiner.TabIndex = 1;
            this.bttnDiner.Tag = "2";
            this.bttnDiner.Text = "Diner";
            this.bttnDiner.UseVisualStyleBackColor = false;
            this.bttnDiner.Click += new System.EventHandler(this.bttnMenuCategory_Click);
            // 
            // bttnMenuCategory
            // 
            this.bttnMenuCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnMenuCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnMenuCategory.Location = new System.Drawing.Point(13, 59);
            this.bttnMenuCategory.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMenuCategory.Name = "bttnMenuCategory";
            this.bttnMenuCategory.Size = new System.Drawing.Size(344, 94);
            this.bttnMenuCategory.TabIndex = 2;
            this.bttnMenuCategory.Tag = "3";
            this.bttnMenuCategory.Text = "Drinks";
            this.bttnMenuCategory.UseVisualStyleBackColor = false;
            this.bttnMenuCategory.Click += new System.EventHandler(this.bttnMenuCategory_Click);
            // 
            // listViewOrderOrder
            // 
            this.listViewOrderOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItemQNT,
            this.orderItem,
            this.orderItemComment});
            this.listViewOrderOrder.HideSelection = false;
            this.listViewOrderOrder.Location = new System.Drawing.Point(25, 66);
            this.listViewOrderOrder.Margin = new System.Windows.Forms.Padding(6);
            this.listViewOrderOrder.Name = "listViewOrderOrder";
            this.listViewOrderOrder.Size = new System.Drawing.Size(438, 884);
            this.listViewOrderOrder.TabIndex = 8;
            this.listViewOrderOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrderOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrderOrder_SelectedIndexChanged);
            // 
            // orderItemQNT
            // 
            this.orderItemQNT.Text = "qnt";
            this.orderItemQNT.Width = 40;
            // 
            // orderItem
            // 
            this.orderItem.Text = "Item";
            this.orderItem.Width = 150;
            // 
            // orderItemComment
            // 
            this.orderItemComment.Text = "comment";
            this.orderItemComment.Width = 197;
            // 
            // bttnSend
            // 
            this.bttnSend.BackColor = System.Drawing.Color.Red;
            this.bttnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnSend.Location = new System.Drawing.Point(331, 960);
            this.bttnSend.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(132, 179);
            this.bttnSend.TabIndex = 9;
            this.bttnSend.Text = "Send";
            this.bttnSend.UseVisualStyleBackColor = false;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // bttnRemoveItem
            // 
            this.bttnRemoveItem.BackColor = System.Drawing.Color.SeaShell;
            this.bttnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnRemoveItem.Location = new System.Drawing.Point(178, 960);
            this.bttnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.bttnRemoveItem.Name = "bttnRemoveItem";
            this.bttnRemoveItem.Size = new System.Drawing.Size(145, 81);
            this.bttnRemoveItem.TabIndex = 10;
            this.bttnRemoveItem.Text = "-";
            this.bttnRemoveItem.UseVisualStyleBackColor = false;
            this.bttnRemoveItem.Click += new System.EventHandler(this.bttnRemoveItem_Click);
            // 
            // bttnAddQNT
            // 
            this.bttnAddQNT.BackColor = System.Drawing.Color.SeaShell;
            this.bttnAddQNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnAddQNT.Location = new System.Drawing.Point(25, 960);
            this.bttnAddQNT.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAddQNT.Name = "bttnAddQNT";
            this.bttnAddQNT.Size = new System.Drawing.Size(145, 81);
            this.bttnAddQNT.TabIndex = 11;
            this.bttnAddQNT.Text = "+";
            this.bttnAddQNT.UseVisualStyleBackColor = false;
            this.bttnAddQNT.Click += new System.EventHandler(this.bttnAddQNT_Click);
            // 
            // bttnAddComment
            // 
            this.bttnAddComment.BackColor = System.Drawing.Color.SeaShell;
            this.bttnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bttnAddComment.Location = new System.Drawing.Point(26, 1049);
            this.bttnAddComment.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAddComment.Name = "bttnAddComment";
            this.bttnAddComment.Size = new System.Drawing.Size(297, 90);
            this.bttnAddComment.TabIndex = 13;
            this.bttnAddComment.Text = "add comment";
            this.bttnAddComment.UseVisualStyleBackColor = false;
            this.bttnAddComment.Click += new System.EventHandler(this.bttnAddComment_Click);
            // 
            // flowPnlItems
            // 
            this.flowPnlItems.BackColor = System.Drawing.Color.White;
            this.flowPnlItems.Location = new System.Drawing.Point(13, 321);
            this.flowPnlItems.Margin = new System.Windows.Forms.Padding(4);
            this.flowPnlItems.Name = "flowPnlItems";
            this.flowPnlItems.Size = new System.Drawing.Size(1104, 857);
            this.flowPnlItems.TabIndex = 15;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.lblEmployeeName.Location = new System.Drawing.Point(13, 9);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(30, 34);
            this.lblEmployeeName.TabIndex = 16;
            this.lblEmployeeName.Text = "...";
            // 
            // bttnMenuSubCatgory
            // 
            this.bttnMenuSubCatgory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnMenuSubCatgory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnMenuSubCatgory.Location = new System.Drawing.Point(13, 234);
            this.bttnMenuSubCatgory.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMenuSubCatgory.Name = "bttnMenuSubCatgory";
            this.bttnMenuSubCatgory.Size = new System.Drawing.Size(162, 69);
            this.bttnMenuSubCatgory.TabIndex = 20;
            this.bttnMenuSubCatgory.Tag = "8";
            this.bttnMenuSubCatgory.Text = "Hot Drinks";
            this.bttnMenuSubCatgory.UseVisualStyleBackColor = false;
            this.bttnMenuSubCatgory.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnSoftDrinks
            // 
            this.bttnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnSoftDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnSoftDrinks.Location = new System.Drawing.Point(13, 162);
            this.bttnSoftDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSoftDrinks.Name = "bttnSoftDrinks";
            this.bttnSoftDrinks.Size = new System.Drawing.Size(162, 66);
            this.bttnSoftDrinks.TabIndex = 21;
            this.bttnSoftDrinks.Tag = "7";
            this.bttnSoftDrinks.Text = "Soft Drinks";
            this.bttnSoftDrinks.UseVisualStyleBackColor = false;
            this.bttnSoftDrinks.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnAlcDrinks
            // 
            this.bttnAlcDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnAlcDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnAlcDrinks.Location = new System.Drawing.Point(183, 234);
            this.bttnAlcDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAlcDrinks.Name = "bttnAlcDrinks";
            this.bttnAlcDrinks.Size = new System.Drawing.Size(174, 69);
            this.bttnAlcDrinks.TabIndex = 22;
            this.bttnAlcDrinks.Tag = "9";
            this.bttnAlcDrinks.Text = "Beers";
            this.bttnAlcDrinks.UseVisualStyleBackColor = false;
            this.bttnAlcDrinks.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnLunchMain
            // 
            this.bttnLunchMain.BackColor = System.Drawing.SystemColors.Info;
            this.bttnLunchMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnLunchMain.Location = new System.Drawing.Point(395, 159);
            this.bttnLunchMain.Margin = new System.Windows.Forms.Padding(4);
            this.bttnLunchMain.Name = "bttnLunchMain";
            this.bttnLunchMain.Size = new System.Drawing.Size(162, 69);
            this.bttnLunchMain.TabIndex = 23;
            this.bttnLunchMain.Tag = "1";
            this.bttnLunchMain.Text = "LunchMain";
            this.bttnLunchMain.UseVisualStyleBackColor = false;
            this.bttnLunchMain.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnSpecials
            // 
            this.bttnSpecials.BackColor = System.Drawing.SystemColors.Info;
            this.bttnSpecials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnSpecials.Location = new System.Drawing.Point(395, 233);
            this.bttnSpecials.Margin = new System.Windows.Forms.Padding(4);
            this.bttnSpecials.Name = "bttnSpecials";
            this.bttnSpecials.Size = new System.Drawing.Size(162, 69);
            this.bttnSpecials.TabIndex = 24;
            this.bttnSpecials.Tag = "2";
            this.bttnSpecials.Text = "Specials";
            this.bttnSpecials.UseVisualStyleBackColor = false;
            this.bttnSpecials.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnBites
            // 
            this.bttnBites.BackColor = System.Drawing.SystemColors.Info;
            this.bttnBites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnBites.Location = new System.Drawing.Point(565, 159);
            this.bttnBites.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBites.Name = "bttnBites";
            this.bttnBites.Size = new System.Drawing.Size(174, 144);
            this.bttnBites.TabIndex = 25;
            this.bttnBites.Tag = "3";
            this.bttnBites.Text = "Bites";
            this.bttnBites.UseVisualStyleBackColor = false;
            this.bttnBites.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnStarters
            // 
            this.bttnStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttnStarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnStarters.Location = new System.Drawing.Point(773, 157);
            this.bttnStarters.Margin = new System.Windows.Forms.Padding(4);
            this.bttnStarters.Name = "bttnStarters";
            this.bttnStarters.Size = new System.Drawing.Size(162, 69);
            this.bttnStarters.TabIndex = 26;
            this.bttnStarters.Tag = "4";
            this.bttnStarters.Text = "Starters";
            this.bttnStarters.UseVisualStyleBackColor = false;
            this.bttnStarters.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnMain
            // 
            this.bttnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnMain.Location = new System.Drawing.Point(773, 231);
            this.bttnMain.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMain.Name = "bttnMain";
            this.bttnMain.Size = new System.Drawing.Size(162, 71);
            this.bttnMain.TabIndex = 27;
            this.bttnMain.Tag = "5";
            this.bttnMain.Text = "Main";
            this.bttnMain.UseVisualStyleBackColor = false;
            this.bttnMain.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnDesserts
            // 
            this.bttnDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttnDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnDesserts.Location = new System.Drawing.Point(943, 157);
            this.bttnDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.bttnDesserts.Name = "bttnDesserts";
            this.bttnDesserts.Size = new System.Drawing.Size(174, 145);
            this.bttnDesserts.TabIndex = 28;
            this.bttnDesserts.Tag = "6";
            this.bttnDesserts.Text = "Desserts";
            this.bttnDesserts.UseVisualStyleBackColor = false;
            this.bttnDesserts.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // bttnWines
            // 
            this.bttnWines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnWines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttnWines.Location = new System.Drawing.Point(183, 161);
            this.bttnWines.Margin = new System.Windows.Forms.Padding(4);
            this.bttnWines.Name = "bttnWines";
            this.bttnWines.Size = new System.Drawing.Size(174, 66);
            this.bttnWines.TabIndex = 29;
            this.bttnWines.Tag = "10";
            this.bttnWines.Text = "Wines";
            this.bttnWines.UseVisualStyleBackColor = false;
            this.bttnWines.Click += new System.EventHandler(this.bttnMenuSubCatgory_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.LightPink;
            this.pnlOrder.Controls.Add(this.bttnAddQNT);
            this.pnlOrder.Controls.Add(this.bttnAddComment);
            this.pnlOrder.Controls.Add(this.bttnSend);
            this.pnlOrder.Controls.Add(this.bttnRemoveItem);
            this.pnlOrder.Controls.Add(this.listViewOrderOrder);
            this.pnlOrder.Controls.Add(this.lblTableNr);
            this.pnlOrder.Controls.Add(this.lbltxt);
            this.pnlOrder.Location = new System.Drawing.Point(1145, 33);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(6);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(495, 1145);
            this.pnlOrder.TabIndex = 30;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1670, 1246);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.bttnWines);
            this.Controls.Add(this.bttnAlcDrinks);
            this.Controls.Add(this.bttnDesserts);
            this.Controls.Add(this.bttnMain);
            this.Controls.Add(this.bttnStarters);
            this.Controls.Add(this.bttnBites);
            this.Controls.Add(this.bttnSpecials);
            this.Controls.Add(this.bttnLunchMain);
            this.Controls.Add(this.bttnSoftDrinks);
            this.Controls.Add(this.bttnMenuSubCatgory);
            this.Controls.Add(this.bttnDiner);
            this.Controls.Add(this.bttnLunch);
            this.Controls.Add(this.bttnMenuCategory);
            this.Controls.Add(this.flowPnlItems);
            this.Controls.Add(this.pnlOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblTableNr;
        private System.Windows.Forms.Button bttnLunch;
        private System.Windows.Forms.Button bttnDiner;
        private System.Windows.Forms.Button bttnMenuCategory;
        private System.Windows.Forms.ListView listViewOrderOrder;
        private System.Windows.Forms.ColumnHeader orderItemComment;
        private System.Windows.Forms.ColumnHeader orderItemQNT;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.Button bttnRemoveItem;
        private System.Windows.Forms.Button bttnAddQNT;
        private System.Windows.Forms.Button bttnAddComment;
        private System.Windows.Forms.FlowLayoutPanel flowPnlItems;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button bttnMenuSubCatgory;
        private System.Windows.Forms.Button bttnSoftDrinks;
        private System.Windows.Forms.Button bttnAlcDrinks;
        private System.Windows.Forms.Button bttnLunchMain;
        private System.Windows.Forms.Button bttnSpecials;
        private System.Windows.Forms.Button bttnBites;
        private System.Windows.Forms.Button bttnStarters;
        private System.Windows.Forms.Button bttnMain;
        private System.Windows.Forms.Button bttnDesserts;
        private System.Windows.Forms.Button bttnWines;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.Panel pnlOrder;
    }
}