using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureManagement
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string caption)
        {
            InitializeComponent();
            displayMessage.Text = message;
            Text = caption;
            TopMost = true;
            Capture = true;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowIcon = false;
            okButton.Focus();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
                this.Close();      
        }

        private void okButton_onKeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            this.Close();           
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            this.Close();
            return false;
        }

    }
}
