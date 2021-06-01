
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
            this.flowPnlcategories = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnLunch = new System.Windows.Forms.Button();
            this.bttnDiner = new System.Windows.Forms.Button();
            this.bttnDrinks = new System.Windows.Forms.Button();
            this.listViewOrderOrder = new System.Windows.Forms.ListView();
            this.orderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderItemQNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Location = new System.Drawing.Point(1146, 66);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(62, 25);
            this.lbltxt.TabIndex = 4;
            this.lbltxt.Text = "Table";
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.Location = new System.Drawing.Point(1242, 66);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(27, 25);
            this.lblTableNr.TabIndex = 3;
            this.lblTableNr.Text = "...";
            // 
            // flowPnlcategories
            // 
            this.flowPnlcategories.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowPnlcategories.Location = new System.Drawing.Point(187, 116);
            this.flowPnlcategories.Name = "flowPnlcategories";
            this.flowPnlcategories.Size = new System.Drawing.Size(945, 842);
            this.flowPnlcategories.TabIndex = 6;
            // 
            // bttnLunch
            // 
            this.bttnLunch.Location = new System.Drawing.Point(33, 116);
            this.bttnLunch.Name = "bttnLunch";
            this.bttnLunch.Size = new System.Drawing.Size(127, 104);
            this.bttnLunch.TabIndex = 0;
            this.bttnLunch.Text = "Lunch";
            this.bttnLunch.UseVisualStyleBackColor = true;
            this.bttnLunch.Click += new System.EventHandler(this.bttnLunch_Click);
            // 
            // bttnDiner
            // 
            this.bttnDiner.Location = new System.Drawing.Point(33, 226);
            this.bttnDiner.Name = "bttnDiner";
            this.bttnDiner.Size = new System.Drawing.Size(127, 104);
            this.bttnDiner.TabIndex = 1;
            this.bttnDiner.Text = "Diner";
            this.bttnDiner.UseVisualStyleBackColor = true;
            // 
            // bttnDrinks
            // 
            this.bttnDrinks.Location = new System.Drawing.Point(33, 336);
            this.bttnDrinks.Name = "bttnDrinks";
            this.bttnDrinks.Size = new System.Drawing.Size(127, 104);
            this.bttnDrinks.TabIndex = 2;
            this.bttnDrinks.Text = "Drinks";
            this.bttnDrinks.UseVisualStyleBackColor = true;
            // 
            // listViewOrderOrder
            // 
            this.listViewOrderOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItem,
            this.orderItemQNT});
            this.listViewOrderOrder.HideSelection = false;
            this.listViewOrderOrder.Location = new System.Drawing.Point(1151, 116);
            this.listViewOrderOrder.Margin = new System.Windows.Forms.Padding(6);
            this.listViewOrderOrder.Name = "listViewOrderOrder";
            this.listViewOrderOrder.Size = new System.Drawing.Size(418, 951);
            this.listViewOrderOrder.TabIndex = 8;
            this.listViewOrderOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrderOrder.View = System.Windows.Forms.View.Details;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1414, 1087);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 134);
            this.button4.TabIndex = 9;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1152, 1161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "remove item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1275, 1087);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1275, 1161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 60);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1151, 1087);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 60);
            this.button5.TabIndex = 13;
            this.button5.Text = "add comment";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1670, 1233);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bttnDrinks);
            this.Controls.Add(this.bttnDiner);
            this.Controls.Add(this.bttnLunch);
            this.Controls.Add(this.flowPnlcategories);
            this.Controls.Add(this.listViewOrderOrder);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.lblTableNr);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblTableNr;
        private System.Windows.Forms.FlowLayoutPanel flowPnlcategories;
        private System.Windows.Forms.Button bttnLunch;
        private System.Windows.Forms.Button bttnDiner;
        private System.Windows.Forms.Button bttnDrinks;
        private System.Windows.Forms.ListView listViewOrderOrder;
        private System.Windows.Forms.ColumnHeader orderItem;
        private System.Windows.Forms.ColumnHeader orderItemQNT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}