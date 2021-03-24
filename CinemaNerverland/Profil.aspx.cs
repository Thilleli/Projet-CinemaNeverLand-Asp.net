using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland
{
    public partial class Profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Login= " ";
            sql = "select nom_user,login_user from user where login_user='" + Session["ID"]+"'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Login = "Nom : "+ dataReader.GetValue(0) + "</br> Login : "+ dataReader.GetValue(1);
            }
            Response.Write(Login);
            dataReader.Close();
            command.Dispose();

            cnn.Close();

        }

        protected void Session_OnEnd(object sender, EventArgs e)
        {
            Response.Redirect("Connexion.aspx");


        }
    }
}