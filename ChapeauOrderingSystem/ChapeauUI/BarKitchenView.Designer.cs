
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DeleteThisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRefresh.Location = new System.Drawing.Point(1563, 1007);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DeleteThisButton
            // 
            this.DeleteThisButton.Location = new System.Drawing.Point(1563, 916);
            this.DeleteThisButton.Name = "DeleteThisButton";
            this.DeleteThisButton.Size = new System.Drawing.Size(101, 50);
            this.DeleteThisButton.TabIndex = 1;
            this.DeleteThisButton.Text = "TempButton";
            this.DeleteThisButton.UseVisualStyleBackColor = true;
            this.DeleteThisButton.Click += new System.EventHandler(this.DeleteThisButton_Click);
            // 
            // BarKitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1676, 1055);
            this.Controls.Add(this.DeleteThisButton);
            this.Controls.Add(this.btnRefresh);
            this.Name = "BarKitchenView";
            this.Text = "BarKitchenView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button DeleteThisButton;
    }
}