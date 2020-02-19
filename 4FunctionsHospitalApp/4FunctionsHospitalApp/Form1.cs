using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace _4FunctionsHospitalApp
{
    public partial class HospitalLocator : Form
    {
        List<Hospital> Hlist = new List<Hospital>();
        //string readerFile = "hospitals.csv";
        


        public HospitalLocator()
        {
            InitializeComponent();
        }

        private void HospitalLocator_Load(object sender, EventArgs e)
        {

        }

        private void txtCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFieldParser parser = new TextFieldParser(@"hospitals.csv");
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Processing row
                Hospital h1 = new Hospital("");
                Hlist.Add(h1);
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    Console.WriteLine(field);
                }
                //if (string[4] == )
                //{
                    lblName.Text = Name.ToString();
                //}
                //lblName.Text = Name.ToString();
            }
            lblName.Text = Name.ToString();
            //if (txtCombo1.SelectedIndex == 0)
            //    county.Text = Laois.ToString();
            //while (readerFile != null)
            //{
            //    foreach (Hospital hospitalList in Hlist)
            //    {
                    

            //    }


            //}




            DataTable hospitaltable = new DataTable();
            hospitaltable.Columns.Add("ID");
            hospitaltable.Columns.Add("Name");
            hospitaltable.Columns.Add("Address");
            hospitaltable.Columns.Add("Eircode");
            hospitaltable.Columns.Add("X");
            hospitaltable.Columns.Add("Y");
            //StreamReader streamReader = new StreamReader("Hospitals.csv");
            //string[] Test = new string[] { txtCombo1.Text };
            //Test = streamReader.ReadLine().Split(',');

          //  using (StreamReader sr = new StreamReader("hospitals.csv"))
            //{
            //    //string[] array = new sr.ReadToEnd();
            //    int i = 0;

            //    while ((county = sr.ReadLine()) != null)
            //    {
            //        i++;
            //        //lblAddress = sr.ReadLine();
            //        //lblName.Text = 
            //        //Come back to later
            //        //Console.WriteLine(county);
            //    }
            //    string[] array = new string[i];
            //    lblID.Text = array[0];
            //    lblID.Visible = true;
            //}
            //if (txtCombo1.SelectedIndex != null)
            //{
            //txtCombo2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            county.Visible = true;
            lblCounty.Visible = true;
            txtCombo2.Visible = true;
            lblID.Visible = true;
            lblName.Visible = true;
            //}

            switch (txtCombo1.SelectedIndex)
            {

                case 0:

                    county.Text = "Carlow";
                    //lblName.Text = .Rows[0].Cells[0].Value.ToString();
                    
                    //txtCombo2.Visible = true;
                    break;
                case 1:
                    county.Text = "Cavan";
                    //txtCombo2.Visible = true;
                    break;
                case 2:
                    county.Text = "Clare";
                    //txtCombo2.Visible = true;
                    break;
                case 3:
                    county.Text = "Cork";
                    //txtCombo2.Visible = true;
                    break;
                case 4:
                    county.Text = "Donegal";
                    //txtCombo2.Visible = true;
                    break;
                case 5:
                    county.Text = "Dublin";
                    //txtCombo2.Visible = true;
                    break;
                case 6:
                    county.Text = "Galway";
                    //txtCombo2.Visible = true;
                    break;
                case 7:
                    county.Text = "Kerry";
                    //txtCombo2.Visible = true;
                    break;
                case 8:
                    county.Text = "Kildare";
                    //txtCombo2.Visible = true;
                    break;
                case 9:
                    county.Text = "Kilkenny";
                    //txtCombo2.Visible = true;
                    break;
                case 10:
                    county.Text = "Laois";
                    //txtCombo2.Visible = true;
                    break;
                case 11:
                    county.Text = "Leitrim";
                    //txtCombo2.Visible = true;
                    break;
                case 12:
                    county.Text = "Limerick";
                    //txtCombo2.Visible = true;
                    break;
                case 13:
                    county.Text = "Longford";
                    //txtCombo2.Visible = true;
                    break;
                case 14:
                    county.Text = "Louth";
                    //txtCombo2.Visible = true;
                    break;
                case 15:
                    county.Text = "Mayo";
                    //txtCombo2.Visible = true;
                    break;
                case 16:
                    county.Text = "Meath";
                    //txtCombo2.Visible = true;
                    break;
                case 17:
                    county.Text = "Monaghan";
                    //txtCombo2.Visible = true;
                    break;
                case 18:
                    county.Text = "Offaly";
                    //txtCombo2.Visible = true;
                    break;
                case 19:
                    county.Text = "Roscommon";
                    //txtCombo2.Visible = true;
                    break;
                case 20:
                    county.Text = "Sligo";
                    //txtCombo2.Visible = true;
                    break;
                case 21:
                    county.Text = "Tipperary";
                    //txtCombo2.Visible = true;
                    break;
                case 22:
                    county.Text = "Waterford";
                    //txtCombo2.Visible = true;
                    break;
                case 23:
                    county.Text = "Westmeath";
                    //txtCombo2.Visible = true;
                    break;
                case 24:
                    county.Text = "Wexford";
                    //txtCombo2.Visible = true;
                    break;
                case 25:
                    county.Text = "Wicklow";
                    //txtCombo2.Visible = true;
                    break;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
