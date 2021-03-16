using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland
{
    public partial class Inscription : System.Web.UI.Page
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
            if (InscriptionNom.Text!="" && InscriptionName.Text!="" && InscriptionAge.Text != "" && InscriptionMail.Text != "" && InscriptionID.Text != "" && InscriptionMDP.Text != "" && InscriptionMDPC.Text != "") { 
                if(InscriptionMDP.Text != InscriptionMDPC.Text)
                {
                    Response.Write("Les deux mot de passe ne coresspondent pas ");
                }
            }
            else
            {
                Response.Write("Veuillez remplir tout les champs ");
            }
            Session["Nom"] = InscriptionID.Text;
            Response.Write(Session["Nom"]);
            /*string connetionString;
            MySqlConnection cnn;

            connetionString = @"Server=DESKTOP-ISBOFB1\SQLEXPRESS;Trusted_Connection=True;Database=demodb ;User ID=Mylogin;Password=123";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "SELECT login_user, mdp_user, nom_user, prenom_user, age_user, mail_user, id_user FROM user ";

            command = new MySqlCommand(sql, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();

            cnn.Close();*/
        }
    }
}