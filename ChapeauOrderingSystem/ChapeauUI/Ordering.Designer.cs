
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowPnlItems = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(625, 36);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(34, 13);
            this.lbltxt.TabIndex = 4;
            this.lbltxt.Text = "Table";
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.Location = new System.Drawing.Point(677, 36);
            this.lblTableNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(16, 13);
            this.lblTableNr.TabIndex = 3;
            this.lblTableNr.Text = "...";
            // 
            // bttnLunch
            // 
            this.bttnLunch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnLunch.Location = new System.Drawing.Point(15, 134);
            this.bttnLunch.Margin = new System.Windows.Forms.Padding(2);
            this.bttnLunch.Name = "bttnLunch";
            this.bttnLunch.Size = new System.Drawing.Size(90, 68);
            this.bttnLunch.TabIndex = 0;
            this.bttnLunch.Text = "Lunch";
            this.bttnLunch.UseVisualStyleBackColor = false;
            this.bttnLunch.Click += new System.EventHandler(this.bttnLunch_Click);
            // 
            // bttnDiner
            // 
            this.bttnDiner.BackColor = System.Drawing.SystemColors.Info;
            this.bttnDiner.Location = new System.Drawing.Point(15, 206);
            this.bttnDiner.Margin = new System.Windows.Forms.Padding(2);
            this.bttnDiner.Name = "bttnDiner";
            this.bttnDiner.Size = new System.Drawing.Size(90, 68);
            this.bttnDiner.TabIndex = 1;
            this.bttnDiner.Text = "Diner";
            this.bttnDiner.UseVisualStyleBackColor = false;
            this.bttnDiner.Click += new System.EventHandler(this.bttnDiner_Click);
            // 
            // bttnDrinks
            // 
            this.bttnDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttnDrinks.Location = new System.Drawing.Point(15, 63);
            this.bttnDrinks.Margin = new System.Windows.Forms.Padding(2);
            this.bttnDrinks.Name = "bttnDrinks";
            this.bttnDrinks.Size = new System.Drawing.Size(90, 68);
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
            this.listViewOrderOrder.Location = new System.Drawing.Point(628, 63);
            this.listViewOrderOrder.Name = "listViewOrderOrder";
            this.listViewOrderOrder.Size = new System.Drawing.Size(230, 360);
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
            this.bttnSend.Location = new System.Drawing.Point(771, 435);
            this.bttnSend.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(85, 102);
            this.bttnSend.TabIndex = 9;
            this.bttnSend.Text = "Send";
            this.bttnSend.UseVisualStyleBackColor = false;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(628, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "remove item";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Location = new System.Drawing.Point(695, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.Location = new System.Drawing.Point(695, 488);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 49);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SeaShell;
            this.button5.Location = new System.Drawing.Point(628, 435);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 49);
            this.button5.TabIndex = 13;
            this.button5.Text = "add comment";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 505);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 68);
            this.button6.TabIndex = 14;
            this.button6.Text = "Desserts";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // flowPnlItems
            // 
            this.flowPnlItems.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowPnlItems.Location = new System.Drawing.Point(116, 57);
            this.flowPnlItems.Margin = new System.Windows.Forms.Padding(2);
            this.flowPnlItems.Name = "flowPnlItems";
            this.flowPnlItems.Size = new System.Drawing.Size(507, 480);
            this.flowPnlItems.TabIndex = 15;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(911, 668);
            this.Controls.Add(this.bttnDiner);
            this.Controls.Add(this.bttnLunch);
            this.Controls.Add(this.bttnDrinks);
            this.Controls.Add(this.flowPnlItems);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.listViewOrderOrder);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lblTableNr);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel flowPnlItems;
    }
}