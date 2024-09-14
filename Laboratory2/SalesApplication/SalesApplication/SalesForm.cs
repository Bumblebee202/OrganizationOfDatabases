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
    /// Represents a form that displays sales details 
    /// for a particular sales person.
    /// </summary>
    public partial class SalesForm : Form
    {
        SalesPerson _salesPerson;

        /// <summary>
        /// Initializes the form object.
        /// </summary>
        /// <param name="name">Name of sales person for this form.</param>
        public SalesForm(string name)
        {
            InitializeComponent();

            _salesPerson = new SalesPerson(name);
        }

        /// <summary>
        /// Initializes the appearance of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesForm_Load(object sender, EventArgs e)
        {
            Text = $"Sales Details for {_salesPerson.Name}";

            DisplaySalesDetails();
        }

        /// <summary>
        /// Displays the sales details for the sales person.
        /// </summary>
        private void DisplaySalesDetails()
        {
            // TODO: Display the sales details for the sales person.
            totalSalesLabel.Text = string.Format("Total sales: {0:c2}", 0.0);
            averageSaleLabel.Text = string.Format("Average sale: {0:c2}", 0.0);
            statusLabel.Text = "[Status]";
        }

        /// <summary>
        /// Adds a sale to the SalesPerson instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sale = decimal.Parse(saleTextBox.Text);

                // TODO: Add the sale to the sales person.
                

                DisplaySalesDetails();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a numeric sales value.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            saleTextBox.Clear();
            saleTextBox.Focus();
        }

        /// <summary>
        /// Discards the SalesPerson instance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Discard the SalesPerson instance.

        }
    }
}