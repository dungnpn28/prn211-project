using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopManagementSystem.Class;

namespace ShopManagementSystem
{
    public partial class frmProduct : Form
    {
        DataTable tblProduct;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from Material";
            txtProductId.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboMaterialName, "Id", "Name");
            cboMaterialName.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            cboMaterialName.Text = "";
            txtQuantity.Text = "0";
            txtImportPrice.Text = "0";
            txtPrice.Text = "0";
            txtQuantity.Enabled = true;
            txtImportPrice.Enabled = false;
            txtPrice.Enabled = false;
            txtImage.Text = "";
            picImage.Image = null;
            txtNote.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Product";
            tblProduct = Functions.GetDataToTable(sql);
            dgvProduct.DataSource = tblProduct;
            dgvProduct.Columns[0].HeaderText = "Product ID";
            dgvProduct.Columns[1].HeaderText = "Product Name";
            dgvProduct.Columns[2].HeaderText = "Material ID";
            dgvProduct.Columns[3].HeaderText = "Quantity";
            dgvProduct.Columns[4].HeaderText = "Import Price";
            dgvProduct.Columns[5].HeaderText = "Price";
            dgvProduct.Columns[6].HeaderText = "Image";
            dgvProduct.Columns[7].HeaderText = "Note";
            dgvProduct.Columns[0].Width = 80;
            dgvProduct.Columns[1].Width = 140;
            dgvProduct.Columns[2].Width = 80;
            dgvProduct.Columns[3].Width = 80;
            dgvProduct.Columns[4].Width = 100;
            dgvProduct.Columns[5].Width = 100;
            dgvProduct.Columns[6].Width = 200;
            dgvProduct.Columns[7].Width = 300;
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MatierialId;
            string sql;
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Currently in Add Mode!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return;
            }
            if (tblProduct.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtProductId.Text = dgvProduct.CurrentRow.Cells["Id"].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells["Name"].Value.ToString();
            MatierialId = dgvProduct.CurrentRow.Cells["MaterialId"].Value.ToString();
            sql = "SELECT Name FROM Material WHERE Id=N'" + MatierialId + "'";
            cboMaterialName.Text = Functions.GetFieldValues(sql);
            txtQuantity.Text = dgvProduct.CurrentRow.Cells["Quantity"].Value.ToString();
            txtImportPrice.Text = dgvProduct.CurrentRow.Cells["ExportPrice"].Value.ToString();
            txtPrice.Text = dgvProduct.CurrentRow.Cells["Price"].Value.ToString();
            sql = "SELECT Image FROM Product WHERE Id=N'" + txtProductId.Text + "'";
            txtImage.Text = Functions.GetFieldValues(sql);
            picImage.Image = Image.FromFile(txtImage.Text);
            sql = "SELECT Note FROM Product WHERE Id = N'" + txtProductId.Text + "'";
            txtNote.Text = Functions.GetFieldValues(sql);
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
            txtProductId.Enabled = true;
            txtProductId.Focus();
            txtQuantity.Enabled = true;
            txtImportPrice.Enabled = true;
            txtPrice.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtProductId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Product ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return;
            }
            if (txtProductName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Product Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductName.Focus();
                return;
            }
            if (cboMaterialName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Choose Material!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaterialName.Focus();
                return;
            }
            if (txtImage.Text.Trim().Length == 0)
            {
                MessageBox.Show("Choose an Image!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT Id FROM Product WHERE Id=N'" + txtProductId.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("ID Existed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return;
            }
            sql = "INSERT INTO Product(Id,Name,MaterialId,Quantity,ExportPrice, Price,Image,Note) VALUES(N'"
                + txtProductId.Text.Trim() + "',N'" + txtProductName.Text.Trim() +
                "',N'" + cboMaterialName.SelectedValue.ToString() +
                "'," + txtQuantity.Text.Trim() + "," + txtImportPrice.Text +
                "," + txtPrice.Text + ",'" + txtImage.Text + "',N'" + txtNote.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtProductId.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblProduct.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtProductId.Text == "")
            {
                MessageBox.Show("Choose a Product", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
                return;
            }
            if (txtProductName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Input Product ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductName.Focus();
                return;
            }
            if (cboMaterialName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Choose Material!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaterialName.Focus();
                return;
            }
            if (txtImage.Text.Trim().Length == 0)
            {
                MessageBox.Show("Choose an Image", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtImage.Focus();
                return;
            }
            sql = "UPDATE Product SET Name=N'" + txtProductName.Text.Trim().ToString() +
                "',MaterialId=N'" + cboMaterialName.SelectedValue.ToString() +
                "',Quantity=" + txtQuantity.Text +
                ",Image='" + txtImage.Text + "',Note=N'" + txtNote.Text + "' WHERE Id=N'" + txtProductId.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Choose an Image";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(dlgOpen.FileName);
                txtImage.Text = dlgOpen.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblProduct.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtProductId.Text == "")
            {
                MessageBox.Show("Choose a Product!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("You Sure You Want To Delete This?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Product WHERE Id=N'" + txtProductId.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtProductId.Text == "") && (txtProductName.Text == "") && (cboMaterialName.Text == ""))
            {
                MessageBox.Show("Search by something please!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from Product WHERE 1=1";
            if (txtProductId.Text != "")
                sql += " AND Id LIKE N'%" + txtProductId.Text + "%'";
            if (txtProductName.Text != "")
                sql += " AND Name LIKE N'%" + txtProductName.Text + "%'";
            if (cboMaterialName.Text != "")
                sql += " AND MaterialId LIKE N'%" + cboMaterialName.SelectedValue + "%'";
            tblProduct = Functions.GetDataToTable(sql);
            if (tblProduct.Rows.Count == 0)
                MessageBox.Show("No Products Found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(tblProduct.Rows.Count + " Products Found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvProduct.DataSource = tblProduct;
            ResetValues();
        }
    }
}
