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
                NomCinema = dataReader.GetValue(0) + "</br>";
                VilleCinema = dataReader.GetValue(1) + "</br>";
                AdCinema = dataReader.GetValue(2) + "</br>";
                telcinema = dataReader.GetValue(3) + "</br>";
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
                /*string utilisateur, password, serveur;

                

                MailMessage email = new MailMessage();

                utilisateur = ConfigurationSettings.AppSettings["SmtpUtilisateur"];
                password = ConfigurationSettings.AppSettings["SmtpPassword"];
                serveur = ConfigurationSettings.AppSettings["SmtpServeur"];
  
                email.From = TextBoxMail.Text;
                email.To = "lilybelhocine006@gmail.com";
                email.Subject = TextBoxObjet.Text;
                email.Body = TextBoxMessage.Text;

                //email.Priority = MailPriority.High;
                SmtpMail.SmtpServer = "gmail.com";

                email.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                email.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", utilisateur);
                email.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", password);
                SmtpMail.SmtpServer = serveur;
                try
                {
                    SmtpMail.Send(email);
                    LabelSendnoOk.Text = " ";
                    LabelSendOk.Text = "Nous avons bien reçue votre message, nous allons vous répondre très prochainement! ";

                    TextBoxNom.Text = " ";
                    TextBoxPrenom.Text = " ";
                    TextBoxMail.Text = " ";
                    TextBoxObjet.Text = " ";
                    TextBoxMessage.Text = " ";

                }
                catch (Exception ex)
                {
                    LabelSendnoOk.Text = ex.Message;
                    /*LabelSendnoOk.Text = "Une erreur s'est produite, votre message n'a pas pu etre envoyé! ";
                    LabelSendOk.Text = " ";
                }*/
                LabelSendnoOk.Text = " ";
                LabelSendOk.Text = "Nous avons bien reçue votre message, nous allons vous répondre très prochainement! ";

                TextBoxNom.Text = " ";
                TextBoxPrenom.Text = " ";
                TextBoxMail.Text = " ";
                TextBoxObjet.Text = " ";
                TextBoxMessage.Text = " ";


            }
            else
            {
                LabelSendnoOk.Text = "Veuillez remplir tous les champs! ";

                LabelSendOk.Text = " ";

            }
        }

    }
}