namespace SalesApplication
{
    partial class SetIndividualTargets
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addTargetButton = new System.Windows.Forms.Button();
            this.targetTextBox = new System.Windows.Forms.MaskedTextBox();
            this.targetsListBox = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(80, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(190, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target:";
            // 
            // addTargetButton
            // 
            this.addTargetButton.Location = new System.Drawing.Point(12, 66);
            this.addTargetButton.Name = "addTargetButton";
            this.addTargetButton.Size = new System.Drawing.Size(258, 29);
            this.addTargetButton.TabIndex = 4;
            this.addTargetButton.Text = "Add";
            this.addTargetButton.UseVisualStyleBackColor = true;
            this.addTargetButton.Click += new System.EventHandler(this.addTargetButton_Click);
            // 
            // targetTextBox
            // 
            this.targetTextBox.Location = new System.Drawing.Point(81, 40);
            this.targetTextBox.Mask = "00000";
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.Size = new System.Drawing.Size(189, 20);
            this.targetTextBox.TabIndex = 3;
            this.targetTextBox.ValidatingType = typeof(int);
            // 
            // targetsListBox
            // 
            this.targetsListBox.FormattingEnabled = true;
            this.targetsListBox.Location = new System.Drawing.Point(17, 138);
            this.targetsListBox.Name = "targetsListBox";
            this.targetsListBox.Size = new System.Drawing.Size(253, 121);
            this.targetsListBox.TabIndex = 6;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(12, 103);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(258, 29);
            this.listButton.TabIndex = 5;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 274);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(258, 33);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SetIndividualTargets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 311);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.targetsListBox);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.addTargetButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SetIndividualTargets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Individual Targets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTargetButton;
        private System.Windows.Forms.MaskedTextBox targetTextBox;
        private System.Windows.Forms.ListBox targetsListBox;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button deleteButton;
    }
}