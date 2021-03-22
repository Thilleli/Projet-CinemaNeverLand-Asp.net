using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Text;
using System.Security.Cryptography;

namespace CinemaNerverland
{
    public static class Hasher
    {
        /// <summary>
        /// This method hashes the given text with 
        /// the SHA1CryptoServiceProvider.
        /// </summary>
        /// <param ///name="text">Text to hash</param>
        /// <returns>Hashed Value</returns>
        public static string HashString(string text)
        {
            // Create an instance of the SHA1 provider
            SHA1 sha = new SHA1CryptoServiceProvider();

            // Compute the hash 
            byte[] hashedData = sha.ComputeHash(Encoding.Unicode.GetBytes(text));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (byte b in hashedData)
            {
                // Convert each byte to Hex
                stringBuilder.Append(String.Format("{0,2:X2}", b));
            }

            // Return the hashed value
            return stringBuilder.ToString();
        }
    }
}


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
                string connetionString;
                connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";
                //connetionString = @"Server=tcp:myservertuto.database.windows.net,1433;Initial Catalog=mydbtuto;Persist Security Info=False;User ID=myadmin;Password=Admin123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

                MySqlConnection cnn = new MySqlConnection(connetionString);

                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select count(*) from user where login_user='" + InscriptionID.Text + "' ", cnn);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                MySqlCommand com = new MySqlCommand("select count(*) from user where mail_user='" + InscriptionMail.Text + "' ", cnn);
                MySqlDataAdapter sd = new MySqlDataAdapter(com);
                System.Data.DataTable datatb = new System.Data.DataTable();
                sd.Fill(datatb);
                com.ExecuteNonQuery();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ErrorMessage.Text = InscriptionID.Text+" ce login est déjà pris";
                }
                else if (datatb.Rows[0][0].ToString() == "1") 
                {
                    ErrorMessage.Text = InscriptionMail.Text + " ce mail est déjà pris";
                }
                else if(InscriptionMDP.Text != InscriptionMDPC.Text)
                {
                    ErrorMessage.Text = "Les deux mot de passe ne coresspondent pas";

                }
                else 
                {

                    connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_data ;User ID=219115_wb;Password=wasefbelhocine01*";
                    cnn = new MySqlConnection(connetionString);
                    cnn.Open();
                    
                    MySqlCommand command;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    
                    String sql = "INSERT INTO `user`(id_user,nom_user,prenom_user,age_user,mail_user,login_user,mdp_user) VALUES('', @_Nom , @_Name , @_Age ,@_Mail, @_ID , @_Password )";

                    command = new MySqlCommand(sql, cnn);

                    adapter.InsertCommand = command;

                    InscriptionMDP.Text = Hasher.HashString(InscriptionMDP.Text.Trim());//hachage du mdp en sha1
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