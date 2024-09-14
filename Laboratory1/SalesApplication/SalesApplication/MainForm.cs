using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SalesApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.Show(this);
        }

        private void setSalesTargetButton_Click(object sender, EventArgs e)
        {
            SetIndividualTargets form = new SetIndividualTargets();
            form.Show(this);
        }
    }
}