using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesApplication
{
    public partial class SetIndividualTargets : Form
    {
        readonly List<string> _salesTargets;

        public SetIndividualTargets()
        {
            InitializeComponent();

            _salesTargets = new List<string>();
        }

        private void addTargetButton_Click(object sender, EventArgs e)
        {
            int.TryParse(targetTextBox.Text, out int target);
            string name = nameTextBox.Text;
            string entry = string.Empty;
            if (!string.IsNullOrEmpty(name))
            {
                entry = $"{name} target is {target}";
                _salesTargets.Add(entry);
            }
        }

        private void listButton_Click(object sender, EventArgs e)
        {            
            AddTargetsToList();
        }

        private void AddTargetsToList()
        {
            targetsListBox.Items.Clear();

            foreach (string salesTarget in _salesTargets)
            {
                targetsListBox.Items.Add(salesTarget);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            object item = targetsListBox.SelectedItem;
            if (item != null)
            {
                var target = item is string str 
                    ? str
                    : item.ToString();

                _salesTargets.Remove(target);

                AddTargetsToList();
            }
        }
    }
}