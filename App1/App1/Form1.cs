using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestLabel.Text = Properties.Resources.String1;
        }

        private void EnButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void JaButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ja-JP");
        }

        private void OpenModalButton_Click(object sender, EventArgs e)
        {
            Form2 modal = new Form2();
            modal.ShowDialog(this);
        }

        private void ChangeLanguage(string locale = null)
        {
            CultureInfo ci = locale == null ? CultureInfo.InvariantCulture : new CultureInfo(locale, false);
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;
        }
    }
}
