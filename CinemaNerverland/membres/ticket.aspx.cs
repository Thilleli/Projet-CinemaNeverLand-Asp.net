using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace CinemaNerverland.membres
{
    public partial class ticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
                DropDownListFilms.Items.Clear();
                DropDownListFilms.Items.Add("Veuillez faire un choix");

                string connetionString;
                MySqlConnection cnn;

                connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

                cnn = new MySqlConnection(connetionString);
                cnn.Open();

                MySqlCommand command;
                MySqlDataReader dataReader;
                String sql;
                sql = "select titre_film from film";

                command = new MySqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DropDownListFilms.Items.Add(dataReader["titre_film"].ToString());
                }

                dataReader.Close();
                command.Dispose();

                
                cnn.Close();
            }
        }

        protected void send_Click(object sender, EventArgs e)
        {
           
            
            CheckBoxListDisponibiliteFilm.Items.Clear();

            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
           
            String sql, titrefilm=" ";
            int prixFilm;
            sql = "select titre_film, prix_film from film where titre_film ='" + DropDownListFilms.SelectedItem+ "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                prixFilm = dataReader.GetInt16(1);
                titrefilm = dataReader.GetValue(0).ToString();
                
                Reservation.Text= "Vous avez choisi : " + nbrPlaces.Text +" places pour " + titrefilm + "</br>";

            }
          

            dataReader.Close();
            command.Dispose();

            //-----------------2eme connexion à la bdd pour afficher les seances disponible-------------------------------
            
            MySqlCommand command2;
            MySqlDataReader dataReader2;
            String sql2;
            sql2 = "SELECT debut_seance,fin_seance,date_seance,nom_salle,prix_salle,id_seance FROM seance JOIN film ON film.id_film = seance.id_film AND film.titre_film = '" + DropDownListFilms.SelectedItem + "'" +
                 " INNER JOIN salle ON salle.id_salle=seance.id_salle AND salle.id_salle ='1' ";
            command2 = new MySqlCommand(sql2, cnn);

            dataReader2 = command2.ExecuteReader();

            while (dataReader2.Read())
            {
                CheckBoxListDisponibiliteFilm.Items.Add("Entre " +dataReader2["debut_seance"].ToString() + "h et "+dataReader2["fin_seance"].ToString()+ "h le: "+
                    dataReader2["date_seance"].ToString() + " dans la " + dataReader2["nom_salle"].ToString());

                Prix_salle.Text = dataReader2["prix_salle"].ToString();
                idSeance.Text= dataReader2["id_seance"].ToString();
            }

            dataReader2.Close();
            command2.Dispose();

            

            cnn.Close();

        }
        
        protected void Valider_Seance(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand command3;
            MySqlDataReader dataReader3;
            String sql3, selectedSeance = " ";
            int  PrixTotal, prixFilm, nbr_Places, Prxsalle;
            sql3 = "SELECT prix_salle ,prix_film FROM seance JOIN film JOIN salle ON film.id_film = seance.id_film AND film.titre_film = '" + DropDownListFilms.SelectedItem+"'" ;

            command3 = new MySqlCommand(sql3, cnn);

            dataReader3 = command3.ExecuteReader();

            while (dataReader3.Read())
            {
                selectedSeance = CheckBoxListDisponibiliteFilm.SelectedValue;
                prixFilm = dataReader3.GetInt16(1);
                nbr_Places = int.Parse(nbrPlaces.Text);
                Prxsalle = int.Parse(Prix_salle.Text);
                PrixTotal = (prixFilm+ Prxsalle) * nbr_Places;
                Prix_Total.Text = PrixTotal.ToString();



                Reservation2.Text = "<strong>Votre Réservation:</strong> <br/> Nombres de places: " + nbrPlaces.Text +
                    "<br/> Titre film: " + DropDownListFilms.SelectedItem + " </br> Séance: " + selectedSeance + "<br/> Prix total est de: " + Prix_Total.Text+ "€";


            }
            
            dataReader3.Close();
            command3.Dispose();



            cnn.Close();
            
        }
        
        protected void reservation(object sender, EventArgs e)
        {
            string connetionString;
            MySqlConnection cnn;
            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            //-------------Connexion pour récuperer id_user--------------------
            MySqlCommand cmd;
            MySqlDataReader dataReader;
            String sql0;
            sql0 = "select id_user from user where login_user='" + Session["login"] + "'";
            cmd = new MySqlCommand(sql0, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
               
                idUser.Text= dataReader.GetValue(0).ToString();

            }
            dataReader.Close();
            cmd.Dispose();


            //-------------Connexion pour enregistrer les données de reservation dans la bdd--------------------

            MySqlCommand command;
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                String sql = "INSERT INTO `reglement`(id_reglement,montant_regle,nbr_place,id_seance,id_user) VALUES('', @_montant , @_nbrPlaces , @_idSeance ,@_idUser)";

                command = new MySqlCommand(sql, cnn);
                
                adapter.InsertCommand = command;
                command.Parameters.AddWithValue("@_montant", Prix_Total.Text);
                command.Parameters.AddWithValue("@_nbrPlaces", nbrPlaces.Text);
                command.Parameters.AddWithValue("@_idSeance", idSeance.Text);
                command.Parameters.AddWithValue("@_idUser", idUser.Text);

                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                MessageValidation.Text = "<b> <div class='msgvalid'> Votre réseration a bien été effectuée, vous allez recevoir un mail de confirmation <br> Le prix total de: "+ Prix_Total.Text + "€ est à payer sur place</div></b>";
                
            
            
            cnn.Close();
            
        }

        
    }
}