using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApplication
{
    public partial class SetIndividualTargets : Form
    {
        // TODO [Ex 3]: Add a generic collection to hold the sales targets.

        public SetIndividualTargets()
        {
            InitializeComponent();
        }

        private void addTargetButton_Click(object sender, EventArgs e)
        {
            int target;
            Int32.TryParse(targetTextBox.Text, out target);
            string name = nameTextBox.Text;
            string entry = "";
            if (!string.IsNullOrEmpty(name))
            {
                entry = string.Format("{0} target is {1}", name, target);
            }
            // TODO [Ex 3]: Add the sales targets to the collection.

        }

        private void listButton_Click(object sender, EventArgs e)
        {            
            AddTargetsToList();
        }

        private void AddTargetsToList()
        {
            targetsListBox.Items.Clear();

            // TODO [Ex 3]: Loop over the collection and add each entry to the listbox.
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            object item = targetsListBox.SelectedItem;
            if (item != null)
            {
                string target = item.ToString();

                // TODO [Ex 3]: Remove the targets from the collection.

                AddTargetsToList();
            }
        }
    }
}