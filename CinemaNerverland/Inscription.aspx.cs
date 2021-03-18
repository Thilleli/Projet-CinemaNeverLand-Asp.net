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
                    ErrorMessage.Text = "Les deux mot de passe ne coresspondent pas";

                }
                else 
                {
                    string connetionString;
                    MySqlConnection cnn;

                    connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";

                    cnn = new MySqlConnection(connetionString);
                    cnn.Open();
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    String sql = "INSERT INTO `user`(id_user,nom_user,prenom_user,age_user,mail_user,login_user,mdp_user) VALUES('', @_Nom , @_Name , @_Age ,@_Mail, @_ID , @_Password )";

                    command = new MySqlCommand(sql, cnn);

                    adapter.InsertCommand = command;

                    command.Parameters.AddWithValue("@_Nom", InscriptionNom.Text);
                    command.Parameters.AddWithValue("@_Name", InscriptionName.Text);
                    command.Parameters.AddWithValue("@_Age", InscriptionAge.Text);
                    command.Parameters.AddWithValue("@_Mail", InscriptionMail.Text);
                    command.Parameters.AddWithValue("@_ID", InscriptionID.Text);
                    command.Parameters.AddWithValue("@_Password", InscriptionMDP.Text);

                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    ErrorMessage.Text = "Inscription Réussie ";
                    cnn.Close();
                }
            }
            else
            {
                ErrorMessage.Text = "Veuillez remplir tout les champs " ;
            }
        }
    }
}