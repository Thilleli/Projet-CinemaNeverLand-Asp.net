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
            //connexion
            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Login = " ", Nom=" ", Prenom=" ", Age=" ", Mail=" ";
            sql = "select nom_user,prenom_user,age_user,mail_user,login_user from user where login_user='" + Session["login"] + "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Nom= "Nom : " + dataReader.GetValue(0)+"</br>";
                Prenom = "Prénom : " + dataReader.GetValue(1)+"</br>";
                Age = "Age : " + dataReader.GetValue(2)+"</br>";
                Mail = "Adresse mail : " + dataReader.GetValue(3)+"</br>";
                Login = "Login : " + dataReader.GetValue(4)+"</br>";

            }
            nom.Text = Nom.ToString();
            prenom.Text = Prenom.ToString();
            age.Text = Age.ToString();
            mail.Text = Mail.ToString();
            login.Text = Login.ToString();

            dataReader.Close();
            command.Dispose();

            cnn.Close();

        }

        protected void Session_OnEnd(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Connexion.aspx");
        }

        protected void Delet_user(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            String sql;
            sql = "DELETE FROM user WHERE login_user='" + Session["login"] + "'";

            command = new MySqlCommand(sql, cnn);

            command.ExecuteNonQuery();

            cnn.Close();
        }
    }
}