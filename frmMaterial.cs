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
    
    public partial class frmMaterial : Form
    {
        DataTable tblMaterial;
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            txtMaterialId.Enabled = false;
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT Id, Name FROM Material";
            tblMaterial = Class.Functions.GetDataToTable(sql); 
            dataGridView1.DataSource = tblMaterial; //Nguồn dữ liệu            
            dataGridView1.Columns[0].HeaderText = "Material ID";
            dataGridView1.Columns[1].HeaderText = "Material Name";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Currently in Add Mode!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialId.Focus();
                return;
            }
            if (tblMaterial.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaterialId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtMaterialName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
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
            ResetValue(); //Xoá trắng các textbox
            txtMaterialId.Enabled = true; //cho phép nhập mới
            txtMaterialId.Focus();
        }

        private void ResetValue()
        {
            txtMaterialId.Text = "";
            txtMaterialName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaterialId.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Input Material ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialId.Focus();
                return;
            }
            if (txtMaterialName.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Input Material Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaterialName.Focus();
                return;
            }
            sql = "Select Id From Material where Id=N'" + txtMaterialId.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Material ID Existed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaterialId.Focus();
                return;
            }

            sql = "INSERT INTO Material VALUES(N'" +
                txtMaterialId.Text + "',N'" + txtMaterialName.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtMaterialId.Enabled = false;
        }



        private void btnModify_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMaterial.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaterialId.Text == "")
            {
                MessageBox.Show("Pick A Material!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaterialName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter Material Name!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE Material SET Name=N'" +
                txtMaterialName.Text.ToString() +
                "' WHERE Id=N'" + txtMaterialId.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnSkip.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMaterial.Rows.Count == 0)
            {
                MessageBox.Show("No Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaterialId.Text == "") 
            {
                MessageBox.Show("Pick A Material!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are You Sure You Want To Delete This?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Material WHERE Id=N'" + txtMaterialId.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
