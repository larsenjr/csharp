using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MySQL_Student_CRUD
{   // Setter Layout på Windows Form til Materialskin.
    public partial class StudentWIndow : MaterialSkin.Controls.MaterialForm
    {
        // Serverinfo for å åpne database. Inneholder brukernavn, database, og hvor databasen er lokalisert
        private string connectionString = @"Server=localhost;Database=studentdb;UID=hehe;";

        private int studentID;

        public StudentWIndow()
        {
            InitializeComponent();
        }

        // Void for Knappen "btnSave". Denne lagrer dataen ved hjelp av stored procedures.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    // Åpner databasen
                    mysqlCon.Open();
                    // Angir hvilken "Stored procedures" som skal brukes.
                    MySqlCommand mySqlCmd = new MySqlCommand("StudentAddOrEdit", mysqlCon);
                    // Gir beskjed til applikasjonen at det er en stored procedure som brukes.
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    // Parametere som sier hvilke procedures som skal legges til.
                    mySqlCmd.Parameters.AddWithValue("_StudentID", studentID);
                    mySqlCmd.Parameters.AddWithValue("_Fornavn", txtFornavn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Etternavn", txtEtternavn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Adresse", txtAdresse.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Telefonnummer", txtTlf.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Postnummer", txtPostnummer.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Fodt", dtpFodt.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Kjonn", cmboxKjonn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Tilleggsinfo", txtTillegg.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Fylke", cmboxFylke.Text.Trim());
                    // Utfører SQL kommandoen.
                    mySqlCmd.ExecuteNonQuery();
                    // Viser tekstboks som sier at linje er lagt til.
                    MessageBox.Show("Studenten er lagt til i database");
                    // Void for å slette boksene etter at man har "submittet" til databasen.
                    Clear();
                    // Void som brukes for å liste opp hvilken kolonner som vises i DataGridView.
                    GridFill();
                }
            }

            // Skriver ut "error message" slik at det er nyttig for den som feilsøker koden.
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Du skrev inn bokstaver i en av kolonnene der det skal være tall \n" + ex.GetType());
            }

            // Hindrer å skrive inn tekst i en int value.
            catch (FormatException ex)
            {
                Console.WriteLine("Du la inn tekst i en tallkolonne" + ex.GetType());
            }

            // Generell exception for variablen ex.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        // Void som viser hva databasen inneholder og legger det til i DataGridView.
        private void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                // Åpner databasen
                mysqlCon.Open();
                // Angir hvilken "Stored procedures" som skal brukes.
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("StudentViewAll", mysqlCon);
                // Gir beskjed til applikasjonen at det er en stored procedure som brukes.
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                // Tranformerer informasjonen fra "stored procedures" til dtblStudent.
                DataTable dtblStudent = new DataTable();
                sqlDa.Fill(dtblStudent);
                // Skriver ut informasjonen til DataGridView.
                dgvStudent.DataSource = dtblStudent;
                // Fjerner første kolonne slik at denne ikke vises i datagridview.
                dgvStudent.Columns[0].Visible = false;
                // Setter størrrelse på kolonner
                dgvStudent.Columns[4].Width = 135;
                dgvStudent.Columns[5].Width = 125;
                dgvStudent.Columns[6].Width = 65;
                dgvStudent.Columns[7].Width = 75;
                dgvStudent.Columns[8].Width = 110;
            }
        }

        /* Når applikasjonen laster viser den tomme bokser, samtidig som
         * den viser hvilke informasjon som er i databasen fra før i datagridview.
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        // Void som slettet tekst fra boksene til
        private void Clear()
        {
            txtFornavn.Clear();
            txtEtternavn.Clear();
            txtAdresse.Clear();
            txtTlf.Clear();
            txtPostnummer.Clear();
            dtpFodt.ResetText();
            cmboxKjonn.ResetText();
            txtTillegg.Clear();
            cmboxFylke.ResetText();
            txtSearch.Clear();
            studentID = 0;
            // Byttet om teksten til btnSave til å si "Save".
            btnSave.Text = "Save";
            // Gjør så "delete" knappen ikke er tilgjengelig når det ikke er noe informasjon i boksene.
            btnDelete.Enabled = false;
        }

        // Void for at hvis man dobbeltklikker på DataGridView så kommer informasjonen i boksene.
        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            // Sier at hvis DataGridView er -1, så sett inn value.
            if (dgvStudent.CurrentRow.Index != -1)
            {
                // Setter cellene til at de kan bli endret eller slettet
                var cells = dgvStudent.CurrentRow.Cells;
                txtFornavn.Text = cells[1].Value.ToString();
                txtEtternavn.Text = cells[2].Value.ToString();
                txtAdresse.Text = cells[3].Value.ToString();
                txtTlf.Text = cells[4].Value.ToString();
                txtPostnummer.Text = cells[5].Value.ToString();

                var aarTxt = cells[6].Value.ToString();
                // Setter dateTime til dtpFodt slik at det konverteres til kalender / år.
                dtpFodt.Value = new DateTime(int.Parse(aarTxt), 1, 1);
                cmboxKjonn.Text = cells[7].Value.ToString();
                txtTillegg.Text = cells[8].Value.ToString();
                cmboxFylke.Text = cells[9].Value.ToString();
                studentID = Convert.ToInt32(cells[0].Value.ToString());
                // Bytter om teksten til "Update" isteden for save når man dobbeltklikker
                btnSave.Text = "Update";
                // Setter "delete" knapp til aktiv.
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    // Åpner databasen
                    mysqlCon.Open();
                    // Angir hvilken "Stored procedures" som skal brukes.
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("StudentSearchByValue", mysqlCon);
                    // Gir beskjed til applikasjonen at det er en stored procedure som brukes.
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    // Eksporterer tekst fra "SearchValue" så den kan brukes i procedure.
                    sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                    DataTable dtblStudent = new DataTable();
                    // Fyller inn oppdatert informasjon i DataGridView.
                    sqlDa.Fill(dtblStudent);
                    dgvStudent.DataSource = dtblStudent;
                    // Setter kolonne 0 til skjult.
                    dgvStudent.Columns[0].Visible = false;
                }
            }

            // Gir beskjed om hvilke error som kommer opp hvis det er noen.
            catch (Exception btn_Search)
            {
                // Skriver ut "error message" slik at det er nyttig for den som feilsøker koden.
                MessageBox.Show(btn_Search.Message.ToString());
            }
        }

        // Void for å slette informasjon i boksene.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Bruker funksjon "clear" for å slette informasjon i boksene.
            Clear();
        }

        // Void for delete knapp
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    // Åpner databasen
                    mysqlCon.Open();
                    // Angir hvilken "Stored procedures" som skal brukes.
                    MySqlCommand mySqlCmd = new MySqlCommand("StudentDeleteById", mysqlCon);
                    // Gir beskjed til applikasjonen at det er en stored procedure som brukes.
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    // Tar ID informasjonen og eksporterer det til "Stored procedure".
                    mySqlCmd.Parameters.AddWithValue("_StudentID", studentID);
                    // Utfører kommandoen.
                    mySqlCmd.ExecuteNonQuery();
                    // Viser en tekstboks som sier "Studenten er fjernet fra databasen."
                    MessageBox.Show("Studenten er fjernet fra databasen");
                    // Sletter informasjonen fra cellene
                    Clear();
                    // Oppdaterer DataGridView
                    GridFill();
                }
            }
            // Gir beskjed om hvilke error som kommer opp hvis det er noen.
            catch (Exception btn_Delete)
            {
                // Skriver ut "error message" slik at det er nyttig for den som feilsøker koden.
                MessageBox.Show(btn_Delete.Message.ToString());
            }
        }

        // Sier at hvis man trykker "Enter" på tastaturet skal den trykke på knappen "btnSearch"
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        // Trykker "enter" som sier at man skal trykke på knappen "btnSave".
        private void txtTillegg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(this, new EventArgs());
            }
        }

        private void cmboxFylke_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFornavn_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAlder_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void txtPostnummer_TextChanged(object sender, EventArgs e)
        {
        }
    }
}