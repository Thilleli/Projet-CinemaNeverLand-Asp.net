using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace CinemaNerverland
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            //connexion
            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, titre = " ", date = " ", genre = " ", prix = " ", categorie = " ", durée = " ", img = " ", film = " ";
            sql = "select * from film where date_film > 2021-02-12";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                img = "<img src='" + dataReader.GetValue(7) + "'/>";
                titre = "</br> Titre : " + dataReader.GetValue(1) + "</br>";
                date = "Date de sortie : " + dataReader.GetValue(2) + "</br>";
                genre = "Genre : " + dataReader.GetValue(3) + "</br>";
                prix = "Prix : " + dataReader.GetValue(4) + "€ </br>";
                categorie = "Catégorie d'age : " + dataReader.GetValue(5) + "</br>";
                durée = "Durée : " + dataReader.GetValue(6) + " h </br>";
                film = img + titre + date + genre + prix + categorie + durée;

                
                Response.Write(film);

            }
            
            
             
            dataReader.Close();
            command.Dispose();

            cnn.Close();

           /* DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("101", "Sachin Kumar", "sachin@example.com");
            table.Rows.Add("102", "Peter", "peter@example.com");
            table.Rows.Add("103", "Ravi Kumar", "ravi@example.com");
            table.Rows.Add("104", "Irfan", "irfan@example.com");
            DataList1.DataSource = table;
            DataList1.DataBind();*/
        }
    }
}