using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyCar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        mathsService.WebService1SoapClient ws = new mathsService.WebService1SoapClient();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x, y, z;

            x = int.Parse(txtNum1.Text);
            y = int.Parse(txtNum2.Text);
            z = ws.WebAdd(x, y);
            lblAns.Text = z.ToString();

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage wcfResponse = client.GetAsync("http://localhost:56328/Service1.svc/GetData/..." + "  " + txtRest.Text ).Result;
            HttpContent stream = wcfResponse.Content;
            var data = stream.ReadAsStringAsync();
            txtRest.Text = data.Result;

            picCC.Image = GetImage();
        }


        public Image GetImage()
        {
            string uri = string.Format("http://localhost:56328/Service1.svc/GetImage");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    return new Bitmap(stream);
                }

            }
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            CarService.Service1Client service = new CarService.Service1Client();
            var myCar = service.getMyCar();

            lblModel.Text = myCar.model;
            lblMake.Text = myCar.make;
            lblYear.Text = myCar.year;
        }

        //this code adds the textbox text directly to database
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\SQLite\Car2.sqlite;Version=3;")){
                try{
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"INSERT INTO Car2 (CarID, Make, Model, Year) VALUES (@carId, @make, @model, @year)";
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@carId", txtIDDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@make", txtMakeDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@model", txtModelDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@year", txtYearDB.Text));

                        con.Open();

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Car created");
                        }
                    
                }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnGetCar_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage wcfResponse = client.GetAsync("http://localhost:56328/Service1.svc/GetCarById/" + "  " + txtShowCarById.Text).Result;
            HttpContent stream = wcfResponse.Content;
            var data = stream.ReadAsStringAsync();
            //dgCar.t = data.Result;
            lblTest.Text = data.Result;


        }

       


    
    }
 }

