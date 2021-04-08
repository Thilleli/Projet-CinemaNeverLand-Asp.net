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
            DropDownListFilms.Items.Clear();

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

        protected void send_Click(object sender, EventArgs e)
        {

            string connetionString;
            MySqlConnection cnn;

            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";

            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql;
            sql = "select titre_film from film where titre_film ='" + DropDownListFilms.SelectedItem+ "'";

            command = new MySqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                filmSelected.Text= dataReader["titre_film"].ToString();


            }

            dataReader.Close();
            command.Dispose();

            cnn.Close();



            /*string connetionString;
            connetionString = @"Data Source=mysql-cinemaneverland.alwaysdata.net;Database=cinemaneverland_bdd ;User ID=219115_wb;Password=wasefbelhocine01*";
            //connetionString = @"Server=tcp:myservertuto.database.windows.net,1433;Initial Catalog=mydbtuto;Persist Security Info=False;User ID=myadmin;Password=Admin123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            MySqlConnection cnn = new MySqlConnection(connetionString);

            cnn.Open();

            MySqlCommand cmd = new MySqlCommand("select count(*) from seance where date_seance='" + Calendar1 + "' ", cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            Response.Write(Calendar1);
            cmd.ExecuteNonQuery();
            if (dt.Rows[0][0].ToString() !="")
            {
                Response.Write(dt.Rows[0][0].ToString());
            }
            //Response.Write("Connection Réussie");
            cnn.Close();*/

        }


    }
}