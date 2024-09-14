namespace SalesApplication
{
    partial class SalesForm
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
            this.addSaleButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.averageSaleLabel = new System.Windows.Forms.Label();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.saleTextBox = new System.Windows.Forms.TextBox();
            this.saleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSaleButton
            // 
            this.addSaleButton.Location = new System.Drawing.Point(135, 111);
            this.addSaleButton.Name = "addSaleButton";
            this.addSaleButton.Size = new System.Drawing.Size(86, 23);
            this.addSaleButton.TabIndex = 2;
            this.addSaleButton.Text = "Add Sale";
            this.addSaleButton.UseVisualStyleBackColor = true;
            this.addSaleButton.Click += new System.EventHandler(this.addSaleButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(10, 70);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status:";
            // 
            // averageSaleLabel
            // 
            this.averageSaleLabel.AutoSize = true;
            this.averageSaleLabel.Location = new System.Drawing.Point(10, 42);
            this.averageSaleLabel.Name = "averageSaleLabel";
            this.averageSaleLabel.Size = new System.Drawing.Size(72, 13);
            this.averageSaleLabel.TabIndex = 7;
            this.averageSaleLabel.Text = "Average sale:";
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Location = new System.Drawing.Point(10, 14);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(61, 13);
            this.totalSalesLabel.TabIndex = 0;
            this.totalSalesLabel.Text = "Total sales:";
            // 
            // saleTextBox
            // 
            this.saleTextBox.Location = new System.Drawing.Point(47, 113);
            this.saleTextBox.Name = "saleTextBox";
            this.saleTextBox.Size = new System.Drawing.Size(73, 20);
            this.saleTextBox.TabIndex = 1;
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Location = new System.Drawing.Point(10, 116);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(31, 13);
            this.saleLabel.TabIndex = 11;
            this.saleLabel.Text = "Sale:";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 149);
            this.Controls.Add(this.saleTextBox);
            this.Controls.Add(this.saleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.averageSaleLabel);
            this.Controls.Add(this.addSaleButton);
            this.Controls.Add(this.totalSalesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSaleButton;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label averageSaleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox saleTextBox;
        private System.Windows.Forms.Label saleLabel;
    }
}