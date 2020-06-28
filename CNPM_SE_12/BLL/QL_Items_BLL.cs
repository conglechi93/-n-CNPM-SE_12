using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SE_12.BLL
{
    class QL_Items_BLL
    {
        private static QL_Items_BLL _Instance;
        public static QL_Items_BLL Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new QL_Items_BLL();
                return _Instance;
            }
            private set => _Instance = value;
        }

        private QL_Items_BLL()
        {

        }
        public List<Item> getItems_BLL()
        {
            SE_12Entities db = new SE_12Entities();
            List<Item> item = db.Items.Select(p => p).ToList();
            return item;
        }
        public List<Category> getCtg_BLL()
        {
            SE_12Entities db = new SE_12Entities();
            List<Category> item = db.Categories.Select(p => p).ToList();
            return item;
        }

        public int CountItems_byIDCtg_BLL(int id_Ctg)
        {
            List<Item> item = new List<Item>();
            SE_12Entities db = new SE_12Entities();
            if (id_Ctg == 0)
            {

                item = db.Items.Select(p => p).ToList();
            }
            else
            {
                item = db.Items.Where(p => p.ID_Category == id_Ctg.ToString()).ToList();
            }
            return item.Count;
        }
        public int CountItems_byIDItems_BLL(string id_item)
        {
            List<Item> item = new List<Item>();
            SE_12Entities db = new SE_12Entities();
            if (id_item == "")
            {

                item = db.Items.Select(p => p).ToList();
            }
            else
            {
                item = db.Items.Where(p => p.ID_Items == id_item).ToList();
            }
            return item.Count;
        }

        public Category getCtg_byID_BLL(string Ctg_ID)
        {
            SE_12Entities db = new SE_12Entities();
            return db.Categories.Where(p => p.ID_Category == Ctg_ID).FirstOrDefault();
        }

        public Item getItems_byID_BLL(string id_Items)
        {
            SE_12Entities db = new SE_12Entities();
            return db.Items.Where(p => p.ID_Items == id_Items).FirstOrDefault();
        }

        public List<Item> getItems_byIDCtg_BLL(int id_Ctg)
        {
            SE_12Entities db = new SE_12Entities();
            if (id_Ctg == 0)
            {
                return db.Items.Select(p => p).ToList();
            }
            return db.Items.Where(p => p.ID_Category == id_Ctg.ToString()).ToList();
        }

        public bool Add_Ctg_BLL(Category ctg)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                db.Categories.Add(ctg);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;

            }
        }

        public bool Edit_Ctg_BLL(string Ctg_ID, string Ctg_Name)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                Category ctg_clone = new Category()
                {
                    ID_Category = Ctg_ID,
                    Category_Name = Ctg_Name
                };
                Category ctg = db.Categories.Where(p => p.ID_Category == Ctg_ID).FirstOrDefault();
                ctg.ID_Category = ctg_clone.ID_Category;
                ctg.Category_Name = ctg_clone.Category_Name;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool delItems_BLL(DataGridViewSelectedRowCollection r)
        {
            try
            {
                SE_12Entities db = new SE_12Entities();
                foreach (Item i in db.Items)
                {
                    foreach (DataGridViewRow j in r)
                    {
                        if (i.ID_Items == j.Cells["ID_Items"].Value.ToString())
                        {
                            db.Items.Remove(i);
                        }
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }


    }
}
