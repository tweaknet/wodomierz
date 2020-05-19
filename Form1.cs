using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace wodomierz
{
    public partial class Form1 : Form 
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;
        List<Klient> klient = new List<Klient>();
        Faktura faktura = new Faktura();
        public Form1()
        {
            InitializeComponent();
            tabControl1.Hide();
            pWynikLogowania.Show();
            gridPozycjiFaktury.Hide();
            grPozFaktur.Hide();
            grWyboruKlientaDoFaktury.Hide();
            grupaWybWodFakt.Hide();
            grDodajStanWod.Hide();
            grWybierzKlientaWod.Hide();
            grupaDodajKlient.Hide();
            grCennik.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            haslo.PasswordChar = '*';
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loguj();
        }

        private void ustawianieWilekosciTaba()
        {
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 1, 0);
            tabControl1.Show();
            ileKartLb.Text = tabControl1.TabCount.ToString() + " : " + tabControl1.Size.Width;

        }
        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            haslo.Show();
            haslo.Text = "";
            textBox1.Show();
            textBox1.Text = "";
            pLogin.Show();
            pHaslo.Show();
            button1.Show();
            //dzialanie();
            tabControl1.Hide();
            pWynikLogowania.Hide();
            bool pozwolLogowac = false;
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Loguj();
        }

        public void Loguj()
        {
            try
            {
                bool pozwolLogowac = false;
                bool pokazTabUstawienia = false;
                SqlConnection polaczenie = new SqlConnection(connectionString);
                polaczenie.Open();
                SqlCommand komendaSQL = polaczenie.CreateCommand();
                komendaSQL.CommandText = "SELECT count(EmployeeID) as id,czyAdmin,EmployeeID FROM Employee where aktywny = 1 and Login = '"
                    + textBox1.Text.ToString() + "' and Password = '" + haslo.Text.ToString()+ "' group by czyAdmin,EmployeeID";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();

                while (thisReader.Read())
                {
                    if(thisReader["id"].ToString() == "1") { pozwolLogowac = true; };
                    if(thisReader["czyAdmin"].ToString() == "True") { pokazTabUstawienia = true; };
                    EmployeeID = thisReader["EmployeeID"].ToString();
                }
                thisReader.Close();
                polaczenie.Close();
                if (pozwolLogowac)
                {
                    testToolStripMenuItem.Text = "Zalogowano: " + textBox1.Text + ". Wyloguj.";
                    pWynikLogowania.Text = "zalogowano: " + textBox1.Text;
                pWynikLogowania.Show();
                haslo.Hide();
                textBox1.Hide();
                pLogin.Hide();
                pHaslo.Hide();
                button1.Hide();
                    if (pokazTabUstawienia == false)
                    {
                        tabControl1.TabPages.Remove(tabPage5);
                    }

                    ustawianieWilekosciTaba();
                }
            else
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testToolStripMenuItem.Text == "Wpisz login i hasło aby kontynuować")
            {
                Loguj();
            }
            else
            {
                haslo.Show();
                haslo.Text = "";
                textBox1.Show();
                textBox1.Text = "";
                pLogin.Show();
                pHaslo.Show();
                button1.Show();
                tabControl1.Hide();
                pWynikLogowania.Hide();
                bool pozwolLogowac = false;
                testToolStripMenuItem.Text = "Wpisz login i hasło aby kontynuować";
                if (tabControl1.TabPages.Count == 4) { tabControl1.TabPages.Add(tabPage5); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'logowanie.pracownik' . Możesz go przenieść lub usunąć.
            //this.pracownikTableAdapter.Fill(this.logowanie.pracownik);
            PopulatePositionComboBox();
            PopulateDataGridView();
            GridCennik();
            GridFaktury();
            GridWodomierz();
            GridKlient();
        }
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Employee", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                GridPracownicy.DataSource = dtbl;
            }
        }

        void GridCennik()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM cennik", sqlCon);
                DataTable cennik = new DataTable();
                sqlDa.Fill(cennik);
                gridCennik.DataSource = cennik;
            }
        }

        void GridFaktury()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id, idKlient, nrFaktury, imie, nazwisko, dataWystawienia, formaPlatnosci,  nazwaFirmy,  " +
                    "terminPlatnosci, netto, adresKlient, nazwaBanku, telefon, symbolVat FROM faktura", sqlCon);
                DataTable faktury = new DataTable();
                sqlDa.Fill(faktury);
                gridFaktury.DataSource = faktury;
                int nRowIndexGF = gridFaktury.Rows.Count - 1;
                gridFaktury.Rows[nRowIndexGF].Selected = true;
                gridFaktury.CurrentCell = gridFaktury.Rows[nRowIndexGF].Cells[3];
            }
        }

        //void GridPozycjiFaktury(string nrFaktury)
        //{
        //    //MessageBox.Show(nrFaktury);
        //    using (SqlConnection sqlCon = new SqlConnection(connectionString))
        //    {
        //        sqlCon.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT id,nrFaktury,telefon FROM faktura where nrFaktury = " + nrFaktury, sqlCon);
        //        DataTable pozFaktury = new DataTable();
        //        sqlDa.Fill(pozFaktury);
        //        gridPozycjiFaktury.DataSource = pozFaktury;
        //    }
        //}

        void PopulatePositionComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Position", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //cbxPosition.ValueMember = "PositionID";
                //cbxPosition.DisplayMember = "Position";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                //cbxPosition.DataSource = dtbl;
            }
        }
        private void gridPracownicy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (GridPracownicy.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = GridPracownicy.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtEmployeeID"].Value == DBNull.Value)//Insert
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", 0);
                    else//update
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(dgvRow.Cells["txtEmployeeID"].Value));
                    sqlCmd.Parameters.AddWithValue("@Name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                    //sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(dgvRow.Cells["cbxPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxPosition"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@PositionID", "0");
                    sqlCmd.Parameters.AddWithValue("@Office", dgvRow.Cells["txtOffice"].Value == DBNull.Value ? "" : dgvRow.Cells["txtOffice"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Password", Convert.ToInt32(dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtPassword"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@Login", dgvRow.Cells["txtlogin"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlogin"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@czyAdmin", dgvRow.Cells["txtczyAdmin"].Value == DBNull.Value ? false : dgvRow.Cells["txtczyAdmin"].Value);
                    sqlCmd.Parameters.AddWithValue("@aktywny", dgvRow.Cells["txtaktywny"].Value == DBNull.Value ? false : dgvRow.Cells["txtaktywny"].Value);
                    sqlCmd.ExecuteNonQuery();
                    PopulateDataGridView();
                    GridCennik();
                }
            }
        }

        private void gridPracownicy_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly;
            if (GridPracownicy.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress += AllowNumbersOnly;
            }
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void gridPracownicy_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (GridPracownicy.CurrentRow.Cells["txtEmployeeID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("EmployeeDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(GridPracownicy.CurrentRow.Cells["txtEmployeeID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 4) {tabControl1.TabPages.Add(tabPage5); }  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage5);
        }
        
        private void gridFaktury_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PoprawFakture();
        }

        private void gridCennik_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCennik.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = gridCennik.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("CennikDodajEdytuj", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtEmployeeID"].Value == DBNull.Value)//Insert
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", 0);
                    else//update
                        sqlCmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(dgvRow.Cells["txtEmployeeID"].Value));
                    sqlCmd.Parameters.AddWithValue("@Name", dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString());
                    //sqlCmd.Parameters.AddWithValue("@PositionID", Convert.ToInt32(dgvRow.Cells["cbxPosition"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxPosition"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@PositionID", "0");
                    sqlCmd.Parameters.AddWithValue("@Office", dgvRow.Cells["txtOffice"].Value == DBNull.Value ? "" : dgvRow.Cells["txtOffice"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Password", Convert.ToInt32(dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtPassword"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@Login", dgvRow.Cells["txtlogin"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlogin"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@czyAdmin", dgvRow.Cells["txtczyAdmin"].Value == DBNull.Value ? false : dgvRow.Cells["txtczyAdmin"].Value);
                    sqlCmd.Parameters.AddWithValue("@aktywny", dgvRow.Cells["txtaktywny"].Value == DBNull.Value ? false : dgvRow.Cells["txtaktywny"].Value);
                    sqlCmd.ExecuteNonQuery();
                    GridCennik();
                }
            }
        }

        private void btZapiszFakture_Click(object sender, EventArgs e)
        {
            if (nowyInsert)
            {
                nrNowejFaktury = "2020/0000" + faktura.PobierzNowyNrFaktury();
                InsertFaktura(nrNowejFaktury);
            }
            else
            {
                //MessageBox.Show(nrTejFaktury);
                //nrFaktury = gridFaktury.SelectedRows[0].Cells["nrFaktury"].Value.ToString();
                Faktura.UpdateFaktury(poleNrKlienta.Text,poleFormaPlatnosci.Text.ToString(), nrTejFaktury, wyborTerminu.Value
                    , Convert.ToDecimal(poleNetto.Text), Convert.ToInt32(poleStawkaVat.SelectedValue), EmployeeID, toImie, lbAdresKlienta.Text, lbNazwaBanku.Text
                    , tonazwisko, lbNazwaFirmy.Text, lbTelefon.Text);
            }
            ZapiszFakture();
            GridFaktury();
            GridWodomierz();
        }


        private void InsertFaktura(string nrNowejFaktury)
        {//nrFaktury = "5";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("FakturaDodaj", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                
                sqlCmd.Parameters.AddWithValue("@idKlient", poleNrKlienta.Text);
                sqlCmd.Parameters.AddWithValue("@adresKlient", lbAdresKlienta.Text.Length == 0 ? "" : lbAdresKlienta.Text);
                sqlCmd.Parameters.AddWithValue("@dataWystawienia", DateTime.Now);
                sqlCmd.Parameters.AddWithValue("@formaPlatnosci", poleFormaPlatnosci.Text);
                sqlCmd.Parameters.AddWithValue("@imie", toImie);
                sqlCmd.Parameters.AddWithValue("@naleznosci", Convert.ToDecimal(0));
                sqlCmd.Parameters.AddWithValue("@nazwaBanku", lbNazwaBanku.Text.Length == 0 ? "" : lbNazwaBanku.Text);
                sqlCmd.Parameters.AddWithValue("@nazwaFirmy", lbNazwaFirmy.Text.Length == 0 ? "" : lbNazwaFirmy.Text);
                sqlCmd.Parameters.AddWithValue("@nazwisko", tonazwisko);
                sqlCmd.Parameters.AddWithValue("@nrFaktury", nrNowejFaktury);
                sqlCmd.Parameters.AddWithValue("@telefon", lbTelefon.Text.Length == 0 ? "" : lbTelefon.Text);
                sqlCmd.Parameters.AddWithValue("@terminPlatnosci", wyborTerminu.Value);
                sqlCmd.Parameters.AddWithValue("@netto", poleNetto.Text.Length == 0 ? Convert.ToDecimal(0) : Convert.ToDecimal(poleNetto.Text));
                sqlCmd.Parameters.AddWithValue("@symbolVat", Convert.ToInt32(poleStawkaVat.SelectedValue));
                sqlCmd.Parameters.AddWithValue("@idPrac", EmployeeID);
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();dataGridView1.SelectedRows[0].Cells["nazwa2"].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells["nazwaFirmy1"].Value.ToString();
                //GridCennik();
                SqlCommand sqlupwod = new SqlCommand("OznaczJakoRozliczone", sqlCon);
                sqlupwod.CommandType = CommandType.StoredProcedure;
                sqlupwod.Parameters.AddWithValue("@nrFaktury", nrNowejFaktury);
                sqlupwod.Parameters.AddWithValue("@idKlient", Convert.ToInt32(poleNrKlienta.Text));
                sqlupwod.Parameters.AddWithValue("@idWodomierz", Convert.ToInt32(poleNrWodomierza.Text));
                sqlupwod.ExecuteNonQuery();
            }
            //MessageBox.Show("inseert");
            //MessageBox.Show(EmployeeID);
        }
        private void btWrocFaktura_Click(object sender, EventArgs e)
        {
            PokazButtonNaNaleznosci();
            gridPozycjiFaktury.Hide();
            GridFaktury();
            gridFaktury.Show();
            grPozFaktur.Hide();
        }
        bool nowyInsert;
        private string EmployeeID;
        private string nrNowejFaktury;
        private void btDodajFakture_Click(object sender, EventArgs e)
        {
            BindData();
            DodawanieFaktury();
            nowyInsert = true;
            CzyscPolaFaktury();
            pozwolZmieniacTaby = true;
        }
        private void DodawanieFaktury()
        {
            gridFaktury.Hide();
            UkryjButtonNaNaleznosci();
            grPozFaktur.Show();
            PobierzAktualnaStawkeVat();
        }
        private void CzyscPolaFaktury()
        {
            poleNrKlienta.Text = "";
            poleFormaPlatnosci.Text = "Gotówka";
            poleIlosc.Text = "";
            poleNetto.Text = "";
            poleNrWodomierza.Text = "";
            poleStawkaVat.Text = symbolVat.ToString();
            wyborTerminu.Value = DateTime.Now.AddDays(14);
            lbNazwaKlienta.Text = "";
            lbAdresKlienta.Text = "";
            lbNazwaBanku.Text = "";
            lbTelefon.Text = "";
            lbNazwaFirmy.Text = "";
        }
        private void ZapiszFakture()
        {
            //zapis do bazy
            //ukrycie
            grPozFaktur.Hide();
            gridPozycjiFaktury.Hide();
            //pokazanie
            gridFaktury.Show();
            PokazButtonNaNaleznosci();

        }
        private void PokazButtonNaNaleznosci()
        {
            btDodajFakture.Show();
            btPoprawFakture.Show();
            btUsunFakture.Show();
            btFiltr.Show();
            dataFiltra.Show();
        }
        private void UkryjButtonNaNaleznosci()
        {
            btDodajFakture.Hide();
            btPoprawFakture.Hide();
            btUsunFakture.Hide();
            btFiltr.Hide();
            dataFiltra.Hide();
        }

        private void btUsunFakture_Click(object sender, EventArgs e)
        {
            UsunFakture();
            GridWodomierz();
        }
        private void UsunFakture()
        {
            if (gridFaktury.CurrentRow.Cells["nrFaktury"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd2 = new SqlCommand("cofnijRozliczenieStWod", sqlCon);
                        sqlCmd2.CommandType = CommandType.StoredProcedure;
                        sqlCmd2.Parameters.AddWithValue("@nrfaktury", gridFaktury.CurrentRow.Cells["nrFaktury"].Value);
                        sqlCmd2.ExecuteNonQuery();
                        SqlCommand sqlCmd = new SqlCommand("usunFakture", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@nrfaktury", gridFaktury.CurrentRow.Cells["nrFaktury"].Value);
                        sqlCmd.ExecuteNonQuery();
                        
                        GridFaktury();
                    }
                }
                else
                    GridFaktury();
            }
            else
                MessageBox.Show("123Test2");
        }
        public decimal cena;
         public decimal PobierzAktualnaStawkeZaWode() {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                DateTime dzis = DateTime.Today;
                //MessageBox.Show(dzis.ToString("yyyy-MM-dd"));
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("select netto from cennikaktualny", sqlCon); 
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader thisReader = sqlCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    cena = Convert.ToDecimal(thisReader["netto"].ToString());
                }
                thisReader.Close();
            }
            return cena;
        }       
        public int symbolVat;
        public decimal PobierzAktualnaStawkeVat()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("select symbolVat from vataktualny", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataReader thisReader = sqlCmd.ExecuteReader();

                while (thisReader.Read())
                {
                    symbolVat = Convert.ToInt32(thisReader["symbolVat"].ToString());
                }
                thisReader.Close();
            }
            return symbolVat;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if(poleIlosc.Text == "")
            {
                PobierzAktualnaStawkeZaWode();
                Faktura.ObliczZuzycieWody(poleNrKlienta.Text, poleNrWodomierza.Text);
                if(Faktura.tenWynik == 0)
                {
                    MessageBox.Show("Klient nie posiada nierozliczonych wpisów");
                }
                else
                {
                poleIlosc.Text = Faktura.tenWynik.ToString();// "21";//TODO obliczać zużycie wody
                poleNetto.Text = Convert.ToString(Convert.ToDecimal(poleIlosc.Text) * cena);
                }

            }
            else
            {
                PobierzAktualnaStawkeZaWode();
                poleNetto.Text = Convert.ToString(Convert.ToDecimal(poleIlosc.Text) * cena);
            }

        }

        private void btPoprawFakture_Click(object sender, EventArgs e)
        {
            PoprawFakture();
            BindData();
        }
        string nrTejFaktury;
        public void PoprawFakture()
        {
            string nrFaktury;
            UkryjButtonNaNaleznosci();
            gridPozycjiFaktury.Show();
            gridFaktury.Hide();
            nowyInsert = false;
            nrFaktury = gridFaktury.SelectedRows[0].Cells["nrFaktury"].Value.ToString();
            poleNetto.Text = gridFaktury.SelectedRows[0].Cells["nettoN"].Value.ToString();
            poleNrKlienta.Text = gridFaktury.SelectedRows[0].Cells["idklient"].Value.ToString();
            poleNrWodomierza.Text = "12";
            wyborTerminu.Value = Convert.ToDateTime(gridFaktury.SelectedRows[0].Cells["terminPlatnosciN"].Value);
            poleFormaPlatnosci.Text = gridFaktury.SelectedRows[0].Cells["formaPlatnosciN"].Value.ToString();
            poleStawkaVat.Text = gridFaktury.SelectedRows[0].Cells["symbolVatN"].Value.ToString();
            grPozFaktur.Text = "Dane faktury nr: " + nrFaktury;
            lbNazwaKlienta.Text = gridFaktury.SelectedRows[0].Cells["imieN"].Value.ToString() + ' ' + gridFaktury.SelectedRows[0].Cells["nazwiskoN"].Value.ToString();
            lbNazwaFirmy.Text = gridFaktury.SelectedRows[0].Cells["nazwaFirmyN"].Value.ToString();
            lbAdresKlienta.Text = gridFaktury.SelectedRows[0].Cells["adresklientN"].Value.ToString();
            lbNazwaBanku.Text = gridFaktury.SelectedRows[0].Cells["nazwaBankuN"].Value.ToString();
            lbTelefon.Text = gridFaktury.SelectedRows[0].Cells["telefonN"].Value.ToString();
            grPozFaktur.Show();
            //MessageBox.Show(nrFaktury.ToString());
            nrTejFaktury = nrFaktury;
        }
         void GridWyborKlientaDOFaktury()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlklient = new SqlDataAdapter("SELECT id, idKlient, imie + ' ' + nazwisko AS nazwa, imie, nazwisko, nazwaFirmy, adres, telefon FROM klient", sqlCon);
                DataTable klient = new DataTable();
                sqlklient.Fill(klient);
                dataGridView1.DataSource = klient;
                int nRowIndex = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[nRowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[nRowIndex].Cells[2];
            }
        }

        private void btWybierKlientaDoFaktury_Click(object sender, EventArgs e)
        {
            GridWyborKlientaDOFaktury();
            grWyboruKlientaDoFaktury.Show();
        }

        private void btWrocWyborKlientaDoFaktury_Click(object sender, EventArgs e)
        {
            grWyboruKlientaDoFaktury.Hide();
            lbAdresKlienta.Text = "";
            lbNazwaBanku.Text = "";
            lbTelefon.Text = "";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UstawienieNrKlientaDoFaktury();
        }
        string toImie;
        string tonazwisko;
        string idKlienta; //globalne pole z idklient można używać
        private void UstawienieNrKlientaDoFaktury()
        {
            idKlienta = dataGridView1.SelectedRows[0].Cells["idklient2"].Value.ToString();
            string adresKlienta = dataGridView1.SelectedRows[0].Cells["adres1"].Value.ToString();
            //string nazwaBanku = dataGridView1.SelectedRows[0].Cells["nazwa2"].Value.ToString();
            string telefon = dataGridView1.SelectedRows[0].Cells["telefon1"].Value.ToString();

            poleNrKlienta.Text = idKlienta;
            grWyboruKlientaDoFaktury.Hide();
            lbNazwaKlienta.Text = dataGridView1.SelectedRows[0].Cells["nazwa2"].Value.ToString();
            lbAdresKlienta.Text = adresKlienta;
            lbNazwaBanku.Text = "nazwaBanku";
            lbTelefon.Text = telefon;
            lbNazwaFirmy.Text = dataGridView1.SelectedRows[0].Cells["nazwaFirmy1"].Value.ToString();
            toImie = dataGridView1.SelectedRows[0].Cells["imie1"].Value.ToString();
            tonazwisko = dataGridView1.SelectedRows[0].Cells["nazwisko2"].Value.ToString();
        }

        private void btWybierzKlientaDoFaktury_Click(object sender, EventArgs e)
        {
            UstawienieNrKlientaDoFaktury();
        }

        void GridWodomierz()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlwodomierz = new SqlDataAdapter("SELECT id, idKlient, idWodomierz, nrIdentyfikacyjny, wskazanieWodomierza, dataOdczytu, rozliczona FROM wodomierz", sqlCon);
                DataTable wodomierz = new DataTable();
                sqlwodomierz.Fill(wodomierz);
                gridWodomierz.DataSource = wodomierz;
                int nRowIndex = gridWodomierz.Rows.Count - 1;
                gridWodomierz.Rows[nRowIndex].Selected = true;
                gridWodomierz.CurrentCell = gridWodomierz.Rows[nRowIndex].Cells[1];
            }
        }
        void GridKlient()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlklient = new SqlDataAdapter("SELECT id, idKlient, imie, nazwisko, adres, kodPocztowy, nazwaFirmy, telefon FROM klient", sqlCon);
                DataTable klient = new DataTable();
                sqlklient.Fill(klient);
                gridKlient.DataSource = klient;
                int nRowIndex = gridKlient.Rows.Count - 1;
                gridKlient.Rows[nRowIndex].Selected = true;
                gridKlient.CurrentCell = gridKlient.Rows[nRowIndex].Cells[1];
            }
        }
        void GrupaWybierWodomierzFaktury()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlwod = new SqlDataAdapter("SELECT idWodomierz,nrIdentyfikacyjny,wskazanieWodomierza,dataOdczytu FROM wodomierz where rozliczona = 0 and idklient = " + poleNrKlienta.Text, sqlCon);
                //TODO ograniczenie wodomierzy tylko do wybranego klienta
                DataTable wodomierz = new DataTable();
                sqlwod.Fill(wodomierz);
                gridWyborWodomierz.DataSource = wodomierz;
                if(wodomierz.Rows.Count == 0)
                {
                    btWybWod.Enabled = false;
                }
            }
        }

        private void btWybWodFakt_Click(object sender, EventArgs e)
        {
            if (poleNrKlienta.Text.Length == 0) {
                MessageBox.Show("wybierz klienta");
            }
            else
            {
            GrupaWybierWodomierzFaktury();
            grupaWybWodFakt.Show();
            }

        }

        private void btWrocWod_Click(object sender, EventArgs e)
        {
            grupaWybWodFakt.Hide();
            btWybWod.Enabled = true;
        }

        private void btWybWod_Click(object sender, EventArgs e)
        {
            WybierzWodomierzFaktury();
        }
        private void WybierzWodomierzFaktury()
        {
            grupaWybWodFakt.Hide();
            poleNrWodomierza.Text = gridWyborWodomierz.SelectedRows[0].Cells["idWodomierz2"].Value.ToString();
            btWybWod.Enabled = true;
        }
        int nrid;
        private void btDodajStanWod_Click(object sender, EventArgs e)
        {
            gridWodomierz.Hide();
            poleNrKlientaStWod.Text = gridWodomierz.SelectedRows[0].Cells["idKlientWodomierz"].Value.ToString();
            poleNrWod.Text = gridWodomierz.SelectedRows[0].Cells["idwodomierz1"].Value.ToString();
            poleNrSeryjny.Text = gridWodomierz.SelectedRows[0].Cells["nrIdentyfikacyjny"].Value.ToString();
            grDodajStanWod.Show();
            //ukrywanie przycisku
            dodajKlientaStanWod.Hide();
            UkryjPrzyciskiStanWod();
            nowyStanWod = true;
        }
        private void UkryjPrzyciskiStanWod()
        {
            btDodajStanWod.Hide();
            btDodajNowyStanWod.Hide();
            btPoprawStanWod.Hide();
            btUsunStanWod.Hide();
        }
        private void PokazPrzyciskiStanWod()
        {
            btDodajStanWod.Show();
            btDodajNowyStanWod.Show();
            btPoprawStanWod.Show();
            btUsunStanWod.Show();
        }

        private void btWrocDodajStanWod_Click(object sender, EventArgs e)
        {
            PokazPrzyciskiStanWod();
            GridWodomierz();
            gridWodomierz.Show();
            grDodajStanWod.Hide();
            poleNrKlientaStWod.Text = "";
            poleNrWod.Text = "";
            poleNrSeryjny.Text = "";
            poleWskazanieWod.Text = "";
            nowyStanWod = true;
            dodajKlientaStanWod.Enabled = true;
        }

        private void gridWyborWodomierz_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WybierzWodomierzFaktury();
        }

        private void btDodajNowyStanWod_Click(object sender, EventArgs e)
        {
            gridWodomierz.Hide();
            grDodajStanWod.Show();
            //ukrywanie przycisku
            dodajKlientaStanWod.Show();
            UkryjPrzyciskiStanWod();
            nowyStanWod = true;
        }

        private void dodajKlientaStanWod_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlklient = new SqlDataAdapter("SELECT id, idKlient, imie, nazwisko, nazwaFirmy FROM klient", sqlCon);
                DataTable klient = new DataTable();
                sqlklient.Fill(klient);
                gridWybKlientaStanWod.DataSource = klient;
                int nRowIndex = gridWybKlientaStanWod.Rows.Count - 1;
                gridWybKlientaStanWod.Rows[nRowIndex].Selected = true;
                gridWybKlientaStanWod.CurrentCell = gridWybKlientaStanWod.Rows[nRowIndex].Cells[2];
            }
            grWybierzKlientaWod.Show();
        }

        private void btWrocKlientStWod_Click(object sender, EventArgs e)
        {
            grWybierzKlientaWod.Hide();
        }

        private void btWybStWod_Click(object sender, EventArgs e)
        {
            poleNrKlientaStWod.Text = gridWybKlientaStanWod.SelectedRows[0].Cells["idKlientStWod"].Value.ToString();
            grWybierzKlientaWod.Hide();
            lbNazwaKlientaStanWod.Text = gridWybKlientaStanWod.SelectedRows[0].Cells["nazwaFirmyStWod"].Value.ToString() +
                " " + gridWybKlientaStanWod.SelectedRows[0].Cells["imieStWod"].Value.ToString() +
                " " + gridWybKlientaStanWod.SelectedRows[0].Cells["nazwiskoStWod"].Value.ToString();
        }
        bool nowyStanWod;
        private void btZapiszStanWod_Click(object sender, EventArgs e)
        {
            if (poleNrKlientaStWod.Text == "") {MessageBox.Show("Wybierz klienta");}
            else if (poleNrWod.Text == "") {MessageBox.Show("Wybierz wodomierz");}
            else if (poleNrSeryjny.Text == "") {MessageBox.Show("Wybierz wodo");}
            else if (poleWskazanieWod.Text == "") {MessageBox.Show("wypełnij ple");}
            else
            {
                if (nowyStanWod)
                {
                    StanWodomierza.InsertWodomierz(poleNrKlientaStWod.Text, Convert.ToInt32(poleNrWod.Text), poleNrSeryjny.Text, poleWskazanieWod.Text,
                        poleDataOdczytuWod.Value.ToString());
                }
                else
                {
                    StanWodomierza.UpdateWodomierz(nrid, poleNrKlientaStWod.Text, poleNrWod.Text, poleNrSeryjny.Text, poleWskazanieWod.Text);
                }
                btWrocDodajStanWod_Click(null, null);
                nowyStanWod = false;
                StanWodomierza.tenwskazanieWodomierza = -1;
            }
        }

        private void btPoprawStanWod_Click(object sender, EventArgs e)
        {
            if (gridWodomierz.CurrentRow.Cells["rozliczona"].Value.ToString() == "False")
            {
                PoprawStanWodomierz();
            }
            else
            {
                MessageBox.Show("Nie można poprawić rozliczonego wpisu.\nUsuń fakturę rozliczającą i popraw wpis.");
            }
               
        }

        private void PoprawStanWodomierz()
        {
            nowyStanWod = false;
            nrid = Convert.ToInt32(gridWodomierz.SelectedRows[0].Cells["idwodomierz"].Value);
            gridWodomierz.Hide();
            //MessageBox.Show(gridWodomierz.SelectedRows[0].Cells["idKlientWodomierz"].Value.ToString() + ' '
            //    + gridWodomierz.SelectedRows[0].Cells["idwodomierz1"].Value.ToString() + ' '
            //    + gridWodomierz.SelectedRows[0].Cells["nrIdentyfikacyjny"].Value.ToString());
            poleNrKlientaStWod.Text = gridWodomierz.SelectedRows[0].Cells["idKlientWodomierz"].Value.ToString();
            poleNrWod.Text = gridWodomierz.SelectedRows[0].Cells["idwodomierz1"].Value.ToString();
            poleNrSeryjny.Text = gridWodomierz.SelectedRows[0].Cells["nrIdentyfikacyjny"].Value.ToString();
            poleWskazanieWod.Text = gridWodomierz.SelectedRows[0].Cells["wskazanieWodomierz"].Value.ToString();
            poleDataOdczytuWod.Value = Convert.ToDateTime(gridWodomierz.SelectedRows[0].Cells["dataOdczytu"].Value);
            grDodajStanWod.Show();
            //ukrywanie przycisku
            UkryjPrzyciskiStanWod();
            dodajKlientaStanWod.Enabled = false;
        }

        private void btUsunStanWod_Click(object sender, EventArgs e)
        {
            UsunStanWod();
        }

        private void UsunStanWod()
        {
            if (gridWodomierz.CurrentRow.Cells["rozliczona"].Value.ToString() == "False" & gridWodomierz.CurrentRow.Cells["wskazanieWodomierz"].Value.ToString() == "0.00")
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("usunWodomierz", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", gridWodomierz.CurrentRow.Cells["idwodomierz"].Value);
                        sqlCmd.ExecuteNonQuery();
                        GridWodomierz();
                    }
                }
                else
                    GridFaktury();
            }
            else
                MessageBox.Show("Nie można usunąć rozliczonego wpisu.\nUsuń fakturę rozliczającą i usuń wpis.");
        }

        private void btPoprawStanWod_Click(object sender, DataGridViewCellEventArgs e)
        {
            PoprawStanWodomierz();
        }

        private void btWybStWod_Click(object sender, DataGridViewCellEventArgs e)
        {
            poleNrKlientaStWod.Text = gridWybKlientaStanWod.SelectedRows[0].Cells["idKlientStWod"].Value.ToString();
            grWybierzKlientaWod.Hide();
        }

        private void gridWybKlientaStanWod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poleNrKlientaStWod.Text = gridWybKlientaStanWod.SelectedRows[0].Cells["idKlientStWod"].Value.ToString();
            grWybierzKlientaWod.Hide();
            lbNazwaKlientaStanWod.Text = gridWybKlientaStanWod.SelectedRows[0].Cells["nazwaFirmyStWod"].Value.ToString()+
                " " + gridWybKlientaStanWod.SelectedRows[0].Cells["imieStWod"].Value.ToString() +
                " " + gridWybKlientaStanWod.SelectedRows[0].Cells["nazwiskoStWod"].Value.ToString(); 
        }

        private void btDodajKlient_Click(object sender, EventArgs e)
        {
            Klient.NowyNrKlient();
            idDodajKlient.Text = Klient.tenidKlient;
            UkryjPrzyciskiKlient();
            nowyKlient = true;
        }
        private void UkryjPrzyciskiKlient()
        {
            btDodajKlient.Hide();
            btPoprawKlient.Hide();
            usunKlient.Hide();
            gridKlient.Hide();
            grupaDodajKlient.Show();
            filtrNazwisko.Hide();
        }

        private void btPoprawKlient_Click(object sender, EventArgs e)
        {//wybieranie id klient do poprawy
            PoprawKlient();
            UkryjPrzyciskiKlient();
        }
        private void PoprawKlient()
        {
            idDodajKlient.Text = gridKlient.SelectedRows[0].Cells["idklient3"].Value.ToString();
            poleImieDodajKlient.Text = gridKlient.SelectedRows[0].Cells["imie"].Value.ToString();
            poleNazwiskoDodajKlient.Text = gridKlient.SelectedRows[0].Cells["nazwisko1"].Value.ToString();
            poleAdresDodajKlient.Text = gridKlient.SelectedRows[0].Cells["adres2"].Value.ToString();
            poleKodDodajKlient.Text = gridKlient.SelectedRows[0].Cells["kodPocztowy"].Value.ToString();
            poleNazwaFirmyDodajKlient.Text = gridKlient.SelectedRows[0].Cells["nazwaFirmy2"].Value.ToString();
            poleTelefonDodajKlient.Text = gridKlient.SelectedRows[0].Cells["telefon2"].Value.ToString();
        }
        private void PokazPrzyciskiKlient()
        {
            btDodajKlient.Show();
            btPoprawKlient.Show();
            usunKlient.Show();
            gridKlient.Show();
            grupaDodajKlient.Hide();
            filtrNazwisko.Show();
        }

        private void btWrocKlient_Click(object sender, EventArgs e)
        {
            CzyscPolaDodajKlient();
            PokazPrzyciskiKlient();
            nowyKlient = false;
        }
        private void CzyscPolaDodajKlient()
        {
            idDodajKlient.Text = "";
            poleImieDodajKlient.Text = "";
            poleNazwiskoDodajKlient.Text = "";
            poleAdresDodajKlient.Text = "";
            poleKodDodajKlient.Text = "";
            poleNazwaFirmyDodajKlient.Text = "";
            poleTelefonDodajKlient.Text = "";
        }

        bool nowyKlient;
        private void btZapiszKlient_Click(object sender, EventArgs e)
        {//zapisywanie do bazy 
            if (poleImieDodajKlient.Text == "") { MessageBox.Show("Wpisz imię klienta"); }
            else if (poleNazwiskoDodajKlient.Text == "") { MessageBox.Show("Wpisz nazwisko"); }
            else if (poleAdresDodajKlient.Text == "") { MessageBox.Show("Wypełnij adres"); }
            else if (poleKodDodajKlient.Text == "") { MessageBox.Show("wypełnij kod pocztowy"); }
            else
            {
                if (nowyKlient)
                {
                    Klient.InsertKlient(poleImieDodajKlient.Text, poleNazwiskoDodajKlient.Text, poleAdresDodajKlient.Text, poleKodDodajKlient.Text,
                        poleNazwaFirmyDodajKlient.Text, poleTelefonDodajKlient.Text);
                    PokazPrzyciskiKlient();
                    CzyscPolaDodajKlient();
                    GridKlient();
                }
                else
                {
                    Klient.PoprawKlient(Convert.ToInt32(idDodajKlient.Text), poleImieDodajKlient.Text, poleNazwiskoDodajKlient.Text,
                        poleAdresDodajKlient.Text, poleKodDodajKlient.Text, poleNazwaFirmyDodajKlient.Text, poleTelefonDodajKlient.Text);
                    PokazPrzyciskiKlient();
                    CzyscPolaDodajKlient();
                    GridKlient();
                }
                nowyKlient = false;
            }
        }

        private void usunKlient_Click(object sender, EventArgs e)
        {
            UsunKlient();
        }
        private void UsunKlient()
        {
            if (gridKlient.CurrentRow.Cells["idklientklienci"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("usunKlient", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", gridKlient.CurrentRow.Cells["idklientklienci"].Value);
                        sqlCmd.ExecuteNonQuery();
                        GridKlient();
                    }
                }
                else
                    GridKlient();
            }
            else
                MessageBox.Show("123Test2");
        }

        private void gridKlient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PoprawKlient();
            UkryjPrzyciskiKlient();
        }

        private void ustawianieWilekosciTaba(object sender, EventArgs e)
        {
            ustawianieWilekosciTaba();
        }

        private void btUsunCennik_Click(object sender, EventArgs e)
        {
            UsunCennikk();
        }
        private void UsunCennikk()
        {
            if (gridCennik.CurrentRow.Cells["idC"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Czy napewno usunąć zaznaczenie?", "Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cennik.UsunCennik(Convert.ToInt32(gridCennik.CurrentRow.Cells["idC"].Value));
                    GridCennik();
                }
                else
                    GridCennik();
            }
        }

        private void btDodajCennik_Click(object sender, EventArgs e)
        {
            UkryjButCennik();
            nowyCennik = true;
            grCennik.Text = "Dodaj stawkę cennika";
        }

        private void UkryjButCennik()
        {
            grCennik.Show();
            btDodajCennik.Hide();
            btPoprawCennik.Hide();
            btUsunCennik.Hide();
            gridCennik.Hide();
        }
        private void PokazButCennik()
        {
            grCennik.Hide();
            btDodajCennik.Show();
            btPoprawCennik.Show();
            btUsunCennik.Show();
            gridCennik.Show();
        }

        private void btWrocCennik_Click(object sender, EventArgs e)
        {
            PokazButCennik();
            CzyszczeniePolGrCennik();
        }

        public int idCennik;
        bool nowyCennik;
        private void btPoprawCennik_Click(object sender, EventArgs e)
        {
            UkryjButCennik();
            nowyCennik = false;
            grDataod.Value = Convert.ToDateTime(gridCennik.CurrentRow.Cells["txtDataOd"].Value);
            grDatoDo.Value = Convert.ToDateTime(gridCennik.CurrentRow.Cells["txtDataDo"].Value);
            poleNettoCennik.Text = Convert.ToString(gridCennik.CurrentRow.Cells["txtNetto"].Value);
            poleVatCennik.Text = Convert.ToString(gridCennik.CurrentRow.Cells["txtsymbolVat"].Value);
            idCennik = Convert.ToInt32(gridCennik.CurrentRow.Cells["idC"].Value);
            grCennik.Text = "Popraw stawkę cennika";
        }

        private void btZapiszCennik_Click(object sender, EventArgs e)
        {
            if (poleNettoCennik.Text == "") { MessageBox.Show("Wpisz kwotę"); }
            else if (poleVatCennik.Text == "") { MessageBox.Show("Wpisz stawkę vat"); }
            else
            {
                if (nowyCennik)
                    {
                        PokazButCennik();
                        Cennik.DodajCennik(Convert.ToDateTime(grDataod.Value), Convert.ToDateTime(grDatoDo.Value), Convert.ToDecimal(poleNettoCennik.Text),
                            Convert.ToInt32(poleVatCennik.Text));
                        CzyszczeniePolGrCennik();
                        GridCennik();
                    }
                    else
                    {
                        PokazButCennik();
                        Cennik.PoprawCennik(idCennik, Convert.ToDateTime(grDataod.Value), Convert.ToDateTime(grDatoDo.Value), Convert.ToDecimal(poleNettoCennik.Text), 
                            Convert.ToInt32(poleVatCennik.Text));
                        CzyszczeniePolGrCennik();
                        GridCennik();
                    }
            }
        }
        private void CzyszczeniePolGrCennik()
        {
            grDataod.Value = Convert.ToDateTime("2020-05-01");
            grDatoDo.Value = Convert.ToDateTime("2020-06-01");
            poleNettoCennik.Text = "";
            poleVatCennik.Text = "";
        }

        private void btFiltr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nie baw się bo jeszcze nie działa i popsujesz :).");
            GridFaktury();
        }

        private void walidacjaNrKlientaFaktury(object sender, CancelEventArgs e)
        {
            bool klientIstnieje = false;
            //poleNrKlienta //id,idKlient,imie,nazwisko,adres,kodPocztowy,nazwaFirmy,telefon FROM klient where idKlient
            SqlConnection polaczenie = new SqlConnection(connectionString);
            polaczenie.Open();
            SqlCommand komendaSQL = polaczenie.CreateCommand();
            komendaSQL.CommandText = "SELECT count(idKlient) as idKlient FROM klient where idKlient = '" + poleNrKlienta.Text.ToString() + "'";
            SqlDataReader thisReader = komendaSQL.ExecuteReader();

            while (thisReader.Read())
            {
                if (thisReader["idKlient"].ToString() == "1") { klientIstnieje = true; };
            }
            thisReader.Close();
            polaczenie.Close();
            if (klientIstnieje)
            {
                SqlConnection polaczenie2 = new SqlConnection(connectionString);
                SqlCommand komendaSQL2 = polaczenie2.CreateCommand();
                polaczenie2.Open();
                komendaSQL2.CommandText = "SELECT id,idKlient,imie,nazwisko,adres,kodPocztowy,nazwaFirmy,telefon FROM klient where idKlient = '" + poleNrKlienta.Text.ToString() + "'";
                SqlDataReader thisReader2 = komendaSQL2.ExecuteReader();
                while (thisReader2.Read())
                {

                    thisReader2["id"].ToString();
                    thisReader2["idKlient"].ToString();
                    toImie = thisReader2["imie"].ToString();
                    tonazwisko = thisReader2["nazwisko"].ToString();
                    lbNazwaKlienta.Text = toImie + " " + tonazwisko;
                    lbAdresKlienta.Text = thisReader2["adres"].ToString();
                    thisReader2["kodPocztowy"].ToString();
                    lbNazwaFirmy.Text = thisReader2["nazwaFirmy"].ToString();
                    lbTelefon.Text = thisReader2["telefon"].ToString();
                }
            thisReader2.Close();
            polaczenie2.Close();
            }
            else
            {
            MessageBox.Show("Nie ma takiego klienta w bazie.");
                poleNrKlienta.Text = "";
                btWybierKlientaDoFaktury_Click(null, null);
            }

        }
        bool pozwolZmieniacTaby = false;
        private void WybranyTab(object sender, TabControlCancelEventArgs e)
        {
            if (pozwolZmieniacTaby) //420
            {
                if (tabControl1.SelectedIndex.ToString() == "2")
                {
                BindData();
                }
                if (tabControl1.SelectedIndex.ToString() == "3")
                {
                    BindData();
                }
                //MessageBox.Show(tabControl1.SelectedIndex.ToString());

            }
            else {
                //MessageBox.Show("Test");
                //BindData();
            }
        }

        //poleStawkaVat
        public void BindData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string strCmd = "select symbolVat from cennik";
                SqlCommand cmd = new SqlCommand(strCmd, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(strCmd, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                poleStawkaVat.DataSource = dt;
                poleStawkaVat.DisplayMember = "symbolVat";
                poleStawkaVat.ValueMember = "symbolVat";
                poleStawkaVat.Enabled = true;
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        private void walidacjaZuzyciaWody(object sender, CancelEventArgs e)
        {
            if (poleWskazanieWod.Text.Length != 0)
            {
                StanWodomierza.OstatniOdczytWodomierza(Convert.ToInt32(poleNrKlientaStWod.Text), Convert.ToInt32(poleNrWod.Text));
                    if (Convert.ToDecimal(poleWskazanieWod.Text) <= StanWodomierza.tenwskazanieWodomierza)
                    {
                        MessageBox.Show("Wpisano zły odczyt wodomierza. ostatni wprowadzony odczyt to: " + StanWodomierza.tenwskazanieWodomierza.ToString());
                        poleWskazanieWod.Text = "";
                    }
            }
        }

    }
}
