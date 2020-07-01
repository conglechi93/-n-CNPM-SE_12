using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CNPM_SE_12.DTO;

namespace CNPM_SE_12.View
{
    public partial class QL_Item : UserControl
    {
        public QL_Item()
        {
            InitializeComponent();
        }

        private void ShowItems()
        {
            clear_DGV();
            DGV_Show.ColumnCount = 6;
            DGV_Show.Columns[0].Name = "Mã sản phẩm";
            DGV_Show.Columns[1].Name = "Tên sản phẩm";
            DGV_Show.Columns[2].Name = "Giá";
            DGV_Show.Columns[3].Name = "Trạng thái";
            DGV_Show.Columns[4].Name = "Mã loại hàng";
            DGV_Show.Columns[5].Name = "Số lượng";
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
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
                DGV_Show.Rows.Add(a.ToArray());
            }
        }
        private void ShowCtg()
        {
            clear_DGV();
            DGV_Show.ColumnCount = 2;
            DGV_Show.Columns[0].Name = "Mã loại hàng";
            DGV_Show.Columns[1].Name = "Tên loại hàng";
            List<Category> ctg = BLL.QL_Items_BLL.Instance.getCtg_BLL().Select(p => p).ToList();
            foreach (Category i in ctg)
            {
                ArrayList a = new ArrayList();
                a.Add(i.ID_Category);
                a.Add(i.Category_Name);
                DGV_Show.Rows.Add(a.ToArray());
            }

        }
        private void Add_Ctg()
        {
            AU_Category f = new AU_Category("");
            f.D += new AU_Category.Mydel(ShowCtg);
            f.ShowDialog();
        }
        private void Add_Items()
        {
            AU_Items f = new AU_Items("");
            f.D += new AU_Items.Mydel(ShowItems);
            f.ShowDialog();
        }

        private void Edit_Ctg()
        {
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (r.Count == 1)
            {
                string id_ctg = r[0].Cells["Mã loại hàng"].Value.ToString();
                AU_Category f = new AU_Category(id_ctg);
                f.D += new AU_Category.Mydel(ShowCtg);
                f.ShowDialog();
            }
        }

        private void Edit_Items()
        {
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (r.Count == 1)
            {
                string id_item = r[0].Cells["Mã sản phẩm"].Value.ToString();
                AU_Items f = new AU_Items(id_item);
                f.D += new AU_Items.Mydel(ShowItems);
                f.ShowDialog();
            }
        }

        private void Del_Ctg()
        {
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (BLL.QL_Items_BLL.Instance.delCatg_BLL(r))
            {
                ShowItems();
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
        private void Del_Items()
        {
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (BLL.QL_Items_BLL.Instance.delItems_BLL(r))
            {
                ShowItems();
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
        private void Fill_Ctg()
        {
            Category ctg = new Category();
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells["Mã loại hàng"].Value.ToString();
                ctg = BLL.QL_Items_BLL.Instance.getCtg_byID_BLL(ID);
                txt_IDCtg.Text = ctg.ID_Category;
                txt_NameCtg.Text = ctg.Category_Name;
            }
        }
        private void Fill_Items()
        {
            Item item = new Item();
            DataGridViewSelectedRowCollection r = DGV_Show.SelectedRows;
            if (r.Count == 1)
            {
                string ID = r[0].Cells[0].Value.ToString();
                item = BLL.QL_Items_BLL.Instance.getItems_byID_BLL(ID);
                txt_IDItems.Text = item.ID_Items;
                txt_NameItems.Text = item.Items_Name;
                txt_Price.Text = item.Price.ToString();
                txt_State.Text = item.Status;
                txt_Ctg.Text = item.Category.Category_Name; 
                txt_Values.Text = item.Reserve.ToString();
            }
        }

        private void clear_DGV()
        {
            DGV_Show.DataSource = null;
            while (DGV_Show.Columns.Count > 0)
            {
                DGV_Show.Columns.RemoveAt(0);
            }
            while (DGV_Show.Rows.Count > 1)
            {
                DGV_Show.Rows.RemoveAt(0);
            }
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (tab_Main.SelectedIndex.ToString() == "0") ShowCtg();
            else ShowItems();
        }

        private void tab_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_DGV();
            if (tab_Main.SelectedIndex.ToString() == "0") ShowCtg();
            else ShowItems();
        }

        private void DGV_Show_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DGV_Show.Columns.Count == 2)
            {
                Fill_Ctg();
            }
            else
            {
                Fill_Items();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tab_Main.SelectedIndex.ToString() == "0" ) Add_Ctg();
            else Add_Items();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tab_Main.SelectedIndex.ToString() == "0") Edit_Ctg();
            else Edit_Items();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (tab_Main.SelectedIndex.ToString() == "0") Del_Ctg();
            else Del_Items();
        }
    }
}
