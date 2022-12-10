using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExampleRevision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double ADULTS = 110.00D;
        const int CHILDREN = 75;
        uint int_number_adults = 0, int_children_concession = 0, int_amount_received = 0;
        float flt_amount_received = 0;
        double dbl_total_fare_cost = 0, dbl_amount_received = 0, dbl_customer_change = 0, dbl_adults_fare_cost = 0, dbl_children_concession_fare_cost = 0;

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(txtAmountReceived.Text, out int_amount_received))
            {
                int_amount_received = uint.Parse(txtAmountReceived.Text);

                if (int_amount_received > dbl_total_fare_cost)
                {
                    MessageBox.Show("The entered value cannot be greater than the total fare cost");
                    txtAmountReceived.Clear();
                    txtAmountReceived.Focus();
                }
                else
                {
                    dbl_customer_change = dbl_total_fare_cost - uint_amount_received;
                    txtCustomerChange.Text = dbl_customer_change.ToString("C");
                }
            }
            else if (float.TryParse(txtAmountReceived.Text, out flt_amount_received))
            {
                flt_amount_received = float.Parse(txtAmountReceived.Text);

                if (flt_amount_received > dbl_total_fare_cost)
                {
                    MessageBox.Show("The entered value cannot be greater than the total fare cost");
                    txtAmountReceived.Clear();
                    txtAmountReceived.Focus();
                }
                else
                {
                    dbl_customer_change = dbl_total_fare_cost - flt_amount_received;
                    txtCustomerChange.Text = dbl_customer_change.ToString("C");
                }
            }
            else if (double.TryParse(txtAmountReceived.Text, out dbl_amount_received))
            {
                dbl_amount_received = double.Parse(txtAmountReceived.Text);

                if (dbl_amount_received > dbl_total_fare_cost)
                {
                    MessageBox.Show("The entered value cannot be greater than the total fare cost");
                    txtAmountReceived.Clear();
                    txtAmountReceived.Focus();
                }
                else
                {
                    dbl_customer_change = dbl_total_fare_cost - dbl_amount_received;
                    txtCustomerChange.Text = dbl_customer_change.ToString("C");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value that is a positive number");
                txtNumberAdults.Clear();
                txtNumberAdults.Focus();
            }
        }

        private void btnCalculateFareCost_Click(object sender, EventArgs e)
        {
            if (!uint.TryParse(txtNumberAdults.Text, out int_number_adults))
            {
                MessageBox.Show("Please enter a value that is a positive number");
                txtNumberAdults.Clear();
                txtNumberAdults.Focus();
            }
            else if (uint.TryParse(txtNumberAdults.Text, out int_number_adults))
            {
                txtNumberAdults.Text = int_number_adults.ToString();
                dbl_adults_fare_cost = (double)int_number_adults * ADULTS;
            }
            else if (!uint.TryParse(txtNumberChildrenConcession.Text, out int_children_concession))
            {
                MessageBox.Show("Please enter a value that is a positive number");
                txtNumberAdults.Clear();
                txtNumberAdults.Focus();
            }
            else if (uint.TryParse(txtNumberChildrenConcession.Text, out int_children_concession))
            {
                txtNumberChildrenConcession.Text = int_children_concession.ToString();
                dbl_children_concession_fare_cost = (double)int_children_concession * CHILDREN;
            }
            dbl_total_fare_cost = dbl_adults_fare_cost + dbl_children_concession_fare_cost;
            txtTotalFareCost.Text = dbl_total_fare_cost.ToString("C");
        }
    }
}
