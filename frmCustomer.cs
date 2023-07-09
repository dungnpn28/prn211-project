using ShopManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class frmCustomer : Form
    {
        DataTable tblCustomer;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerId.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Customer";
            tblCustomer = Functions.GetDataToTable(sql);
            dgvCustomer.DataSource = tblCustomer;
            dgvCustomer.Columns[0].HeaderText = "Customer ID";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "Address";
            dgvCustomer.Columns[3].HeaderText = "Phone";
            dgvCustomer.Columns[0].Width = 100;
            dgvCustomer.Columns[1].Width = 150;
            dgvCustomer.Columns[2].Width = 150;
            dgvCustomer.Columns[3].Width = 150;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Currently in Add Mode", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerId.Focus();
                return;
            }
            if (tblCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notificcation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCustomerId.Text = dgvCustomer.CurrentRow.Cells["Id"].Value.ToString();
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["Name"].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells["Address"].Value.ToString();
            mskPhone.Text = dgvCustomer.CurrentRow.Cells["Phone"].Value.ToString();
            btnModify.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDel.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            ResetValues();
            txtCustomerId.Enabled = true;
            txtCustomerId.Focus();
        }

        private void ResetValues()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtAddress.Text = "";
            mskPhone.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtCustomerId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Customer ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerId.Focus();
                return;
            }
            if (txtCustomerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Customer Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (mskPhone.Text == "(  )    -")
            {
                MessageBox.Show("Input Phone Number!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskPhone.Focus();
                return;
            }

            sql = "SELECT Id FROM Customer WHERE Id=N'" + txtCustomerId.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ID Existed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerId.Focus();
                return;
            }

            sql = "INSERT INTO Customer VALUES (N'" + txtCustomerId.Text.Trim() +
                "',N'" + txtCustomerName.Text.Trim() + "',N'" + txtAddress.Text.Trim() + "','" + mskPhone.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtCustomerId.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No Data", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCustomerId.Text == "")
            {
                MessageBox.Show("Pick a Customer", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCustomerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Customer Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerName.Focus();
                return;
            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Address!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;
            }
            if (mskPhone.Text == "(  )    -")
            {
                MessageBox.Show("Input Phone Number", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskPhone.Focus();
                return;
            }
            sql = "UPDATE Customer SET Name=N'" + txtCustomerName.Text.Trim().ToString() + "',Address=N'" +
                txtAddress.Text.Trim().ToString() + "',Phone='" + mskPhone.Text.ToString() +
                "' WHERE Id=N'" + txtCustomerId.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCustomerId.Text.Trim() == "")
            {
                MessageBox.Show("Pick a Customer!", "TNotification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("You Sure You Want To Delete This?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Customer WHERE Id=N'" + txtCustomerId.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSkip.Enabled = false;
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnModify.Enabled = true;
            btnSave.Enabled = false;
            txtCustomerId.Enabled = false;
        }
    }
}
