using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland
{
    public partial class Connexion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";
            //connetionString = @"Server=tcp:myservertuto.database.windows.net,1433;Initial Catalog=mydbtuto;Persist Security Info=False;User ID=myadmin;Password=Admin123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            MySqlConnection cnn = new MySqlConnection(connetionString);

            cnn.Open();

            //Response.Write("Connection Réussie");
            cnn.Close();
        }
        protected void send_Click(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            ConnexionMDP.Text = Hasher.HashString(ConnexionMDP.Text.Trim());//hachage du mdp en sha1
            MySqlCommand cmd = new MySqlCommand("select count(*) from user where login_user='" + connexionID.Text + "' and mdp_user='" + ConnexionMDP.Text + "' ", cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            if (dt.Rows[0][0].ToString() == "1")
            {
                ErrorMessage.Text = "Vous êtes bien connecté";
                Session["login"] = connexionID.Text;

                // Response.Write(Session["ID"]);
                // Response.Write(Session["ID"]);
                Response.Redirect("~/Profil");

            }
            else
            {
                ErrorMessage.Text = "Utilisateur introuvable!";
            }

            cnn.Close();
        }

    }
}