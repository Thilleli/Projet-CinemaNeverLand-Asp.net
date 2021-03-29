using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland
{
    public partial class films : System.Web.UI.Page
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
            String sql, titre = " ", date = " ", genre = " ", prix = " ", categorie = " ", durée= " ", img=" " ;
            sql = "select * from film";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                img = dataReader.GetValue(7) + "</br>";
                titre = "Titre : " + dataReader.GetValue(1) + "</br>";
                date = "Date de sortie : " + dataReader.GetValue(2) + "</br>";
                genre = "Genre : " + dataReader.GetValue(3) + "</br>";
                prix = "Prix : " + dataReader.GetValue(4) + "€ </br>";
                categorie = "Catégorie d'age : " + dataReader.GetValue(5) + "</br>";
                durée = "Durée : " + dataReader.GetValue(6) + " h </br>";
               

            }
            Image.Text = img.ToString();
            Response.Write(titre);
            Response.Write(date);
            Response.Write(genre);
            Response.Write(prix);
            Response.Write(categorie);
            Response.Write(durée);

            dataReader.Close();
            command.Dispose();

            cnn.Close();

        }
    }
}