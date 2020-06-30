using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CNPM_SE_12.View
{
    public partial class CheckPoint : UserControl
    {
        private string ID_Type;
        #region Peoperties
        private List<List<Button>> matrix;
        private List<string> Day;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public CheckPoint()
        {
            InitializeComponent();
            LoadMatrix();
        }

        public void ReadData()
        {
            Day = new List<string>();
            string[] lines = File.ReadAllLines(@"K:\Lich.txt");

            foreach (string s in lines)
            {
                for (int i = 0; i < Matrix.Count; i++)
                {
                    for (int j = 0; j < Matrix[i].Count; j++)
                    {
                        Button btn = Matrix[i][j];
                        if (btn.Text == s)
                        {
                            btn.BackColor = Color.Yellow;
                            Day.Add(s);
                        }

                    }
                }
            }
            Console.ReadLine();
        }

        public void WriteData()
        {
            //giatri = Console.ReadLine();
            String filepath = "E:\\Lich.txt";
            FileStream fs = new FileStream(filepath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            for (int i = 0; i < Day.Count; i++)
            {
                sWriter.WriteLine(Day[i]);
                sWriter.Flush();
            }
            fs.Close();
        }
        public void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    btn.Click += btn_Click;
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DateTime dt = DateTime.Now;

            //MessageBox.Show(dt.Date.ToString());

            if (btn.Text == dt.Day.ToString())
            {
                btn.BackColor = Color.Yellow;
                Day.Add(btn.Text);
                WriteData();
            }
        }

        private int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }

        private void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();



                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Aqua;
                    ReadData();
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        private void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }


        private void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void pnlMatrix_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
