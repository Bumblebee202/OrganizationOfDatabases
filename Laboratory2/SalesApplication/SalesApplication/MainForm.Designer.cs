namespace SalesApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.headingLabel = new System.Windows.Forms.Label();
            this.salesButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.adventureWorksPictureBox = new System.Windows.Forms.PictureBox();
            this.setTargetButton = new System.Windows.Forms.Button();
            this.targetSalesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(332, 138);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(117, 20);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(290, 25);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Adventure Works Sales System";
            // 
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(332, 78);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(75, 23);
            this.salesButton.TabIndex = 2;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(167, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(126, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Enter sales person name:";
            // 
            // adventureWorksPictureBox
            // 
            this.adventureWorksPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("adventureWorksPictureBox.Image")));
            this.adventureWorksPictureBox.Location = new System.Drawing.Point(12, 12);
            this.adventureWorksPictureBox.Name = "adventureWorksPictureBox";
            this.adventureWorksPictureBox.Size = new System.Drawing.Size(100, 50);
            this.adventureWorksPictureBox.TabIndex = 2;
            this.adventureWorksPictureBox.TabStop = false;
            // 
            // setTargetButton
            // 
            this.setTargetButton.Location = new System.Drawing.Point(332, 108);
            this.setTargetButton.Name = "setTargetButton";
            this.setTargetButton.Size = new System.Drawing.Size(75, 23);
            this.setTargetButton.TabIndex = 3;
            this.setTargetButton.Text = "Set Target";
            this.setTargetButton.UseVisualStyleBackColor = true;
            this.setTargetButton.Click += new System.EventHandler(this.setTargetButton_Click);
            // 
            // targetSalesLabel
            // 
            this.targetSalesLabel.AutoSize = true;
            this.targetSalesLabel.ForeColor = System.Drawing.Color.Blue;
            this.targetSalesLabel.Location = new System.Drawing.Point(12, 113);
            this.targetSalesLabel.Name = "targetSalesLabel";
            this.targetSalesLabel.Size = new System.Drawing.Size(158, 13);
            this.targetSalesLabel.TabIndex = 5;
            this.targetSalesLabel.Text = "Target sales for all sales people:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(419, 173);
            this.Controls.Add(this.targetSalesLabel);
            this.Controls.Add(this.setTargetButton);
            this.Controls.Add(this.adventureWorksPictureBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.salesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.PictureBox adventureWorksPictureBox;
        private System.Windows.Forms.Button setTargetButton;
        private System.Windows.Forms.Label targetSalesLabel;
    }
}

