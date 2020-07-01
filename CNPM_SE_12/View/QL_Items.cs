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
using System.Collections;

namespace CNPM_SE_12.View
{
    public partial class QL_Items : UserControl
    {
        private string ID_Type;
        public QL_Items(string id_Account)
        {
            InitializeComponent();
            set_cbbCtg();
            ShowDGV();
        }
        
        private void btnAdd_Ctg_Click(object sender, EventArgs e)
        {
            DGV_Items.DataSource = null;
            AU_Category f = new AU_Category("");
            f.D += new AU_Category.Mydel(ShowDGV);
            f.ShowDialog();

        }

        private void del_row_DGV()
        {
            
        }
        private void ShowDGV()
        {

            DGV_Items.ColumnCount = 6;
            DGV_Items.Columns[0].Name = "Mã sản phẩm";
            DGV_Items.Columns[1].Name = "Tên sản phẩm";
            DGV_Items.Columns[2].Name = "Giá";
            DGV_Items.Columns[3].Name = "Trạng thái";
            DGV_Items.Columns[4].Name = "Mã loại hàng";
            DGV_Items.Columns[5].Name = "Số lượng";
            while (DGV_Items.Rows.Count > 1)
            {
                DGV_Items.Rows.RemoveAt(0);
            }
            List<Item> items = BLL.QL_Items_BLL.Instance.getItems_BLL().Select(p => p).ToList();
            int n = items.Count;
            foreach (Item i in items)
            { 
                    ArrayList a = new ArrayList();
                    a.Add(i.ID_Items);
                    a.Add(i.Items_Name);
                    a.Add(i.Price);
                    a.Add(i.Status);
                    a.Add(i.ID_Category);
                    a.Add(i.Reserve);
                    DGV_Items.Rows.Add(a.ToArray());
            }
            
        }
        private void ShowCtg()
        {
            DGV_Items.DataSource = null;
            DGV_Items.ColumnCount = 2;
            DGV_Items.Columns[0].Name = "Mã loại hàng";
            DGV_Items.Columns[1].Name = "Tên loại hàng";
            while (DGV_Items.Rows.Count > 1)
            {
                DGV_Items.Rows.RemoveAt(0);
            }
            List<Category> ctg = BLL.QL_Items_BLL.Instance.getCtg_BLL().Select(p => p).ToList();
            foreach( Category i in ctg)
            {
                ArrayList a = new ArrayList();
                a.Add(i.ID_Category);
                a.Add(i.Category_Name);
                DGV_Items.Rows.Add(a.ToArray());
            }

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
                string ID = r[0].Cells["Mã loại hàng"].Value.ToString();
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
                string ID = r[0].Cells[0].Value.ToString();
                item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(ID);
                txt_MaSanPham.Text = item.ID_Items;
                txt_TenSanPham.Text = item.Items_Name;
                txt_Gia.Text = item.Price.ToString();
                txt_TinhTrang.Text = item.Status;
                txt_SoLuong.Text = item.Reserve.ToString();
                cbb_MaLoaiHang.SelectedIndex = Convert.ToInt32(item.ID_Category) - 1;
                //(CBBCtg)cbb_MaLoaiHang.SelectedItem).Text.ToString() = item.ID_Category;
                
            }
        }
        
        private void set_cbbCtg()
        {
            List<Category> ctg = BLL.QL_Items_BLL.Instance.getCtg_BLL();
            foreach (Category i in ctg)
            {
                cbb_MaLoaiHang.Items.Add(new CBBCtg { Text = i.Category_Name, Values = Convert.ToInt32(i.ID_Category) });
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
