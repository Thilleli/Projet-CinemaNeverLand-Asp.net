using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CinemaNerverland
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            if (TextBoxNom.Text != "" && TextBoxPrenom.Text != "" && TextBoxMail.Text != "" && TextBoxObjet.Text != "" && TextBoxMessage.Text != "")
            {
                try
                {
                    /* string ExpediteurMail, DistinataireMail, Sujet, Message, NomPrenom;

                     ExpediteurMail = TextBoxMail.Text;
                     NomPrenom = DropDownListCivilié.SelectedItem.Text + " " + TextBoxNom.Text + " " + TextBoxPrenom.Text;
                     DistinataireMail = "lilybelhocine006@gmail.com";
                     Sujet = "Formulaire de contact";
                     Message = "Le nom: " + NomPrenom + Environment.NewLine + "Le mail: " + TextBoxMail.Text
                         + Environment.NewLine + "Objet du Message: " + TextBoxObjet.Text + Environment.NewLine + "Le message: " + TextBoxMessage.Text;

                     MailMessage Mail = new MailMessage(ExpediteurMail, DistinataireMail, Sujet, Message);
                     SmtpClient MonSmtpClient = new SmtpClient("smtp.gmaim.com", 587);
                     MonSmtpClient.EnableSsl = true;
                     MonSmtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                     MonSmtpClient.Credentials = new System.Net.NetworkCredential("wasefbelhocine@gmail.com", "wasefbelhocine01*");
                     MonSmtpClient.Send(Mail);*/


                    LabelSendnoOk.Text = " ";
                    LabelSendOk.Text = "Nous avons bien reçue votre message, nous allons vous répondre très prochainement! ";

                    TextBoxNom.Text = " ";
                    TextBoxPrenom.Text = " ";
                    TextBoxMail.Text = " ";
                    TextBoxObjet.Text = " ";
                    TextBoxMessage.Text = " ";
                }
                catch
                {
                    LabelSendnoOk.Text = "Une erreur s'est produite, votre message n'a pas pu etre envoyé! ";
                    LabelSendOk.Text = " ";
                }
            }
            else
            {
                LabelSendnoOk.Text = "Veuillez remplir tous les champs! ";

                LabelSendOk.Text = " ";

            }
        }

    }
}