using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_SE_12.DTO;

namespace CNPM_SE_12.View
{
    public partial class QL_Items : UserControl
    {
        public QL_Items(string id_type)
        {
            InitializeComponent();
            ShowDGV();
        }
        
        private void btnAdd_Ctg_Click(object sender, EventArgs e)
        {
            DGV_Items.DataSource = null;
            AU_Category f = new AU_Category("");
            f.D += new AU_Category.Mydel(ShowDGV);
            f.ShowDialog();

        }
        private void ShowDGV()
        {
            DGV_Items.DataSource = BLL.QL_Items_BLL.Instance.getItems_BLL().Select(p => new { p.ID_Items, p.Items_Name, p.Price, p.Status, p.ID_Category, p.Reserve }).ToList();
        }
        private void ShowCtg()
        {
            DGV_Items.DataSource = BLL.QL_Items_BLL.Instance.getCtg_BLL().Select(p => new { p.ID_Category, p.Category_Name }).ToList();
        }

        private void btnDel_Ctg_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Items.SelectedRows;
            if (BLL.QL_Items_BLL.Instance.delItems_BLL(r))
            {
                ShowDGV();
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void btnUpdate_Ctg_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_Items.SelectedRows;
            if (r.Count == 1)
            {
                string id_ctg = r[0].Cells["ID_Category"].Value.ToString();
                AU_Category f = new AU_Category(id_ctg);
                f.D += new AU_Category.Mydel(ShowCtg);
                f.ShowDialog();
            }
        }

        private void btnAdd_Items_Click(object sender, EventArgs e)
        {

            AU_Items f = new AU_Items("");
            f.D += new AU_Items.Mydel(ShowDGV);
            f.ShowDialog();
        }


        private void btnUpdate_Items_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Items_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ShowCtg_Click(object sender, EventArgs e)
        {
            ShowCtg();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void Fill_Ctg()
        {
            Category ctg = new Category();
            DataGridViewSelectedRowCollection r = DGV_Items.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells["ID_Category"].Value.ToString();
                ctg = BLL.QL_Items_BLL.Instance.getCtg_byID_BLL(ID);
                txt_MaLoaiHang.Text = ctg.ID_Category;
                txt_TenLoaiHang.Text = ctg.Category_Name;
            }
        }
        private void Fill_Items()
        {
            Item item = new Item();
            DataGridViewSelectedRowCollection r = DGV_Items.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells["ID_Items"].Value.ToString();
                item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(ID);
                txt_MaSanPham.Text = item.ID_Items;
                txt_TenSanPham.Text = item.Items_Name;
            }
        }
        private void DGV_Items_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_Items.Columns.Count == 2)
            {
                Fill_Ctg();
            }
            else
            {
                Fill_Items();
            }
        }

    }
}
