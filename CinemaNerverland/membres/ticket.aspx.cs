﻿using System;
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
           
            String sql;
            int prixFilm, nombrePlaces, PrixTotal;
            sql = "select titre_film, prix_film from film where titre_film ='" + DropDownListFilms.SelectedItem+ "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                prixFilm = dataReader.GetInt16(1);
                nombrePlaces = int.Parse(nbrPlaces.Text);
                PrixTotal = prixFilm * nombrePlaces;
                filmSelected.Text= "Vous avez choisi : " + nbrPlaces.Text +" places pour " + dataReader.GetValue(0).ToString()+ "</br> " +
                    "Le prix total est: "+ PrixTotal;
                
            }

            dataReader.Close();
            command.Dispose();

            //-----------------2eme connexion à la bdd -------------------------------
            
            MySqlCommand command2;
            MySqlDataReader dataReader2;
            String sql2;
            sql2 = "SELECT debut_seance,fin_seance,date_seance,nom_salle FROM seance JOIN film ON film.id_film = seance.id_film AND film.titre_film = '"+ DropDownListFilms.SelectedItem + "'" +
                 " INNER JOIN salle ON salle.id_salle=seance.id_salle AND salle.id_salle ='1' ";
            command2 = new MySqlCommand(sql2, cnn);

            dataReader2 = command2.ExecuteReader();

            while (dataReader2.Read())
            {
                CheckBoxListDisponibiliteFilm.Items.Add(" Entre " +dataReader2["debut_seance"].ToString() + "h et "+dataReader2["fin_seance"].ToString()+ "h le: "+
                    dataReader2["date_seance"].ToString() + " dans la " + dataReader2["nom_salle"].ToString());
            }

            dataReader2.Close();
            command2.Dispose();

            cnn.Close();

        }

     
    }
}