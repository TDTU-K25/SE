using BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject.App.Main.ThoiKhoaBieu
{
    public partial class UC_TKBTongQuat : UserControl
    {
        private Dictionary<String, ArrayList> dictDate;
        MonHocBLL monHocBLL = new MonHocBLL();
        String user_id = "";

        public UC_TKBTongQuat(String user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            display();

        }

        private void display()
        {
            date_container.Controls.Clear();

            var dictMonHoc = new Dictionary<int, string>() { };
            var dictPhongHoc = new Dictionary<int, string>() { };
            var dictDayStart = new Dictionary<int, string>() { };
            var dictDayEnd = new Dictionary<int, string>() { };

            for (int i = 0; i < 28; i++)
            {
                dictMonHoc[i] = "";
                dictPhongHoc[i] = "";
                dictDayStart[i] = "";
                dictDayEnd[i] = "";
            }

            this.dictDate = new Dictionary<string, ArrayList>()
            {
                { "Thứ 2", null},
                { "Thứ 3", null},
                { "Thứ 4", null},
                { "Thứ 5", null},
                { "Thứ 6", null},
                { "Thứ 7", null},
                { "Chủ nhật", null},
            };

            for (int i = 0; i < 7; i++)
            {
                ArrayList arr = new ArrayList();

                for (int j = 0; j < 4; j++)
                {
                    arr.Add(i + j * 7);
                }

                if ((i + 2) != 8)
                {
                    string test = "Thứ " + (i + 2).ToString();
                    dictDate[test] = arr;
                }
                else
                {
                    dictDate["Chủ nhật"] = arr;
                }
            }

            DataTable myReader = monHocBLL.GetMonHocDKCuaSV(user_id);

            foreach (DataRow row in myReader.Rows)
            {
                // Access the data in the DataRow
                foreach (DataColumn column in myReader.Columns)
                {
                    int cahoc = (int)row[10];
                    string thu = row[12].ToString();
                    int vitri = solve(cahoc, thu);
                    dictMonHoc[vitri] = row[4].ToString();
                    dictPhongHoc[vitri] = row[11].ToString();
                    dictDayStart[vitri] = convertString(row[7].ToString());
                    dictDayEnd[vitri] = convertString(row[8].ToString());
                }
            }


            for (int i = 0; i < 28; i++)
            {
                Color color = GetRandomColor();

                UC_Item ucItem = new UC_Item();

                ucItem.setMonHoc(dictMonHoc[i].ToString());
                ucItem.setPhongHoc(dictPhongHoc[i].ToString());
                ucItem.setDayStart(dictDayStart[i].ToString());
                ucItem.setDayEnd(dictDayEnd[i].ToString());

                if (dictMonHoc[i].ToString().Length > 0)
                {
                    ucItem.setBackGround(color);
                }
                else
                {
                    ucItem.setBackGround(Color.LightGray);
                    ucItem.setMonHoc("");
                    ucItem.setPhongHoc("");
                    ucItem.setDayStart("");
                    ucItem.setDayEnd("");

                }
                date_container.Controls.Add(ucItem);

            }
        }

        private int solve(int cahoc, String thu)
        {
            ArrayList arr = this.dictDate[thu];
            return (int)arr[cahoc - 1];
        }

        // RANDOM COLOR
        static Color GetRandomColor()
        {
            string[] arg = { "(145, 191, 180)",
                         "(240, 219, 175)",
                         "(154, 222, 123)",
                         "(255, 199, 199)",
                         "(243, 182, 100)" };

            Random rand = new Random();
            int randomNumber = rand.Next(0, arg.Length);

            // Parse the RGB values from the string representation
            string[] rgbValues = arg[randomNumber].Trim('(', ')').Split(',');

            int red = int.Parse(rgbValues[0].Trim());
            int green = int.Parse(rgbValues[1].Trim());
            int blue = int.Parse(rgbValues[2].Trim());

            // Create the Color object
            Color color = Color.FromArgb(red, green, blue);

            return color;
        }

        public static string convertString(String str)
        {
            DateTime dateTime = DateTime.Parse(str);

            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}