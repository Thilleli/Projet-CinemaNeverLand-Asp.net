using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland
{
    public partial class Contact : Page
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
            String sql, NomCinema = " ", VilleCinema = " ", AdCinema = " ", telcinema = " ";
            sql = "select nom_cinema,ville_cinema,ad_cinema,telephone_cinema from cinema";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                NomCinema =  dataReader.GetValue(0) + "</br>";
                VilleCinema = dataReader.GetValue(1) + "</br>";
                AdCinema = dataReader.GetValue(2) + "</br>";
                telcinema =dataReader.GetValue(3) + "</br>";
            }
            NomCin.Text = NomCinema.ToString();
            telCin.Text = telcinema.ToString();
            addCin.Text = AdCinema.ToString();
            villecin.Text = VilleCinema.ToString();



            dataReader.Close();
            command.Dispose();

            cnn.Close();
        }
        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxNom.Text != "" && TextBoxPrenom.Text != "" && TextBoxMail.Text != "" && TextBoxObjet.Text != "" && TextBoxMessage.Text != "")
            {
                string connetionString;
                connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";
                MySqlConnection cnn = new MySqlConnection(connetionString);

                cnn.Open();
                MySqlCommand command;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                String sql = "INSERT INTO `messages_users`(id_msg,nom_user,prenom_user,mail_user,objet_msg, message_user) VALUES('', @_nom , @_prenom ,@_Mail, @_objet_msg , @_message )";

                command = new MySqlCommand(sql, cnn);

                adapter.InsertCommand = command;

                command.Parameters.AddWithValue("@_nom", TextBoxNom.Text);
                command.Parameters.AddWithValue("@_prenom", TextBoxPrenom.Text);
                command.Parameters.AddWithValue("@_Mail", TextBoxMail.Text);
                command.Parameters.AddWithValue("@_objet_msg", TextBoxObjet.Text);
                command.Parameters.AddWithValue("@_message", TextBoxMessage.Text);

                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                LabelSendnoOk.Text = " ";
                LabelSendOk.Text = "Nous avons bien reçue votre message, nous allons vous répondre très prochainement! ";

                TextBoxNom.Text = " ";
                TextBoxPrenom.Text = " ";
                TextBoxMail.Text = " ";
                TextBoxObjet.Text = " ";
                TextBoxMessage.Text = " ";

                cnn.Close();
            }
            else
            {
                LabelSendnoOk.Text = "Veuillez remplir tous les champs! ";

            }
        }

    }
}