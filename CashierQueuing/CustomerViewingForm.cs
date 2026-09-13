using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashierQueuing
{
    public partial class CustomerViewingForm : Form
    {
        public CustomerViewingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null)
            {
                try
                {
                    string front = CashierClass.CashierQueue.Peek();
                    if (CashierClass.CashierQueue.Contains(front))
                    {
                        if (!string.IsNullOrEmpty(CashierClass.NowServing))
                        {
                            lblNowServing.Text = CashierClass.NowServing;
                        }
                    }
                }
                catch (InvalidOperationException)
                {
                    if (!string.IsNullOrEmpty(CashierClass.NowServing))
                    {
                        lblNowServing.Text = CashierClass.NowServing;
                    }
                }
            }
        }
    }
}