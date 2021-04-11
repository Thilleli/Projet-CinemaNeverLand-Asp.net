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
            DataTable table = new DataTable();
            table.Columns.Add("img");
            table.Columns.Add("titre");
            table.Columns.Add("date");
            table.Columns.Add("cat");
            table.Columns.Add("genre");
            table.Columns.Add("duree");
            table.Columns.Add("prix");


            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            //connexion
            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, titre = " ", date = " ", genre = " ", prix = " ", categorie = " ", durée = " ", img = " ", film = " ";
            sql = "select * from film where date_film > 2021-03-12";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                img = "<img src='" + dataReader.GetValue(7) + "'/>";
                titre = "</br> <b> Titre : " + dataReader.GetValue(1) + "</b> </br>";
                date = "<b> Date de sortie </b>: " + dataReader.GetValue(2) + "</br>";
                genre = "<b> Genre : </b> " + dataReader.GetValue(3) + "</br>";
                prix = "<b> Prix : </b> " + dataReader.GetValue(4) + "€ </br>";
                categorie = "<b> Catégorie d'age : </b> " + dataReader.GetValue(5) + "</br>";
                durée = "<b> Durée : </b> " + dataReader.GetValue(6) + " h </br>";
                film = img + titre + date + genre + prix + categorie + durée;


                table.Rows.Add(film);
            }

            DataList1.DataSource = table;
            DataList1.DataBind();


            dataReader.Close();
            command.Dispose();

            cnn.Close();
        }
    }
}