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
            this.adventureWorksPictureBox = new System.Windows.Forms.PictureBox();
            this.salesButton = new System.Windows.Forms.Button();
            this.setSalesTargetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(294, 138);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 23);
            this.exitButton.TabIndex = 0;
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
            this.headingLabel.Size = new System.Drawing.Size(295, 25);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Adventure Works Sales System ";
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
            // salesButton
            // 
            this.salesButton.Location = new System.Drawing.Point(294, 65);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(113, 23);
            this.salesButton.TabIndex = 12;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // setSalesTargetButton
            // 
            this.setSalesTargetButton.Location = new System.Drawing.Point(294, 94);
            this.setSalesTargetButton.Name = "setSalesTargetButton";
            this.setSalesTargetButton.Size = new System.Drawing.Size(113, 23);
            this.setSalesTargetButton.TabIndex = 14;
            this.setSalesTargetButton.Text = "Set Sales Targets";
            this.setSalesTargetButton.UseVisualStyleBackColor = true;
            this.setSalesTargetButton.Click += new System.EventHandler(this.setSalesTargetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 173);
            this.Controls.Add(this.setSalesTargetButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.adventureWorksPictureBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.PictureBox adventureWorksPictureBox;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button setSalesTargetButton;
    }
}

