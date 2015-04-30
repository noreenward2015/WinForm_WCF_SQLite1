using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;

namespace RestService
{

    public class Service1 : IService1
    {
        public string GetDataUsingMethodName(string value)
        {
            return value + ", I am returned by method name ";
        }


        public string GetDataUsingURI(string value)
        {
            return string.Format(" I am returned by URI name in Json format {0}", value);
            //value + " I am returned by URI name in Json format";
        }

        public Stream GetImage()
        {
            FileStream image = File.OpenRead(@"C:\Users\Noreen Ward\Pictures\CC.jpg");
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return image;
        }

        public string GetCarById(string value)
        {
            string connectionPath = @"Data Source=C:\SQLite\Car2.sqlite;Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionPath);
            {
                connection.Open();
                //Create the SQL Command
               // string SQL;
                //SQL = @"SELECT * FROM Car2";
                //SQLiteCommand cmd = new SQLiteCommand(SQL, connection);

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Car2 WHERE CarID=1";
                var name = cmd.ExecuteNonQuery();
                cmd.


                SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"INSERT INTO Car2 (CarID, Make, Model, Year) VALUES (@carId, @make, @model, @year)";
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@carId", txtIDDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@make", txtMakeDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@model", txtModelDB.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@year", txtYearDB.Text));





               

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable("Car2");
                
                adapter.Fill(dt);
                //BindingSource bSource = new BindingSource();
                //bSource.DataSource = dt;
                //dgCar.DataSource = bSource;
                //adapter.Update(dt);

                connection.Close();
            }
            return value;
        }
    }
}

