
namespace ChapeauUI
{
    partial class FoodOrder
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
            this.lblDisplayTableNmbr = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnIsPrepared = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblDisplayTime);
            this.panel1.Controls.Add(this.lblDisplayTableNmbr);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblDisplayTableNmbr
            // 
            this.lblDisplayTableNmbr.AutoSize = true;
            this.lblDisplayTableNmbr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTableNmbr.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTableNmbr.Location = new System.Drawing.Point(3, 9);
            this.lblDisplayTableNmbr.Name = "lblDisplayTableNmbr";
            this.lblDisplayTableNmbr.Size = new System.Drawing.Size(81, 23);
            this.lblDisplayTableNmbr.TabIndex = 0;
            this.lblDisplayTableNmbr.Text = "Table ...";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTime.Location = new System.Drawing.Point(311, 9);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(28, 23);
            this.lblDisplayTime.TabIndex = 1;
            this.lblDisplayTime.Text = "...";
            // 
            // btnPrepare
            // 
            this.btnPrepare.Location = new System.Drawing.Point(394, 0);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(75, 81);
            this.btnPrepare.TabIndex = 1;
            this.btnPrepare.Text = "Prepare";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnIsPrepared
            // 
            this.btnIsPrepared.Location = new System.Drawing.Point(394, 0);
            this.btnIsPrepared.Name = "btnIsPrepared";
            this.btnIsPrepared.Size = new System.Drawing.Size(78, 81);
            this.btnIsPrepared.TabIndex = 2;
            this.btnIsPrepared.Text = "Done Preparing";
            this.btnIsPrepared.UseVisualStyleBackColor = true;
            this.btnIsPrepared.Click += new System.EventHandler(this.btnIsPrepared_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-2, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 398);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side Dishes";
            // 
            // FoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIsPrepared);
            this.Controls.Add(this.btnPrepare);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FoodOrder";
            this.Text = "FoodOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayTableNmbr;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnIsPrepared;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}