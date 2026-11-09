using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work4_
{
    public partial class Productfrm : Form
    {
        public Productfrm()
        {
            InitializeComponent();
        }
        private void CalculateMarkup()
        {
            decimal cost, price;

            if (decimal.TryParse(txtCost.Text, out cost) &&
                decimal.TryParse(txtPrice.Text, out price))
            {
                if (cost > 0)
                {
                    decimal markup = ((price - cost) / cost) * 100;

                    txtMarkup.Text = markup.ToString("N2");
                }
                else
                {
                    txtMarkup.Clear();
                }
            }
            else
            {
                txtMarkup.Clear();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Trim() == "")
            {
                lblBarcodeStatus.Text = "Barcode is required.";
                lblBarcodeStatus.ForeColor = Color.Red;
            }
            else
            {
                lblBarcodeStatus.Text = "Barcode is available.";
                lblBarcodeStatus.ForeColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radbtnLocal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpbOrigin_Enter(object sender, EventArgs e)
        {

        }

        private void radbtnAbroad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkbStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateMarkup();
        }

        private void txtMarkup_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                  DialogResult result = MessageBox.Show(
                  "Are you sure you want to cancel?",
                  "Cancel",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
              );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();

            cmbCategory.SelectedIndex = -1;

            radbtnLocal.Checked = true;
            chkbStatus.Checked = false;

            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();

            lblBarcodeStatus.Text = "Barcode is available.";

            txtBarcode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Trim() == "" ||
              txtName.Text.Trim() == "" ||
              txtDescription.Text.Trim() == "" ||
              cmbCategory.SelectedIndex == -1 ||
              txtCost.Text.Trim() == "" ||
              txtPrice.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please complete all required fields!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal cost, price;

            if (!decimal.TryParse(txtCost.Text, out cost) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter valid Cost and Price values.");
                return;
            }

            if (cost <= 0 || price <= 0)
            {
                MessageBox.Show("Cost and Price must be greater than zero.");
                return;
            }

            decimal markup = ((price - cost) / cost) * 100;

            string origin = radbtnLocal.Checked ? "Local" : "Abroad";

            string status = chkbStatus.Checked ? "Active" : "Inactive";

            MessageBox.Show(
                "PRODUCT SAVED SUCCESSFULLY!\n\n" +
                "Barcode: " + txtBarcode.Text +
                "\nName: " + txtName.Text +
                "\nDescription: " + txtDescription.Text +
                "\nCategory: " + cmbCategory.Text +
                "\nOrigin: " + origin +
                "\nStatus: " + status +
                "\nCost: " + cost.ToString("N2") +
                "\nPrice: " + price.ToString("N2") +
                "\nMarkup: " + markup.ToString("N2") + "%",
                "Product Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void lblBarcodeStatus_Click(object sender, EventArgs e)
        {

        }

        private void Productfrm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Electronics");
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Clothing");
            cmbCategory.Items.Add("Furniture");
            cmbCategory.Items.Add("Others");

            radbtnLocal.Checked = true;
        }
    }
}
