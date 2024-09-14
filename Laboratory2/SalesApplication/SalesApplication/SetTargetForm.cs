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
    /// Represents a form that enables the user 
    /// to set the target sales for all sales people.
    /// </summary>
    public partial class SetTargetForm : Form
    {
        /// <summary>
        /// Initializes the form object.
        /// </summary>
        public SetTargetForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the appearance of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetTargetForm_Load(object sender, EventArgs e) 
            => targetSalesTextBox.Text = SalesPerson.TargetSales.ToString();

        /// <summary>
        /// Sets the target sales on the SalesPerson class,
        /// and then closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                SalesPerson.TargetSales = decimal.Parse(targetSalesTextBox.Text);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a numeric sales value.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                targetSalesTextBox.Clear();
                targetSalesTextBox.Focus();
            }
        }
    }
}