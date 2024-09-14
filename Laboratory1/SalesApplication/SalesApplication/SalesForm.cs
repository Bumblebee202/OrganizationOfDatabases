using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

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
            var name = nameTextBox.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name must be provided.", "Error");
            }
            else
            {
                AddToList(name);
            }
        }

        private void AddToList(string name)
        {
            salesListBox.Items.Add(name);
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            var target = string.Empty;
            if (targetComboBox.SelectedItem != null)
            {
                target = targetComboBox.SelectedItem.ToString();
            }

            var message = string.Empty;
            switch (target)
            {
                case "100000":
                case "300000":
                    message = "This seems a little low.";
                    break;
                case "500000":
                    message = "This seems about right.";
                    break;
                case "1000000":
                    message = "This seems a little high.";
                    break;
                case "10000000":
                    message = "Go for it!";
                    break;
                default:
                    message = "No target set";
                    break;
            }

            MessageBox.Show(message, " Target", MessageBoxButtons.OK);
        }

        private void DeleteSalesPeople()
        {
            foreach (var item in salesListBox.Items)
            {
                var name = item is string
                    ? item as string
                    : item.ToString();

                AskUserToRemoveName(name);
            }
        }

        private void AskUserToRemoveName(string name)
        {
            if (MessageBox.Show(name, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveNameFromList(name);
            }
        }

        private void RemoveNameFromList(string name)
        {
            names.Add(name);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sw = CreateFile();
            foreach (string name in salesListBox.Items)
            {
                WriteSalesPerson(sw, name);
            }
            MessageBox.Show("Save Successful", "Save");
            CloseFile(sw);
        }

        private void CloseFile(StreamWriter sw)
        {
            if (sw != null)
            {
                sw.Close();
            }
        }

        private void WriteSalesPerson(StreamWriter sw, string name)
        {
            sw.Write(name);
        }

        private StreamWriter CreateFile()
        {
            FileStream fs;
            try
            {
                fs = File.Open(@"sales.txt", FileMode.CreateNew);
            }
            catch (Exception)
            {
                fs = File.Open(@"sales.txt", FileMode.Open);
            }
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