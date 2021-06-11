
namespace ChapeauUI
{
    partial class BarKitchenView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOrder3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOrderId3 = new System.Windows.Forms.Label();
            this.lblOrderStartTime3 = new System.Windows.Forms.Label();
            this.lblTableNumber3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlOrder2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderId2 = new System.Windows.Forms.Label();
            this.lblOrderStartTime2 = new System.Windows.Forms.Label();
            this.lblTableNumber2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDisplayingThis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeOrderState = new System.Windows.Forms.Button();
            this.btnUndoOrder1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlOrder1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderID1 = new System.Windows.Forms.Label();
            this.lblOrderStartTime1 = new System.Windows.Forms.Label();
            this.lblTablenumber1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstbDesserts1 = new System.Windows.Forms.ListBox();
            this.lstbMains1 = new System.Windows.Forms.ListBox();
            this.lstbStarters1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAllOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRunningOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinishedOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlOrder3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlOrder2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlOrder1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlOrder3);
            this.panel1.Controls.Add(this.pnlOrder2);
            this.panel1.Controls.Add(this.lblDisplayingThis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnChangeOrderState);
            this.panel1.Controls.Add(this.btnUndoOrder1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pnlOrder1);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 610);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlOrder3
            // 
            this.pnlOrder3.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOrder3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder3.Controls.Add(this.label7);
            this.pnlOrder3.Controls.Add(this.lblOrderId3);
            this.pnlOrder3.Controls.Add(this.lblOrderStartTime3);
            this.pnlOrder3.Controls.Add(this.lblTableNumber3);
            this.pnlOrder3.Controls.Add(this.panel6);
            this.pnlOrder3.Location = new System.Drawing.Point(678, 73);
            this.pnlOrder3.Name = "pnlOrder3";
            this.pnlOrder3.Size = new System.Drawing.Size(200, 370);
            this.pnlOrder3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "OrderID: ";
            // 
            // lblOrderId3
            // 
            this.lblOrderId3.AutoSize = true;
            this.lblOrderId3.Location = new System.Drawing.Point(58, 35);
            this.lblOrderId3.Name = "lblOrderId3";
            this.lblOrderId3.Size = new System.Drawing.Size(18, 13);
            this.lblOrderId3.TabIndex = 2;
            this.lblOrderId3.Text = "ID";
            // 
            // lblOrderStartTime3
            // 
            this.lblOrderStartTime3.AutoSize = true;
            this.lblOrderStartTime3.ForeColor = System.Drawing.Color.White;
            this.lblOrderStartTime3.Location = new System.Drawing.Point(137, 0);
            this.lblOrderStartTime3.Name = "lblOrderStartTime3";
            this.lblOrderStartTime3.Size = new System.Drawing.Size(30, 13);
            this.lblOrderStartTime3.TabIndex = 1;
            this.lblOrderStartTime3.Text = "Time";
            // 
            // lblTableNumber3
            // 
            this.lblTableNumber3.AutoSize = true;
            this.lblTableNumber3.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber3.Location = new System.Drawing.Point(10, 0);
            this.lblTableNumber3.Name = "lblTableNumber3";
            this.lblTableNumber3.Size = new System.Drawing.Size(46, 13);
            this.lblTableNumber3.TabIndex = 0;
            this.lblTableNumber3.Text = "Table ...";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 314);
            this.panel6.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Desserts";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Mains";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(13, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Starters";
            // 
            // pnlOrder2
            // 
            this.pnlOrder2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOrder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder2.Controls.Add(this.label6);
            this.pnlOrder2.Controls.Add(this.lblOrderId2);
            this.pnlOrder2.Controls.Add(this.lblOrderStartTime2);
            this.pnlOrder2.Controls.Add(this.lblTableNumber2);
            this.pnlOrder2.Controls.Add(this.panel5);
            this.pnlOrder2.Location = new System.Drawing.Point(358, 73);
            this.pnlOrder2.Name = "pnlOrder2";
            this.pnlOrder2.Size = new System.Drawing.Size(200, 370);
            this.pnlOrder2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "OrderID: ";
            // 
            // lblOrderId2
            // 
            this.lblOrderId2.AutoSize = true;
            this.lblOrderId2.Location = new System.Drawing.Point(64, 35);
            this.lblOrderId2.Name = "lblOrderId2";
            this.lblOrderId2.Size = new System.Drawing.Size(18, 13);
            this.lblOrderId2.TabIndex = 2;
            this.lblOrderId2.Text = "ID";
            // 
            // lblOrderStartTime2
            // 
            this.lblOrderStartTime2.AutoSize = true;
            this.lblOrderStartTime2.ForeColor = System.Drawing.Color.White;
            this.lblOrderStartTime2.Location = new System.Drawing.Point(137, 0);
            this.lblOrderStartTime2.Name = "lblOrderStartTime2";
            this.lblOrderStartTime2.Size = new System.Drawing.Size(30, 13);
            this.lblOrderStartTime2.TabIndex = 1;
            this.lblOrderStartTime2.Text = "Time";
            // 
            // lblTableNumber2
            // 
            this.lblTableNumber2.AutoSize = true;
            this.lblTableNumber2.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber2.Location = new System.Drawing.Point(10, 0);
            this.lblTableNumber2.Name = "lblTableNumber2";
            this.lblTableNumber2.Size = new System.Drawing.Size(46, 13);
            this.lblTableNumber2.TabIndex = 0;
            this.lblTableNumber2.Text = "Table ...";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 314);
            this.panel5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Desserts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mains";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Starters";
            // 
            // lblDisplayingThis
            // 
            this.lblDisplayingThis.AutoSize = true;
            this.lblDisplayingThis.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayingThis.Location = new System.Drawing.Point(142, 11);
            this.lblDisplayingThis.Name = "lblDisplayingThis";
            this.lblDisplayingThis.Size = new System.Drawing.Size(85, 13);
            this.lblDisplayingThis.TabIndex = 5;
            this.lblDisplayingThis.Text = "All Active Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currently displaying";
            // 
            // btnChangeOrderState
            // 
            this.btnChangeOrderState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeOrderState.ForeColor = System.Drawing.Color.Black;
            this.btnChangeOrderState.Location = new System.Drawing.Point(164, 459);
            this.btnChangeOrderState.Name = "btnChangeOrderState";
            this.btnChangeOrderState.Size = new System.Drawing.Size(75, 48);
            this.btnChangeOrderState.TabIndex = 3;
            this.btnChangeOrderState.Text = "Prepare";
            this.btnChangeOrderState.UseVisualStyleBackColor = false;
            this.btnChangeOrderState.Click += new System.EventHandler(this.btnChangeOrderState_Click);
            // 
            // btnUndoOrder1
            // 
            this.btnUndoOrder1.ForeColor = System.Drawing.Color.Black;
            this.btnUndoOrder1.Location = new System.Drawing.Point(39, 459);
            this.btnUndoOrder1.Name = "btnUndoOrder1";
            this.btnUndoOrder1.Size = new System.Drawing.Size(75, 48);
            this.btnUndoOrder1.TabIndex = 2;
            this.btnUndoOrder1.Text = "Undo";
            this.btnUndoOrder1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(824, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 49);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlOrder1
            // 
            this.pnlOrder1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder1.Controls.Add(this.label2);
            this.pnlOrder1.Controls.Add(this.lblOrderID1);
            this.pnlOrder1.Controls.Add(this.lblOrderStartTime1);
            this.pnlOrder1.Controls.Add(this.lblTablenumber1);
            this.pnlOrder1.Controls.Add(this.panel3);
            this.pnlOrder1.Location = new System.Drawing.Point(39, 73);
            this.pnlOrder1.Name = "pnlOrder1";
            this.pnlOrder1.Size = new System.Drawing.Size(200, 370);
            this.pnlOrder1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OrderID: ";
            // 
            // lblOrderID1
            // 
            this.lblOrderID1.AutoSize = true;
            this.lblOrderID1.Location = new System.Drawing.Point(58, 35);
            this.lblOrderID1.Name = "lblOrderID1";
            this.lblOrderID1.Size = new System.Drawing.Size(18, 13);
            this.lblOrderID1.TabIndex = 2;
            this.lblOrderID1.Text = "ID";
            // 
            // lblOrderStartTime1
            // 
            this.lblOrderStartTime1.AutoSize = true;
            this.lblOrderStartTime1.ForeColor = System.Drawing.Color.White;
            this.lblOrderStartTime1.Location = new System.Drawing.Point(137, 0);
            this.lblOrderStartTime1.Name = "lblOrderStartTime1";
            this.lblOrderStartTime1.Size = new System.Drawing.Size(30, 13);
            this.lblOrderStartTime1.TabIndex = 1;
            this.lblOrderStartTime1.Text = "Time";
            // 
            // lblTablenumber1
            // 
            this.lblTablenumber1.AutoSize = true;
            this.lblTablenumber1.ForeColor = System.Drawing.Color.White;
            this.lblTablenumber1.Location = new System.Drawing.Point(10, 0);
            this.lblTablenumber1.Name = "lblTablenumber1";
            this.lblTablenumber1.Size = new System.Drawing.Size(46, 13);
            this.lblTablenumber1.TabIndex = 0;
            this.lblTablenumber1.Text = "Table ...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lstbDesserts1);
            this.panel3.Controls.Add(this.lstbMains1);
            this.panel3.Controls.Add(this.lstbStarters1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 314);
            this.panel3.TabIndex = 1;
            // 
            // lstbDesserts1
            // 
            this.lstbDesserts1.FormattingEnabled = true;
            this.lstbDesserts1.Location = new System.Drawing.Point(0, 234);
            this.lstbDesserts1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbDesserts1.Name = "lstbDesserts1";
            this.lstbDesserts1.Size = new System.Drawing.Size(200, 82);
            this.lstbDesserts1.TabIndex = 10;
            // 
            // lstbMains1
            // 
            this.lstbMains1.FormattingEnabled = true;
            this.lstbMains1.Location = new System.Drawing.Point(0, 127);
            this.lstbMains1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbMains1.Name = "lstbMains1";
            this.lstbMains1.Size = new System.Drawing.Size(200, 82);
            this.lstbMains1.TabIndex = 9;
            // 
            // lstbStarters1
            // 
            this.lstbStarters1.FormattingEnabled = true;
            this.lstbStarters1.Location = new System.Drawing.Point(0, 25);
            this.lstbStarters1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbStarters1.Name = "lstbStarters1";
            this.lstbStarters1.Size = new System.Drawing.Size(200, 82);
            this.lstbStarters1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desserts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Starters";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllOrders,
            this.tsmiRunningOrders,
            this.tsmiFinishedOrders});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(912, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAllOrders
            // 
            this.tsmiAllOrders.Name = "tsmiAllOrders";
            this.tsmiAllOrders.Padding = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.tsmiAllOrders.Size = new System.Drawing.Size(399, 29);
            this.tsmiAllOrders.Text = "All Active Orders";
            this.tsmiAllOrders.Click += new System.EventHandler(this.tsmiAllOrders_Click);
            // 
            // tsmiRunningOrders
            // 
            this.tsmiRunningOrders.Name = "tsmiRunningOrders";
            this.tsmiRunningOrders.Size = new System.Drawing.Size(100, 29);
            this.tsmiRunningOrders.Text = "Running orders";
            this.tsmiRunningOrders.Click += new System.EventHandler(this.tsmiRunningOrders_Click);
            // 
            // tsmiFinishedOrders
            // 
            this.tsmiFinishedOrders.Name = "tsmiFinishedOrders";
            this.tsmiFinishedOrders.Padding = new System.Windows.Forms.Padding(300, 0, 4, 0);
            this.tsmiFinishedOrders.Size = new System.Drawing.Size(397, 29);
            this.tsmiFinishedOrders.Text = "Finished Orders";
            this.tsmiFinishedOrders.Click += new System.EventHandler(this.tsmiFinishedOrders_Click);
            // 
            // BarKitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(911, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarKitchenView";
            this.Text = "BarKitchenView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOrder3.ResumeLayout(false);
            this.pnlOrder3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlOrder2.ResumeLayout(false);
            this.pnlOrder2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlOrder1.ResumeLayout(false);
            this.pnlOrder1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOrder1;
        private System.Windows.Forms.Label lblOrderStartTime1;
        private System.Windows.Forms.Label lblTablenumber1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllOrders;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunningOrders;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinishedOrders;
        private System.Windows.Forms.Button btnChangeOrderState;
        private System.Windows.Forms.Button btnUndoOrder1;
        private System.Windows.Forms.Label lblOrderID1;
        private System.Windows.Forms.Label lblDisplayingThis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOrder2;
        private System.Windows.Forms.Label lblOrderId2;
        private System.Windows.Forms.Label lblOrderStartTime2;
        private System.Windows.Forms.Label lblTableNumber2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOrder3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOrderId3;
        private System.Windows.Forms.Label lblOrderStartTime3;
        private System.Windows.Forms.Label lblTableNumber3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstbDesserts1;
        private System.Windows.Forms.ListBox lstbMains1;
        private System.Windows.Forms.ListBox lstbStarters1;
    }
}