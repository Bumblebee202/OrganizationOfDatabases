using SalesApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApplication
{
    /// <summary>
    /// Represents the main form in the Sales application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the form object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the appearance of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Focus();
            DisplayTargetSales();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Opens the SalesForm form, to enable the user 
        /// to enter sales details for a sales person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            SalesForm form = new SalesForm(name);
            form.Show(this);
        }

        /// <summary>
        /// Opens the SetTargetForm form, to enable the user 
        /// to set the sales target that applies to all sales people.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setTargetButton_Click(object sender, EventArgs e)
        {
            SetTargetForm form = new SetTargetForm();
            form.ShowDialog(this);
            DisplayTargetSales();
        }

        /// <summary>
        /// Displays the target sales, which applies to all sales people.
        /// </summary>
        private void DisplayTargetSales() 
            => targetSalesLabel.Text = $"Target sales for all sales people: {SalesPerson.TargetSales:c2}";
    }
}