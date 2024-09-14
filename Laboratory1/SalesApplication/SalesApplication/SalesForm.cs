using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SalesApplication
{
    public partial class SalesForm : Form
    {
        ArrayList names = new ArrayList();
        public SalesForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            // TODO [Ex 1]: Add the name to the list box here.
            
        }

        private void AddToList(string name)
        {
            salesListBox.Items.Add(name);
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            string target = "";
            if (targetComboBox.SelectedItem != null)
                target = targetComboBox.SelectedItem.ToString();
            
            // TODO [Ex 1]: Let the user know if the value of target is acceptable.
        }

        private void DeleteSalesPeople()
        {
            // TODO [Ex 1]: Delete items from the listbox if the user agrees.
        }

        private void AskUserToRemoveName(string name)
        {
            if (MessageBox.Show(name, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                RemoveNameFromList(name);
        }

        private void RemoveNameFromList(string name)
        {
            names.Add(name);
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            sw = CreateFile();
            foreach (string name in salesListBox.Items)
            {
                WriteSalesPerson(sw, name);
            }
            MessageBox.Show("Save Successful", "Save");
        }

        private void CloseFile(StreamWriter sw)
        {
            if(sw != null)
                sw.Close();
        }

        private void WriteSalesPerson(StreamWriter sw, string name)
        {
            sw.Write(name);
        }

        private StreamWriter CreateFile()
        {
            // TODO [Ex 2]: Add a catch handler to open the file rather than creating it.
            FileStream fs;
            fs = File.Open(@"sales.txt", FileMode.CreateNew);
            return new StreamWriter(fs);
        }
        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteSalesPeople();
            ReallyRemoveNameFromList();
        }

        private void ReallyRemoveNameFromList()
        {
            foreach (string name in names)
            {
                salesListBox.Items.Remove(name);
            }
            names.Clear();
        }

    }
}