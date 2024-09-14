namespace SalesApplication
{
    partial class SetTargetForm
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
            this.targetSalesLabel = new System.Windows.Forms.Label();
            this.targetSalesTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // targetSalesLabel
            // 
            this.targetSalesLabel.AutoSize = true;
            this.targetSalesLabel.Location = new System.Drawing.Point(11, 19);
            this.targetSalesLabel.Name = "targetSalesLabel";
            this.targetSalesLabel.Size = new System.Drawing.Size(68, 13);
            this.targetSalesLabel.TabIndex = 2;
            this.targetSalesLabel.Text = "Target sales:";
            // 
            // targetSalesTextBox
            // 
            this.targetSalesTextBox.Location = new System.Drawing.Point(85, 16);
            this.targetSalesTextBox.Name = "targetSalesTextBox";
            this.targetSalesTextBox.Size = new System.Drawing.Size(116, 20);
            this.targetSalesTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(126, 57);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SetTargetForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 92);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.targetSalesTextBox);
            this.Controls.Add(this.targetSalesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetTargetForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Target Sales";
            this.Load += new System.EventHandler(this.SetTargetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label targetSalesLabel;
        private System.Windows.Forms.TextBox targetSalesTextBox;
        private System.Windows.Forms.Button OKButton;
    }
}