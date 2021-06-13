
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
            this.lblDisplayingThis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFinishedOrders = new System.Windows.Forms.Panel();
            this.lstFinishedOrders = new System.Windows.Forms.ListView();
            this.order_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.table_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.end_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ordered_items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeOrderState2 = new System.Windows.Forms.Button();
            this.btnUndoOrder2 = new System.Windows.Forms.Button();
            this.pnlOrder2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderId2 = new System.Windows.Forms.Label();
            this.lblOrderStartTime2 = new System.Windows.Forms.Label();
            this.lblTableNumber2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lstbDrinks2 = new System.Windows.Forms.ListBox();
            this.lstbMains2 = new System.Windows.Forms.ListBox();
            this.lstbDesserts2 = new System.Windows.Forms.ListBox();
            this.lstbStarters2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeOrderState = new System.Windows.Forms.Button();
            this.btnUndoOrder1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlOrder1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderID1 = new System.Windows.Forms.Label();
            this.lblOrderStartTime1 = new System.Windows.Forms.Label();
            this.lblTablenumber1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lstbDrinks1 = new System.Windows.Forms.ListBox();
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
            this.lblEmployeeID1 = new System.Windows.Forms.Label();
            this.lblEmployeeID2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlFinishedOrders.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblDisplayingThis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlFinishedOrders);
            this.panel1.Controls.Add(this.btnChangeOrderState2);
            this.panel1.Controls.Add(this.btnUndoOrder2);
            this.panel1.Controls.Add(this.pnlOrder2);
            this.panel1.Controls.Add(this.btnChangeOrderState);
            this.panel1.Controls.Add(this.btnUndoOrder1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pnlOrder1);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 751);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDisplayingThis
            // 
            this.lblDisplayingThis.AutoSize = true;
            this.lblDisplayingThis.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayingThis.Location = new System.Drawing.Point(189, 14);
            this.lblDisplayingThis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayingThis.Name = "lblDisplayingThis";
            this.lblDisplayingThis.Size = new System.Drawing.Size(113, 17);
            this.lblDisplayingThis.TabIndex = 5;
            this.lblDisplayingThis.Text = "All Active Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Currently displaying";
            // 
            // pnlFinishedOrders
            // 
            this.pnlFinishedOrders.BackColor = System.Drawing.Color.White;
            this.pnlFinishedOrders.Controls.Add(this.lstFinishedOrders);
            this.pnlFinishedOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlFinishedOrders.Name = "pnlFinishedOrders";
            this.pnlFinishedOrders.Size = new System.Drawing.Size(1216, 748);
            this.pnlFinishedOrders.TabIndex = 9;
            // 
            // lstFinishedOrders
            // 
            this.lstFinishedOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_id,
            this.table_number,
            this.start_time,
            this.end_time,
            this.employee_id,
            this.ordered_items});
            this.lstFinishedOrders.HideSelection = false;
            this.lstFinishedOrders.Location = new System.Drawing.Point(116, 90);
            this.lstFinishedOrders.Name = "lstFinishedOrders";
            this.lstFinishedOrders.Size = new System.Drawing.Size(977, 614);
            this.lstFinishedOrders.TabIndex = 0;
            this.lstFinishedOrders.UseCompatibleStateImageBehavior = false;
            this.lstFinishedOrders.View = System.Windows.Forms.View.Details;
            // 
            // order_id
            // 
            this.order_id.Text = "OrderID";
            // 
            // table_number
            // 
            this.table_number.Text = "Table number";
            this.table_number.Width = 96;
            // 
            // start_time
            // 
            this.start_time.Text = "Start Time";
            this.start_time.Width = 73;
            // 
            // end_time
            // 
            this.end_time.Text = "End Time";
            this.end_time.Width = 70;
            // 
            // employee_id
            // 
            this.employee_id.Text = "Employee ID";
            this.employee_id.Width = 90;
            // 
            // ordered_items
            // 
            this.ordered_items.Text = "Ordered Items";
            this.ordered_items.Width = 585;
            // 
            // btnChangeOrderState2
            // 
            this.btnChangeOrderState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeOrderState2.ForeColor = System.Drawing.Color.Black;
            this.btnChangeOrderState2.Location = new System.Drawing.Point(942, 551);
            this.btnChangeOrderState2.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeOrderState2.Name = "btnChangeOrderState2";
            this.btnChangeOrderState2.Size = new System.Drawing.Size(100, 59);
            this.btnChangeOrderState2.TabIndex = 8;
            this.btnChangeOrderState2.Tag = "";
            this.btnChangeOrderState2.Text = "Prepare";
            this.btnChangeOrderState2.UseVisualStyleBackColor = false;
            this.btnChangeOrderState2.Click += new System.EventHandler(this.btnChangeOrderState2_Click);
            // 
            // btnUndoOrder2
            // 
            this.btnUndoOrder2.ForeColor = System.Drawing.Color.Black;
            this.btnUndoOrder2.Location = new System.Drawing.Point(775, 551);
            this.btnUndoOrder2.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndoOrder2.Name = "btnUndoOrder2";
            this.btnUndoOrder2.Size = new System.Drawing.Size(100, 59);
            this.btnUndoOrder2.TabIndex = 7;
            this.btnUndoOrder2.Text = "Undo";
            this.btnUndoOrder2.UseVisualStyleBackColor = true;
            this.btnUndoOrder2.Click += new System.EventHandler(this.btnUndoOrder2_Click);
            // 
            // pnlOrder2
            // 
            this.pnlOrder2.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOrder2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder2.Controls.Add(this.lblEmployeeID2);
            this.pnlOrder2.Controls.Add(this.label6);
            this.pnlOrder2.Controls.Add(this.lblOrderId2);
            this.pnlOrder2.Controls.Add(this.lblOrderStartTime2);
            this.pnlOrder2.Controls.Add(this.lblTableNumber2);
            this.pnlOrder2.Controls.Add(this.panel5);
            this.pnlOrder2.Location = new System.Drawing.Point(654, 91);
            this.pnlOrder2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrder2.Name = "pnlOrder2";
            this.pnlOrder2.Size = new System.Drawing.Size(495, 427);
            this.pnlOrder2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "OrderID: ";
            // 
            // lblOrderId2
            // 
            this.lblOrderId2.AutoSize = true;
            this.lblOrderId2.Location = new System.Drawing.Point(216, 11);
            this.lblOrderId2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderId2.Name = "lblOrderId2";
            this.lblOrderId2.Size = new System.Drawing.Size(21, 17);
            this.lblOrderId2.TabIndex = 2;
            this.lblOrderId2.Text = "ID";
            // 
            // lblOrderStartTime2
            // 
            this.lblOrderStartTime2.AutoSize = true;
            this.lblOrderStartTime2.ForeColor = System.Drawing.Color.White;
            this.lblOrderStartTime2.Location = new System.Drawing.Point(422, 11);
            this.lblOrderStartTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderStartTime2.Name = "lblOrderStartTime2";
            this.lblOrderStartTime2.Size = new System.Drawing.Size(39, 17);
            this.lblOrderStartTime2.TabIndex = 1;
            this.lblOrderStartTime2.Text = "Time";
            // 
            // lblTableNumber2
            // 
            this.lblTableNumber2.AutoSize = true;
            this.lblTableNumber2.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber2.Location = new System.Drawing.Point(15, 11);
            this.lblTableNumber2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNumber2.Name = "lblTableNumber2";
            this.lblTableNumber2.Size = new System.Drawing.Size(60, 17);
            this.lblTableNumber2.TabIndex = 0;
            this.lblTableNumber2.Text = "Table ...";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lstbDrinks2);
            this.panel5.Controls.Add(this.lstbMains2);
            this.panel5.Controls.Add(this.lstbDesserts2);
            this.panel5.Controls.Add(this.lstbStarters2);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 381);
            this.panel5.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(278, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Drinks";
            // 
            // lstbDrinks2
            // 
            this.lstbDrinks2.FormattingEnabled = true;
            this.lstbDrinks2.ItemHeight = 16;
            this.lstbDrinks2.Location = new System.Drawing.Point(263, 229);
            this.lstbDrinks2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbDrinks2.Name = "lstbDrinks2";
            this.lstbDrinks2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbDrinks2.Size = new System.Drawing.Size(231, 132);
            this.lstbDrinks2.TabIndex = 16;
            // 
            // lstbMains2
            // 
            this.lstbMains2.FormattingEnabled = true;
            this.lstbMains2.ItemHeight = 16;
            this.lstbMains2.Location = new System.Drawing.Point(-1, 229);
            this.lstbMains2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbMains2.Name = "lstbMains2";
            this.lstbMains2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMains2.Size = new System.Drawing.Size(231, 132);
            this.lstbMains2.TabIndex = 15;
            // 
            // lstbDesserts2
            // 
            this.lstbDesserts2.FormattingEnabled = true;
            this.lstbDesserts2.ItemHeight = 16;
            this.lstbDesserts2.Location = new System.Drawing.Point(263, 31);
            this.lstbDesserts2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbDesserts2.Name = "lstbDesserts2";
            this.lstbDesserts2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbDesserts2.Size = new System.Drawing.Size(231, 132);
            this.lstbDesserts2.TabIndex = 14;
            // 
            // lstbStarters2
            // 
            this.lstbStarters2.FormattingEnabled = true;
            this.lstbStarters2.ItemHeight = 16;
            this.lstbStarters2.Location = new System.Drawing.Point(-1, 31);
            this.lstbStarters2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbStarters2.Name = "lstbStarters2";
            this.lstbStarters2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbStarters2.Size = new System.Drawing.Size(231, 132);
            this.lstbStarters2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(278, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Desserts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mains";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Starters";
            // 
            // btnChangeOrderState
            // 
            this.btnChangeOrderState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeOrderState.ForeColor = System.Drawing.Color.Black;
            this.btnChangeOrderState.Location = new System.Drawing.Point(350, 551);
            this.btnChangeOrderState.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeOrderState.Name = "btnChangeOrderState";
            this.btnChangeOrderState.Size = new System.Drawing.Size(100, 59);
            this.btnChangeOrderState.TabIndex = 3;
            this.btnChangeOrderState.Tag = "";
            this.btnChangeOrderState.Text = "Prepare";
            this.btnChangeOrderState.UseVisualStyleBackColor = false;
            this.btnChangeOrderState.Click += new System.EventHandler(this.btnChangeOrderState_Click);
            // 
            // btnUndoOrder1
            // 
            this.btnUndoOrder1.ForeColor = System.Drawing.Color.Black;
            this.btnUndoOrder1.Location = new System.Drawing.Point(183, 551);
            this.btnUndoOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndoOrder1.Name = "btnUndoOrder1";
            this.btnUndoOrder1.Size = new System.Drawing.Size(100, 59);
            this.btnUndoOrder1.TabIndex = 2;
            this.btnUndoOrder1.Text = "Undo";
            this.btnUndoOrder1.UseVisualStyleBackColor = true;
            this.btnUndoOrder1.Click += new System.EventHandler(this.btnUndoOrder1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(1049, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 60);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlOrder1
            // 
            this.pnlOrder1.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOrder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrder1.Controls.Add(this.lblEmployeeID1);
            this.pnlOrder1.Controls.Add(this.label2);
            this.pnlOrder1.Controls.Add(this.lblOrderID1);
            this.pnlOrder1.Controls.Add(this.lblOrderStartTime1);
            this.pnlOrder1.Controls.Add(this.lblTablenumber1);
            this.pnlOrder1.Controls.Add(this.panel3);
            this.pnlOrder1.Location = new System.Drawing.Point(52, 90);
            this.pnlOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOrder1.Name = "pnlOrder1";
            this.pnlOrder1.Size = new System.Drawing.Size(496, 428);
            this.pnlOrder1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "OrderID: ";
            // 
            // lblOrderID1
            // 
            this.lblOrderID1.AutoSize = true;
            this.lblOrderID1.Location = new System.Drawing.Point(209, 12);
            this.lblOrderID1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID1.Name = "lblOrderID1";
            this.lblOrderID1.Size = new System.Drawing.Size(21, 17);
            this.lblOrderID1.TabIndex = 2;
            this.lblOrderID1.Text = "ID";
            // 
            // lblOrderStartTime1
            // 
            this.lblOrderStartTime1.AutoSize = true;
            this.lblOrderStartTime1.ForeColor = System.Drawing.Color.White;
            this.lblOrderStartTime1.Location = new System.Drawing.Point(422, 12);
            this.lblOrderStartTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderStartTime1.Name = "lblOrderStartTime1";
            this.lblOrderStartTime1.Size = new System.Drawing.Size(39, 17);
            this.lblOrderStartTime1.TabIndex = 1;
            this.lblOrderStartTime1.Text = "Time";
            // 
            // lblTablenumber1
            // 
            this.lblTablenumber1.AutoSize = true;
            this.lblTablenumber1.ForeColor = System.Drawing.Color.White;
            this.lblTablenumber1.Location = new System.Drawing.Point(13, 12);
            this.lblTablenumber1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTablenumber1.Name = "lblTablenumber1";
            this.lblTablenumber1.Size = new System.Drawing.Size(60, 17);
            this.lblTablenumber1.TabIndex = 0;
            this.lblTablenumber1.Text = "Table ...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lstbDrinks1);
            this.panel3.Controls.Add(this.lstbDesserts1);
            this.panel3.Controls.Add(this.lstbMains1);
            this.panel3.Controls.Add(this.lstbStarters1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 381);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(274, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Drinks";
            // 
            // lstbDrinks1
            // 
            this.lstbDrinks1.FormattingEnabled = true;
            this.lstbDrinks1.ItemHeight = 16;
            this.lstbDrinks1.Location = new System.Drawing.Point(264, 229);
            this.lstbDrinks1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbDrinks1.Name = "lstbDrinks1";
            this.lstbDrinks1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbDrinks1.Size = new System.Drawing.Size(231, 132);
            this.lstbDrinks1.TabIndex = 11;
            // 
            // lstbDesserts1
            // 
            this.lstbDesserts1.FormattingEnabled = true;
            this.lstbDesserts1.ItemHeight = 16;
            this.lstbDesserts1.Location = new System.Drawing.Point(264, 31);
            this.lstbDesserts1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbDesserts1.Name = "lstbDesserts1";
            this.lstbDesserts1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbDesserts1.Size = new System.Drawing.Size(231, 132);
            this.lstbDesserts1.TabIndex = 10;
            // 
            // lstbMains1
            // 
            this.lstbMains1.FormattingEnabled = true;
            this.lstbMains1.ItemHeight = 16;
            this.lstbMains1.Location = new System.Drawing.Point(-1, 229);
            this.lstbMains1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbMains1.Name = "lstbMains1";
            this.lstbMains1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbMains1.Size = new System.Drawing.Size(231, 132);
            this.lstbMains1.TabIndex = 9;
            // 
            // lstbStarters1
            // 
            this.lstbStarters1.FormattingEnabled = true;
            this.lstbStarters1.ItemHeight = 16;
            this.lstbStarters1.Location = new System.Drawing.Point(-1, 31);
            this.lstbStarters1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbStarters1.Name = "lstbStarters1";
            this.lstbStarters1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbStarters1.Size = new System.Drawing.Size(231, 132);
            this.lstbStarters1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(274, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desserts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1216, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAllOrders
            // 
            this.tsmiAllOrders.Name = "tsmiAllOrders";
            this.tsmiAllOrders.Padding = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.tsmiAllOrders.Size = new System.Drawing.Size(424, 37);
            this.tsmiAllOrders.Text = "All Active Orders";
            this.tsmiAllOrders.Click += new System.EventHandler(this.tsmiAllOrders_Click);
            // 
            // tsmiRunningOrders
            // 
            this.tsmiRunningOrders.Name = "tsmiRunningOrders";
            this.tsmiRunningOrders.Size = new System.Drawing.Size(123, 37);
            this.tsmiRunningOrders.Text = "Running orders";
            this.tsmiRunningOrders.Click += new System.EventHandler(this.tsmiRunningOrders_Click);
            // 
            // tsmiFinishedOrders
            // 
            this.tsmiFinishedOrders.Name = "tsmiFinishedOrders";
            this.tsmiFinishedOrders.Padding = new System.Windows.Forms.Padding(300, 0, 4, 0);
            this.tsmiFinishedOrders.Size = new System.Drawing.Size(419, 37);
            this.tsmiFinishedOrders.Text = "Finished Orders";
            this.tsmiFinishedOrders.Click += new System.EventHandler(this.tsmiFinishedOrders_Click);
            // 
            // lblEmployeeID1
            // 
            this.lblEmployeeID1.AutoSize = true;
            this.lblEmployeeID1.Location = new System.Drawing.Point(268, 12);
            this.lblEmployeeID1.Name = "lblEmployeeID1";
            this.lblEmployeeID1.Size = new System.Drawing.Size(82, 17);
            this.lblEmployeeID1.TabIndex = 4;
            this.lblEmployeeID1.Text = "employeeID";
            // 
            // lblEmployeeID2
            // 
            this.lblEmployeeID2.AutoSize = true;
            this.lblEmployeeID2.Location = new System.Drawing.Point(272, 11);
            this.lblEmployeeID2.Name = "lblEmployeeID2";
            this.lblEmployeeID2.Size = new System.Drawing.Size(82, 17);
            this.lblEmployeeID2.TabIndex = 5;
            this.lblEmployeeID2.Text = "employeeID";
            // 
            // BarKitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1215, 822);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BarKitchenView";
            this.Text = "BarKitchenView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFinishedOrders.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox lstbDesserts1;
        private System.Windows.Forms.ListBox lstbMains1;
        private System.Windows.Forms.ListBox lstbStarters1;
        private System.Windows.Forms.Button btnChangeOrderState2;
        private System.Windows.Forms.Button btnUndoOrder2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstbDrinks2;
        private System.Windows.Forms.ListBox lstbMains2;
        private System.Windows.Forms.ListBox lstbDesserts2;
        private System.Windows.Forms.ListBox lstbStarters2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstbDrinks1;
        private System.Windows.Forms.Panel pnlFinishedOrders;
        private System.Windows.Forms.ListView lstFinishedOrders;
        private System.Windows.Forms.ColumnHeader order_id;
        private System.Windows.Forms.ColumnHeader table_number;
        private System.Windows.Forms.ColumnHeader start_time;
        private System.Windows.Forms.ColumnHeader end_time;
        private System.Windows.Forms.ColumnHeader employee_id;
        private System.Windows.Forms.ColumnHeader ordered_items;
        private System.Windows.Forms.Label lblEmployeeID2;
        private System.Windows.Forms.Label lblEmployeeID1;
    }
}