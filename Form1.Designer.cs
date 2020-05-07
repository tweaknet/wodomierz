using System.Drawing;

namespace wodomierz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.haslo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pLogin = new System.Windows.Forms.Label();
            this.pHaslo = new System.Windows.Forms.Label();
            this.pWynikLogowania = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grupaDodajKlient = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.poleTelefonDodajKlient = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.poleNazwaFirmyDodajKlient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.poleKodDodajKlient = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.poleAdresDodajKlient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.poleNazwiskoDodajKlient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idDodajKlient = new System.Windows.Forms.Label();
            this.poleImieDodajKlient = new System.Windows.Forms.TextBox();
            this.lbIdKlient = new System.Windows.Forms.Label();
            this.btWrocKlient = new System.Windows.Forms.Button();
            this.btZapiszKlient = new System.Windows.Forms.Button();
            this.btPoprawKlient = new System.Windows.Forms.Button();
            this.btDodajKlient = new System.Windows.Forms.Button();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.usunKlient = new System.Windows.Forms.Button();
            this.gridKlient = new System.Windows.Forms.DataGridView();
            this.idklientklienci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklient3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmy2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btUsunStanWod = new System.Windows.Forms.Button();
            this.btPoprawStanWod = new System.Windows.Forms.Button();
            this.btDodajNowyStanWod = new System.Windows.Forms.Button();
            this.btDodajStanWod = new System.Windows.Forms.Button();
            this.grDodajStanWod = new System.Windows.Forms.GroupBox();
            this.grWybierzKlientaWod = new System.Windows.Forms.GroupBox();
            this.btWybStWod = new System.Windows.Forms.Button();
            this.btWrocKlientStWod = new System.Windows.Forms.Button();
            this.gridWybKlientaStanWod = new System.Windows.Forms.DataGridView();
            this.idStwod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlientStWod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyStWod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieStWod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoStWod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNazwaKlientaStanWod = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.poleWskazanieWod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.poleNrSeryjny = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poleNrWod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.poleNrKlientaStWod = new System.Windows.Forms.TextBox();
            this.btWrocDodajStanWod = new System.Windows.Forms.Button();
            this.btZapiszStanWod = new System.Windows.Forms.Button();
            this.poleDataOdczytuWod = new System.Windows.Forms.DateTimePicker();
            this.dodajKlientaStanWod = new System.Windows.Forms.Button();
            this.gridWodomierz = new System.Windows.Forms.DataGridView();
            this.idwodomierz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlientWodomierz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWodomierz1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrIdentyfikacyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wskazanieWodomierz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOdczytu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grPozFaktur = new System.Windows.Forms.GroupBox();
            this.grupaWybWodFakt = new System.Windows.Forms.GroupBox();
            this.btWybWod = new System.Windows.Forms.Button();
            this.btWrocWod = new System.Windows.Forms.Button();
            this.gridWyborWodomierz = new System.Windows.Forms.DataGridView();
            this.idWodomierz2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrIdentyfikacyjny1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wskazanieWodomierza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOdczytu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grWyboruKlientaDoFaktury = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlient2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmy1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaBanku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btWrocWyborKlientaDoFaktury = new System.Windows.Forms.Button();
            this.btWybierzKlientaDoFaktury = new System.Windows.Forms.Button();
            this.lbNazwaFirmy = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbNazwaBanku = new System.Windows.Forms.Label();
            this.lbAdresKlienta = new System.Windows.Forms.Label();
            this.poleFormaPlatnosci = new System.Windows.Forms.ComboBox();
            this.btWybWodFakt = new System.Windows.Forms.Button();
            this.lbNazwaKlienta = new System.Windows.Forms.Label();
            this.wyborTerminu = new System.Windows.Forms.DateTimePicker();
            this.button15 = new System.Windows.Forms.Button();
            this.poleStawkaVat = new System.Windows.Forms.ComboBox();
            this.btWybierKlientaDoFaktury = new System.Windows.Forms.Button();
            this.poleNetto = new System.Windows.Forms.TextBox();
            this.lbilosc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.poleNrKlienta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.poleIlosc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poleNrWodomierza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btWrocFaktura = new System.Windows.Forms.Button();
            this.btZapiszFakture = new System.Windows.Forms.Button();
            this.gridPozycjiFaktury = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFiltra = new System.Windows.Forms.DateTimePicker();
            this.btFiltr = new System.Windows.Forms.Button();
            this.btUsunFakture = new System.Windows.Forms.Button();
            this.btPoprawFakture = new System.Windows.Forms.Button();
            this.btDodajFakture = new System.Windows.Forms.Button();
            this.gridFaktury = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrFaktury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWystawieniaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminPlatnosciN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPlatnosciN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresKlientN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaBankuN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolVatN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridCennik = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsymbolVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.GridPracownicy = new System.Windows.Forms.DataGridView();
            this.txtEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtczyAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtaktywny = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ileKartLb = new System.Windows.Forms.Label();
            this.pracownikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logowanie = new wodomierz.logowanie();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownikTableAdapter = new wodomierz.logowanieTableAdapters.pracownikTableAdapter();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklient1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grupaDodajKlient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grDodajStanWod.SuspendLayout();
            this.grWybierzKlientaWod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWybKlientaStanWod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWodomierz)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grPozFaktur.SuspendLayout();
            this.grupaWybWodFakt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWyborWodomierz)).BeginInit();
            this.grWyboruKlientaDoFaktury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPozycjiFaktury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaktury)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCennik)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowanie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(72, 60);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(174, 20);
            this.haslo.TabIndex = 1;
            this.haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pLogin
            // 
            this.pLogin.AutoSize = true;
            this.pLogin.Location = new System.Drawing.Point(22, 41);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(36, 13);
            this.pLogin.TabIndex = 3;
            this.pLogin.Text = "Login:";
            this.pLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // pHaslo
            // 
            this.pHaslo.AutoSize = true;
            this.pHaslo.Location = new System.Drawing.Point(22, 67);
            this.pHaslo.Name = "pHaslo";
            this.pHaslo.Size = new System.Drawing.Size(39, 13);
            this.pHaslo.TabIndex = 4;
            this.pHaslo.Text = "Hasło:";
            // 
            // pWynikLogowania
            // 
            this.pWynikLogowania.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pWynikLogowania.AutoSize = true;
            this.pWynikLogowania.Location = new System.Drawing.Point(12, 522);
            this.pWynikLogowania.Name = "pWynikLogowania";
            this.pWynikLogowania.Size = new System.Drawing.Size(183, 13);
            this.pWynikLogowania.TabIndex = 5;
            this.pWynikLogowania.Text = "Wpisz login i hasło aby kontynuować";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ItemSize = new System.Drawing.Size(201, 22);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 492);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grupaDodajKlient);
            this.tabPage1.Controls.Add(this.btPoprawKlient);
            this.tabPage1.Controls.Add(this.btDodajKlient);
            this.tabPage1.Controls.Add(this.nazwisko);
            this.tabPage1.Controls.Add(this.usunKlient);
            this.tabPage1.Controls.Add(this.gridKlient);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klienci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grupaDodajKlient
            // 
            this.grupaDodajKlient.Controls.Add(this.label16);
            this.grupaDodajKlient.Controls.Add(this.poleTelefonDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.label15);
            this.grupaDodajKlient.Controls.Add(this.poleNazwaFirmyDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.label14);
            this.grupaDodajKlient.Controls.Add(this.poleKodDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.label13);
            this.grupaDodajKlient.Controls.Add(this.poleAdresDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.label12);
            this.grupaDodajKlient.Controls.Add(this.poleNazwiskoDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.label11);
            this.grupaDodajKlient.Controls.Add(this.idDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.poleImieDodajKlient);
            this.grupaDodajKlient.Controls.Add(this.lbIdKlient);
            this.grupaDodajKlient.Controls.Add(this.btWrocKlient);
            this.grupaDodajKlient.Controls.Add(this.btZapiszKlient);
            this.grupaDodajKlient.Location = new System.Drawing.Point(56, 105);
            this.grupaDodajKlient.Name = "grupaDodajKlient";
            this.grupaDodajKlient.Size = new System.Drawing.Size(813, 229);
            this.grupaDodajKlient.TabIndex = 8;
            this.grupaDodajKlient.TabStop = false;
            this.grupaDodajKlient.Text = "Dodaj klienta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(377, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Telefon";
            // 
            // poleTelefonDodajKlient
            // 
            this.poleTelefonDodajKlient.Location = new System.Drawing.Point(359, 122);
            this.poleTelefonDodajKlient.Name = "poleTelefonDodajKlient";
            this.poleTelefonDodajKlient.Size = new System.Drawing.Size(100, 22);
            this.poleTelefonDodajKlient.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Nazwa firmy";
            // 
            // poleNazwaFirmyDodajKlient
            // 
            this.poleNazwaFirmyDodajKlient.Location = new System.Drawing.Point(106, 132);
            this.poleNazwaFirmyDodajKlient.Name = "poleNazwaFirmyDodajKlient";
            this.poleNazwaFirmyDodajKlient.Size = new System.Drawing.Size(100, 22);
            this.poleNazwaFirmyDodajKlient.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(648, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Kod Pocztowy";
            // 
            // poleKodDodajKlient
            // 
            this.poleKodDodajKlient.Location = new System.Drawing.Point(646, 57);
            this.poleKodDodajKlient.Name = "poleKodDodajKlient";
            this.poleKodDodajKlient.Size = new System.Drawing.Size(100, 22);
            this.poleKodDodajKlient.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(341, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Adres";
            // 
            // poleAdresDodajKlient
            // 
            this.poleAdresDodajKlient.Location = new System.Drawing.Point(323, 57);
            this.poleAdresDodajKlient.Name = "poleAdresDodajKlient";
            this.poleAdresDodajKlient.Size = new System.Drawing.Size(293, 22);
            this.poleAdresDodajKlient.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Nazwisko";
            // 
            // poleNazwiskoDodajKlient
            // 
            this.poleNazwiskoDodajKlient.Location = new System.Drawing.Point(191, 57);
            this.poleNazwiskoDodajKlient.Name = "poleNazwiskoDodajKlient";
            this.poleNazwiskoDodajKlient.Size = new System.Drawing.Size(100, 22);
            this.poleNazwiskoDodajKlient.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Imie";
            // 
            // idDodajKlient
            // 
            this.idDodajKlient.AutoSize = true;
            this.idDodajKlient.Location = new System.Drawing.Point(19, 63);
            this.idDodajKlient.Name = "idDodajKlient";
            this.idDodajKlient.Size = new System.Drawing.Size(25, 16);
            this.idDodajKlient.TabIndex = 4;
            this.idDodajKlient.Text = "Id:";
            // 
            // poleImieDodajKlient
            // 
            this.poleImieDodajKlient.Location = new System.Drawing.Point(66, 57);
            this.poleImieDodajKlient.Name = "poleImieDodajKlient";
            this.poleImieDodajKlient.Size = new System.Drawing.Size(100, 22);
            this.poleImieDodajKlient.TabIndex = 3;
            // 
            // lbIdKlient
            // 
            this.lbIdKlient.AutoSize = true;
            this.lbIdKlient.Location = new System.Drawing.Point(19, 30);
            this.lbIdKlient.Name = "lbIdKlient";
            this.lbIdKlient.Size = new System.Drawing.Size(25, 16);
            this.lbIdKlient.TabIndex = 2;
            this.lbIdKlient.Text = "Id:";
            // 
            // btWrocKlient
            // 
            this.btWrocKlient.Location = new System.Drawing.Point(651, 200);
            this.btWrocKlient.Name = "btWrocKlient";
            this.btWrocKlient.Size = new System.Drawing.Size(75, 23);
            this.btWrocKlient.TabIndex = 1;
            this.btWrocKlient.Text = "Wróć";
            this.btWrocKlient.UseVisualStyleBackColor = true;
            this.btWrocKlient.Click += new System.EventHandler(this.btWrocKlient_Click);
            // 
            // btZapiszKlient
            // 
            this.btZapiszKlient.Location = new System.Drawing.Point(732, 200);
            this.btZapiszKlient.Name = "btZapiszKlient";
            this.btZapiszKlient.Size = new System.Drawing.Size(75, 23);
            this.btZapiszKlient.TabIndex = 0;
            this.btZapiszKlient.Text = "Zapisz";
            this.btZapiszKlient.UseVisualStyleBackColor = true;
            this.btZapiszKlient.Click += new System.EventHandler(this.btZapiszKlient_Click);
            // 
            // btPoprawKlient
            // 
            this.btPoprawKlient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPoprawKlient.Location = new System.Drawing.Point(90, 433);
            this.btPoprawKlient.Name = "btPoprawKlient";
            this.btPoprawKlient.Size = new System.Drawing.Size(75, 23);
            this.btPoprawKlient.TabIndex = 7;
            this.btPoprawKlient.Text = "Popraw";
            this.btPoprawKlient.UseVisualStyleBackColor = true;
            this.btPoprawKlient.Click += new System.EventHandler(this.btPoprawKlient_Click);
            // 
            // btDodajKlient
            // 
            this.btDodajKlient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDodajKlient.Location = new System.Drawing.Point(9, 433);
            this.btDodajKlient.Name = "btDodajKlient";
            this.btDodajKlient.Size = new System.Drawing.Size(75, 23);
            this.btDodajKlient.TabIndex = 6;
            this.btDodajKlient.Text = "Dodaj";
            this.btDodajKlient.UseVisualStyleBackColor = true;
            this.btDodajKlient.Click += new System.EventHandler(this.btDodajKlient_Click);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(341, 433);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(132, 22);
            this.nazwisko.TabIndex = 2;
            this.nazwisko.Text = "Filtr nazwiska";
            // 
            // usunKlient
            // 
            this.usunKlient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usunKlient.Location = new System.Drawing.Point(171, 433);
            this.usunKlient.Name = "usunKlient";
            this.usunKlient.Size = new System.Drawing.Size(75, 23);
            this.usunKlient.TabIndex = 5;
            this.usunKlient.Text = "Usuń";
            this.usunKlient.UseVisualStyleBackColor = true;
            this.usunKlient.Click += new System.EventHandler(this.usunKlient_Click);
            // 
            // gridKlient
            // 
            this.gridKlient.AllowUserToAddRows = false;
            this.gridKlient.AllowUserToDeleteRows = false;
            this.gridKlient.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridKlient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklientklienci,
            this.idklient3,
            this.imie,
            this.nazwisko1,
            this.nazwaFirmy2,
            this.adres2,
            this.kodPocztowy,
            this.telefon2});
            this.gridKlient.Location = new System.Drawing.Point(9, 14);
            this.gridKlient.Name = "gridKlient";
            this.gridKlient.ReadOnly = true;
            this.gridKlient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKlient.Size = new System.Drawing.Size(829, 413);
            this.gridKlient.TabIndex = 4;
            this.gridKlient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKlient_CellContentClick);
            // 
            // idklientklienci
            // 
            this.idklientklienci.DataPropertyName = "id";
            this.idklientklienci.HeaderText = "id";
            this.idklientklienci.Name = "idklientklienci";
            this.idklientklienci.ReadOnly = true;
            this.idklientklienci.Visible = false;
            // 
            // idklient3
            // 
            this.idklient3.DataPropertyName = "idKlient";
            this.idklient3.HeaderText = "Nr klienta";
            this.idklient3.Name = "idklient3";
            this.idklient3.ReadOnly = true;
            this.idklient3.Width = 45;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "imie";
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            this.imie.Width = 80;
            // 
            // nazwisko1
            // 
            this.nazwisko1.DataPropertyName = "nazwisko";
            this.nazwisko1.HeaderText = "nazwisko";
            this.nazwisko1.Name = "nazwisko1";
            this.nazwisko1.ReadOnly = true;
            // 
            // nazwaFirmy2
            // 
            this.nazwaFirmy2.DataPropertyName = "nazwaFirmy";
            this.nazwaFirmy2.HeaderText = "Nazwa firmy";
            this.nazwaFirmy2.Name = "nazwaFirmy2";
            this.nazwaFirmy2.ReadOnly = true;
            this.nazwaFirmy2.Width = 130;
            // 
            // adres2
            // 
            this.adres2.DataPropertyName = "adres";
            this.adres2.HeaderText = "adres";
            this.adres2.Name = "adres2";
            this.adres2.ReadOnly = true;
            this.adres2.Width = 150;
            // 
            // kodPocztowy
            // 
            this.kodPocztowy.DataPropertyName = "kodPocztowy";
            this.kodPocztowy.HeaderText = "Kod";
            this.kodPocztowy.Name = "kodPocztowy";
            this.kodPocztowy.ReadOnly = true;
            this.kodPocztowy.Width = 70;
            // 
            // telefon2
            // 
            this.telefon2.DataPropertyName = "telefon";
            this.telefon2.HeaderText = "Telefon";
            this.telefon2.Name = "telefon2";
            this.telefon2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(9, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "boxNaKontrolkiKlientów";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(259, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Usuń";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Popraw";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btUsunStanWod);
            this.tabPage2.Controls.Add(this.btPoprawStanWod);
            this.tabPage2.Controls.Add(this.btDodajNowyStanWod);
            this.tabPage2.Controls.Add(this.btDodajStanWod);
            this.tabPage2.Controls.Add(this.grDodajStanWod);
            this.tabPage2.Controls.Add(this.gridWodomierz);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1009, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stany wodomierzy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btUsunStanWod
            // 
            this.btUsunStanWod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUsunStanWod.Location = new System.Drawing.Point(429, 433);
            this.btUsunStanWod.Name = "btUsunStanWod";
            this.btUsunStanWod.Size = new System.Drawing.Size(75, 23);
            this.btUsunStanWod.TabIndex = 13;
            this.btUsunStanWod.Text = "Usuń";
            this.btUsunStanWod.UseVisualStyleBackColor = true;
            this.btUsunStanWod.Click += new System.EventHandler(this.btUsunStanWod_Click);
            // 
            // btPoprawStanWod
            // 
            this.btPoprawStanWod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPoprawStanWod.Location = new System.Drawing.Point(347, 433);
            this.btPoprawStanWod.Name = "btPoprawStanWod";
            this.btPoprawStanWod.Size = new System.Drawing.Size(75, 23);
            this.btPoprawStanWod.TabIndex = 4;
            this.btPoprawStanWod.Text = "Popraw";
            this.btPoprawStanWod.UseVisualStyleBackColor = true;
            this.btPoprawStanWod.Click += new System.EventHandler(this.btPoprawStanWod_Click);
            // 
            // btDodajNowyStanWod
            // 
            this.btDodajNowyStanWod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDodajNowyStanWod.Location = new System.Drawing.Point(160, 433);
            this.btDodajNowyStanWod.Name = "btDodajNowyStanWod";
            this.btDodajNowyStanWod.Size = new System.Drawing.Size(176, 23);
            this.btDodajNowyStanWod.TabIndex = 12;
            this.btDodajNowyStanWod.Text = "Dodaj nowy wodomierz";
            this.btDodajNowyStanWod.UseVisualStyleBackColor = true;
            this.btDodajNowyStanWod.Click += new System.EventHandler(this.btDodajNowyStanWod_Click);
            // 
            // btDodajStanWod
            // 
            this.btDodajStanWod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDodajStanWod.Location = new System.Drawing.Point(6, 433);
            this.btDodajStanWod.Name = "btDodajStanWod";
            this.btDodajStanWod.Size = new System.Drawing.Size(148, 23);
            this.btDodajStanWod.TabIndex = 1;
            this.btDodajStanWod.Text = "Dodaj nowy odczyt";
            this.btDodajStanWod.UseVisualStyleBackColor = true;
            this.btDodajStanWod.Click += new System.EventHandler(this.btDodajStanWod_Click);
            // 
            // grDodajStanWod
            // 
            this.grDodajStanWod.Controls.Add(this.grWybierzKlientaWod);
            this.grDodajStanWod.Controls.Add(this.lbNazwaKlientaStanWod);
            this.grDodajStanWod.Controls.Add(this.label10);
            this.grDodajStanWod.Controls.Add(this.poleWskazanieWod);
            this.grDodajStanWod.Controls.Add(this.label9);
            this.grDodajStanWod.Controls.Add(this.poleNrSeryjny);
            this.grDodajStanWod.Controls.Add(this.label8);
            this.grDodajStanWod.Controls.Add(this.poleNrWod);
            this.grDodajStanWod.Controls.Add(this.label4);
            this.grDodajStanWod.Controls.Add(this.poleNrKlientaStWod);
            this.grDodajStanWod.Controls.Add(this.btWrocDodajStanWod);
            this.grDodajStanWod.Controls.Add(this.btZapiszStanWod);
            this.grDodajStanWod.Controls.Add(this.poleDataOdczytuWod);
            this.grDodajStanWod.Controls.Add(this.dodajKlientaStanWod);
            this.grDodajStanWod.Location = new System.Drawing.Point(9, 42);
            this.grDodajStanWod.Name = "grDodajStanWod";
            this.grDodajStanWod.Size = new System.Drawing.Size(992, 373);
            this.grDodajStanWod.TabIndex = 14;
            this.grDodajStanWod.TabStop = false;
            this.grDodajStanWod.Text = "Dodaj stan wodomierza";
            // 
            // grWybierzKlientaWod
            // 
            this.grWybierzKlientaWod.Controls.Add(this.btWybStWod);
            this.grWybierzKlientaWod.Controls.Add(this.btWrocKlientStWod);
            this.grWybierzKlientaWod.Controls.Add(this.gridWybKlientaStanWod);
            this.grWybierzKlientaWod.Location = new System.Drawing.Point(6, 77);
            this.grWybierzKlientaWod.Name = "grWybierzKlientaWod";
            this.grWybierzKlientaWod.Size = new System.Drawing.Size(502, 266);
            this.grWybierzKlientaWod.TabIndex = 13;
            this.grWybierzKlientaWod.TabStop = false;
            this.grWybierzKlientaWod.Text = "Wybierz klienta";
            // 
            // btWybStWod
            // 
            this.btWybStWod.Location = new System.Drawing.Point(414, 233);
            this.btWybStWod.Name = "btWybStWod";
            this.btWybStWod.Size = new System.Drawing.Size(75, 23);
            this.btWybStWod.TabIndex = 2;
            this.btWybStWod.Text = "Wybierz";
            this.btWybStWod.UseVisualStyleBackColor = true;
            this.btWybStWod.Click += new System.EventHandler(this.btWybStWod_Click);
            // 
            // btWrocKlientStWod
            // 
            this.btWrocKlientStWod.Location = new System.Drawing.Point(333, 233);
            this.btWrocKlientStWod.Name = "btWrocKlientStWod";
            this.btWrocKlientStWod.Size = new System.Drawing.Size(75, 23);
            this.btWrocKlientStWod.TabIndex = 1;
            this.btWrocKlientStWod.Text = "Wróć";
            this.btWrocKlientStWod.UseVisualStyleBackColor = true;
            this.btWrocKlientStWod.Click += new System.EventHandler(this.btWrocKlientStWod_Click);
            // 
            // gridWybKlientaStanWod
            // 
            this.gridWybKlientaStanWod.AllowUserToAddRows = false;
            this.gridWybKlientaStanWod.AllowUserToDeleteRows = false;
            this.gridWybKlientaStanWod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWybKlientaStanWod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStwod,
            this.idKlientStWod,
            this.nazwaFirmyStWod,
            this.imieStWod,
            this.nazwiskoStWod});
            this.gridWybKlientaStanWod.Location = new System.Drawing.Point(6, 21);
            this.gridWybKlientaStanWod.Name = "gridWybKlientaStanWod";
            this.gridWybKlientaStanWod.ReadOnly = true;
            this.gridWybKlientaStanWod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWybKlientaStanWod.Size = new System.Drawing.Size(483, 183);
            this.gridWybKlientaStanWod.TabIndex = 0;
            this.gridWybKlientaStanWod.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWybKlientaStanWod_CellContentClick);
            // 
            // idStwod
            // 
            this.idStwod.DataPropertyName = "id";
            this.idStwod.HeaderText = "id";
            this.idStwod.Name = "idStwod";
            this.idStwod.ReadOnly = true;
            this.idStwod.Width = 50;
            // 
            // idKlientStWod
            // 
            this.idKlientStWod.DataPropertyName = "idklient";
            this.idKlientStWod.HeaderText = "id klient";
            this.idKlientStWod.Name = "idKlientStWod";
            this.idKlientStWod.ReadOnly = true;
            this.idKlientStWod.Width = 80;
            // 
            // nazwaFirmyStWod
            // 
            this.nazwaFirmyStWod.DataPropertyName = "nazwaFirmy";
            this.nazwaFirmyStWod.HeaderText = "nazwafirmy";
            this.nazwaFirmyStWod.Name = "nazwaFirmyStWod";
            this.nazwaFirmyStWod.ReadOnly = true;
            // 
            // imieStWod
            // 
            this.imieStWod.DataPropertyName = "imie";
            this.imieStWod.HeaderText = "Imię";
            this.imieStWod.Name = "imieStWod";
            this.imieStWod.ReadOnly = true;
            this.imieStWod.Width = 80;
            // 
            // nazwiskoStWod
            // 
            this.nazwiskoStWod.DataPropertyName = "nazwisko";
            this.nazwiskoStWod.HeaderText = "nazwisko";
            this.nazwiskoStWod.Name = "nazwiskoStWod";
            this.nazwiskoStWod.ReadOnly = true;
            this.nazwiskoStWod.Width = 125;
            // 
            // lbNazwaKlientaStanWod
            // 
            this.lbNazwaKlientaStanWod.AutoSize = true;
            this.lbNazwaKlientaStanWod.Location = new System.Drawing.Point(107, 86);
            this.lbNazwaKlientaStanWod.Name = "lbNazwaKlientaStanWod";
            this.lbNazwaKlientaStanWod.Size = new System.Drawing.Size(0, 16);
            this.lbNazwaKlientaStanWod.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(555, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Stan Wodomierza";
            // 
            // poleWskazanieWod
            // 
            this.poleWskazanieWod.Location = new System.Drawing.Point(549, 39);
            this.poleWskazanieWod.Name = "poleWskazanieWod";
            this.poleWskazanieWod.Size = new System.Drawing.Size(100, 22);
            this.poleWskazanieWod.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nr seryjny";
            // 
            // poleNrSeryjny
            // 
            this.poleNrSeryjny.Location = new System.Drawing.Point(408, 37);
            this.poleNrSeryjny.Name = "poleNrSeryjny";
            this.poleNrSeryjny.Size = new System.Drawing.Size(100, 22);
            this.poleNrSeryjny.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nr wodomierza";
            // 
            // poleNrWod
            // 
            this.poleNrWod.Location = new System.Drawing.Point(241, 39);
            this.poleNrWod.Name = "poleNrWod";
            this.poleNrWod.Size = new System.Drawing.Size(100, 22);
            this.poleNrWod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr Klienta";
            // 
            // poleNrKlientaStWod
            // 
            this.poleNrKlientaStWod.Location = new System.Drawing.Point(107, 39);
            this.poleNrKlientaStWod.Name = "poleNrKlientaStWod";
            this.poleNrKlientaStWod.Size = new System.Drawing.Size(100, 22);
            this.poleNrKlientaStWod.TabIndex = 5;
            // 
            // btWrocDodajStanWod
            // 
            this.btWrocDodajStanWod.Location = new System.Drawing.Point(829, 344);
            this.btWrocDodajStanWod.Name = "btWrocDodajStanWod";
            this.btWrocDodajStanWod.Size = new System.Drawing.Size(75, 23);
            this.btWrocDodajStanWod.TabIndex = 4;
            this.btWrocDodajStanWod.Text = "Wróć";
            this.btWrocDodajStanWod.UseVisualStyleBackColor = true;
            this.btWrocDodajStanWod.Click += new System.EventHandler(this.btWrocDodajStanWod_Click);
            // 
            // btZapiszStanWod
            // 
            this.btZapiszStanWod.Location = new System.Drawing.Point(910, 344);
            this.btZapiszStanWod.Name = "btZapiszStanWod";
            this.btZapiszStanWod.Size = new System.Drawing.Size(75, 23);
            this.btZapiszStanWod.TabIndex = 3;
            this.btZapiszStanWod.Text = "Zapisz";
            this.btZapiszStanWod.UseVisualStyleBackColor = true;
            this.btZapiszStanWod.Click += new System.EventHandler(this.btZapiszStanWod_Click);
            // 
            // poleDataOdczytuWod
            // 
            this.poleDataOdczytuWod.Location = new System.Drawing.Point(731, 40);
            this.poleDataOdczytuWod.Name = "poleDataOdczytuWod";
            this.poleDataOdczytuWod.Size = new System.Drawing.Size(200, 22);
            this.poleDataOdczytuWod.TabIndex = 2;
            // 
            // dodajKlientaStanWod
            // 
            this.dodajKlientaStanWod.Location = new System.Drawing.Point(6, 39);
            this.dodajKlientaStanWod.Name = "dodajKlientaStanWod";
            this.dodajKlientaStanWod.Size = new System.Drawing.Size(95, 23);
            this.dodajKlientaStanWod.TabIndex = 0;
            this.dodajKlientaStanWod.Text = "Nr klienta";
            this.dodajKlientaStanWod.UseVisualStyleBackColor = true;
            this.dodajKlientaStanWod.Click += new System.EventHandler(this.dodajKlientaStanWod_Click);
            // 
            // gridWodomierz
            // 
            this.gridWodomierz.AllowUserToAddRows = false;
            this.gridWodomierz.AllowUserToDeleteRows = false;
            this.gridWodomierz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWodomierz.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridWodomierz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridWodomierz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWodomierz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwodomierz,
            this.idKlientWodomierz,
            this.idWodomierz1,
            this.nrIdentyfikacyjny,
            this.wskazanieWodomierz,
            this.dataOdczytu});
            this.gridWodomierz.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridWodomierz.Location = new System.Drawing.Point(7, 7);
            this.gridWodomierz.MultiSelect = false;
            this.gridWodomierz.Name = "gridWodomierz";
            this.gridWodomierz.ReadOnly = true;
            this.gridWodomierz.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridWodomierz.RowHeadersWidth = 20;
            this.gridWodomierz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWodomierz.Size = new System.Drawing.Size(994, 420);
            this.gridWodomierz.TabIndex = 11;
            this.gridWodomierz.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btPoprawStanWod_Click);
            // 
            // idwodomierz
            // 
            this.idwodomierz.DataPropertyName = "id";
            this.idwodomierz.HeaderText = "id";
            this.idwodomierz.Name = "idwodomierz";
            this.idwodomierz.ReadOnly = true;
            this.idwodomierz.Visible = false;
            // 
            // idKlientWodomierz
            // 
            this.idKlientWodomierz.DataPropertyName = "idklient";
            this.idKlientWodomierz.HeaderText = "Nr klienta";
            this.idKlientWodomierz.Name = "idKlientWodomierz";
            this.idKlientWodomierz.ReadOnly = true;
            this.idKlientWodomierz.Width = 120;
            // 
            // idWodomierz1
            // 
            this.idWodomierz1.DataPropertyName = "idwodomierz";
            this.idWodomierz1.HeaderText = "Nr wodomierz";
            this.idWodomierz1.Name = "idWodomierz1";
            this.idWodomierz1.ReadOnly = true;
            this.idWodomierz1.Width = 150;
            // 
            // nrIdentyfikacyjny
            // 
            this.nrIdentyfikacyjny.DataPropertyName = "nridentyfikacyjny";
            this.nrIdentyfikacyjny.HeaderText = "Nr seryjny";
            this.nrIdentyfikacyjny.Name = "nrIdentyfikacyjny";
            this.nrIdentyfikacyjny.ReadOnly = true;
            this.nrIdentyfikacyjny.Width = 150;
            // 
            // wskazanieWodomierz
            // 
            this.wskazanieWodomierz.DataPropertyName = "wskazanieWodomierza";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.wskazanieWodomierz.DefaultCellStyle = dataGridViewCellStyle1;
            this.wskazanieWodomierz.HeaderText = "Stan wodomierza";
            this.wskazanieWodomierz.Name = "wskazanieWodomierz";
            this.wskazanieWodomierz.ReadOnly = true;
            this.wskazanieWodomierz.Width = 170;
            // 
            // dataOdczytu
            // 
            this.dataOdczytu.DataPropertyName = "dataOdczytu";
            this.dataOdczytu.HeaderText = "Data odczytu";
            this.dataOdczytu.Name = "dataOdczytu";
            this.dataOdczytu.ReadOnly = true;
            this.dataOdczytu.Width = 170;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(956, 525);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(15, 15);
            this.button7.TabIndex = 2;
            this.button7.Text = "P";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(984, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 15);
            this.button2.TabIndex = 10;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(970, 525);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(15, 15);
            this.button8.TabIndex = 3;
            this.button8.Text = "U";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grPozFaktur);
            this.tabPage4.Controls.Add(this.dataFiltra);
            this.tabPage4.Controls.Add(this.btFiltr);
            this.tabPage4.Controls.Add(this.btUsunFakture);
            this.tabPage4.Controls.Add(this.btPoprawFakture);
            this.tabPage4.Controls.Add(this.btDodajFakture);
            this.tabPage4.Controls.Add(this.gridFaktury);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1009, 462);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Należności";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grPozFaktur
            // 
            this.grPozFaktur.Controls.Add(this.grupaWybWodFakt);
            this.grPozFaktur.Controls.Add(this.grWyboruKlientaDoFaktury);
            this.grPozFaktur.Controls.Add(this.lbNazwaFirmy);
            this.grPozFaktur.Controls.Add(this.lbTelefon);
            this.grPozFaktur.Controls.Add(this.lbNazwaBanku);
            this.grPozFaktur.Controls.Add(this.lbAdresKlienta);
            this.grPozFaktur.Controls.Add(this.poleFormaPlatnosci);
            this.grPozFaktur.Controls.Add(this.btWybWodFakt);
            this.grPozFaktur.Controls.Add(this.lbNazwaKlienta);
            this.grPozFaktur.Controls.Add(this.wyborTerminu);
            this.grPozFaktur.Controls.Add(this.button15);
            this.grPozFaktur.Controls.Add(this.poleStawkaVat);
            this.grPozFaktur.Controls.Add(this.btWybierKlientaDoFaktury);
            this.grPozFaktur.Controls.Add(this.poleNetto);
            this.grPozFaktur.Controls.Add(this.lbilosc);
            this.grPozFaktur.Controls.Add(this.label6);
            this.grPozFaktur.Controls.Add(this.poleNrKlienta);
            this.grPozFaktur.Controls.Add(this.label5);
            this.grPozFaktur.Controls.Add(this.poleIlosc);
            this.grPozFaktur.Controls.Add(this.label7);
            this.grPozFaktur.Controls.Add(this.label3);
            this.grPozFaktur.Controls.Add(this.label2);
            this.grPozFaktur.Controls.Add(this.poleNrWodomierza);
            this.grPozFaktur.Controls.Add(this.label1);
            this.grPozFaktur.Controls.Add(this.btWrocFaktura);
            this.grPozFaktur.Controls.Add(this.btZapiszFakture);
            this.grPozFaktur.Controls.Add(this.gridPozycjiFaktury);
            this.grPozFaktur.Location = new System.Drawing.Point(56, 59);
            this.grPozFaktur.Name = "grPozFaktur";
            this.grPozFaktur.Size = new System.Drawing.Size(899, 368);
            this.grPozFaktur.TabIndex = 8;
            this.grPozFaktur.TabStop = false;
            this.grPozFaktur.Text = "Dane faktury nr xxx";
            // 
            // grupaWybWodFakt
            // 
            this.grupaWybWodFakt.Controls.Add(this.btWybWod);
            this.grupaWybWodFakt.Controls.Add(this.btWrocWod);
            this.grupaWybWodFakt.Controls.Add(this.gridWyborWodomierz);
            this.grupaWybWodFakt.Location = new System.Drawing.Point(115, 94);
            this.grupaWybWodFakt.Name = "grupaWybWodFakt";
            this.grupaWybWodFakt.Size = new System.Drawing.Size(617, 227);
            this.grupaWybWodFakt.TabIndex = 29;
            this.grupaWybWodFakt.TabStop = false;
            this.grupaWybWodFakt.Text = "Wybierz wodomierz do faktury";
            // 
            // btWybWod
            // 
            this.btWybWod.Location = new System.Drawing.Point(515, 193);
            this.btWybWod.Name = "btWybWod";
            this.btWybWod.Size = new System.Drawing.Size(75, 23);
            this.btWybWod.TabIndex = 2;
            this.btWybWod.Text = "Wybierz";
            this.btWybWod.UseVisualStyleBackColor = true;
            this.btWybWod.Click += new System.EventHandler(this.btWybWod_Click);
            // 
            // btWrocWod
            // 
            this.btWrocWod.Location = new System.Drawing.Point(428, 193);
            this.btWrocWod.Name = "btWrocWod";
            this.btWrocWod.Size = new System.Drawing.Size(75, 23);
            this.btWrocWod.TabIndex = 1;
            this.btWrocWod.Text = "Wróć";
            this.btWrocWod.UseVisualStyleBackColor = true;
            this.btWrocWod.Click += new System.EventHandler(this.btWrocWod_Click);
            // 
            // gridWyborWodomierz
            // 
            this.gridWyborWodomierz.AllowUserToAddRows = false;
            this.gridWyborWodomierz.AllowUserToDeleteRows = false;
            this.gridWyborWodomierz.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridWyborWodomierz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWyborWodomierz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWodomierz2,
            this.nrIdentyfikacyjny1,
            this.wskazanieWodomierza,
            this.dataOdczytu1});
            this.gridWyborWodomierz.Location = new System.Drawing.Point(9, 27);
            this.gridWyborWodomierz.Name = "gridWyborWodomierz";
            this.gridWyborWodomierz.ReadOnly = true;
            this.gridWyborWodomierz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWyborWodomierz.Size = new System.Drawing.Size(583, 154);
            this.gridWyborWodomierz.TabIndex = 0;
            this.gridWyborWodomierz.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridWyborWodomierz_CellDoubleClick);
            // 
            // idWodomierz2
            // 
            this.idWodomierz2.DataPropertyName = "idWodomierz";
            this.idWodomierz2.HeaderText = "Nr wodomierza";
            this.idWodomierz2.Name = "idWodomierz2";
            this.idWodomierz2.ReadOnly = true;
            this.idWodomierz2.Width = 70;
            // 
            // nrIdentyfikacyjny1
            // 
            this.nrIdentyfikacyjny1.DataPropertyName = "nrIdentyfikacyjny";
            this.nrIdentyfikacyjny1.HeaderText = "Nr identyfikacyjny";
            this.nrIdentyfikacyjny1.Name = "nrIdentyfikacyjny1";
            this.nrIdentyfikacyjny1.ReadOnly = true;
            this.nrIdentyfikacyjny1.Width = 150;
            // 
            // wskazanieWodomierza
            // 
            this.wskazanieWodomierza.DataPropertyName = "wskazanieWodomierza";
            this.wskazanieWodomierza.HeaderText = "Wskazanie";
            this.wskazanieWodomierza.Name = "wskazanieWodomierza";
            this.wskazanieWodomierza.ReadOnly = true;
            this.wskazanieWodomierza.Width = 150;
            // 
            // dataOdczytu1
            // 
            this.dataOdczytu1.DataPropertyName = "dataOdczytu";
            this.dataOdczytu1.HeaderText = "Data odczytu";
            this.dataOdczytu1.Name = "dataOdczytu1";
            this.dataOdczytu1.ReadOnly = true;
            this.dataOdczytu1.Width = 130;
            // 
            // grWyboruKlientaDoFaktury
            // 
            this.grWyboruKlientaDoFaktury.Controls.Add(this.dataGridView1);
            this.grWyboruKlientaDoFaktury.Controls.Add(this.btWrocWyborKlientaDoFaktury);
            this.grWyboruKlientaDoFaktury.Controls.Add(this.btWybierzKlientaDoFaktury);
            this.grWyboruKlientaDoFaktury.Location = new System.Drawing.Point(124, 63);
            this.grWyboruKlientaDoFaktury.Name = "grWyboruKlientaDoFaktury";
            this.grWyboruKlientaDoFaktury.Size = new System.Drawing.Size(600, 200);
            this.grWyboruKlientaDoFaktury.TabIndex = 29;
            this.grWyboruKlientaDoFaktury.TabStop = false;
            this.grWyboruKlientaDoFaktury.Text = "Wybierz klienta do faktury";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.idKlient2,
            this.nazwa2,
            this.nazwaFirmy1,
            this.adres1,
            this.telefon1,
            this.imie1,
            this.nazwisko2,
            this.nazwaBanku});
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 136);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "id";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Visible = false;
            // 
            // idKlient2
            // 
            this.idKlient2.DataPropertyName = "idKlient";
            this.idKlient2.HeaderText = "Nr klienta";
            this.idKlient2.Name = "idKlient2";
            this.idKlient2.ReadOnly = true;
            // 
            // nazwa2
            // 
            this.nazwa2.DataPropertyName = "nazwa";
            this.nazwa2.HeaderText = "Nazwa";
            this.nazwa2.Name = "nazwa2";
            this.nazwa2.ReadOnly = true;
            this.nazwa2.Width = 200;
            // 
            // nazwaFirmy1
            // 
            this.nazwaFirmy1.DataPropertyName = "nazwaFirmy";
            this.nazwaFirmy1.HeaderText = "Nazwa firmy";
            this.nazwaFirmy1.Name = "nazwaFirmy1";
            this.nazwaFirmy1.ReadOnly = true;
            this.nazwaFirmy1.Width = 200;
            // 
            // adres1
            // 
            this.adres1.DataPropertyName = "adres";
            this.adres1.HeaderText = "adres";
            this.adres1.Name = "adres1";
            this.adres1.ReadOnly = true;
            this.adres1.Visible = false;
            // 
            // telefon1
            // 
            this.telefon1.DataPropertyName = "telefon";
            this.telefon1.HeaderText = "telefon";
            this.telefon1.Name = "telefon1";
            this.telefon1.ReadOnly = true;
            this.telefon1.Visible = false;
            // 
            // imie1
            // 
            this.imie1.DataPropertyName = "imie";
            this.imie1.HeaderText = "imie";
            this.imie1.Name = "imie1";
            this.imie1.ReadOnly = true;
            this.imie1.Visible = false;
            // 
            // nazwisko2
            // 
            this.nazwisko2.DataPropertyName = "nazwisko";
            this.nazwisko2.HeaderText = "nazwisko";
            this.nazwisko2.Name = "nazwisko2";
            this.nazwisko2.ReadOnly = true;
            this.nazwisko2.Visible = false;
            // 
            // nazwaBanku
            // 
            this.nazwaBanku.DataPropertyName = "nazwaBanku";
            this.nazwaBanku.HeaderText = "nazwaBanku";
            this.nazwaBanku.Name = "nazwaBanku";
            this.nazwaBanku.ReadOnly = true;
            this.nazwaBanku.Visible = false;
            // 
            // btWrocWyborKlientaDoFaktury
            // 
            this.btWrocWyborKlientaDoFaktury.Location = new System.Drawing.Point(421, 172);
            this.btWrocWyborKlientaDoFaktury.Name = "btWrocWyborKlientaDoFaktury";
            this.btWrocWyborKlientaDoFaktury.Size = new System.Drawing.Size(75, 23);
            this.btWrocWyborKlientaDoFaktury.TabIndex = 2;
            this.btWrocWyborKlientaDoFaktury.Text = "Wróć";
            this.btWrocWyborKlientaDoFaktury.UseVisualStyleBackColor = true;
            this.btWrocWyborKlientaDoFaktury.Click += new System.EventHandler(this.btWrocWyborKlientaDoFaktury_Click);
            // 
            // btWybierzKlientaDoFaktury
            // 
            this.btWybierzKlientaDoFaktury.Location = new System.Drawing.Point(508, 172);
            this.btWybierzKlientaDoFaktury.Name = "btWybierzKlientaDoFaktury";
            this.btWybierzKlientaDoFaktury.Size = new System.Drawing.Size(75, 23);
            this.btWybierzKlientaDoFaktury.TabIndex = 1;
            this.btWybierzKlientaDoFaktury.Text = "Wybierz";
            this.btWybierzKlientaDoFaktury.UseVisualStyleBackColor = true;
            this.btWybierzKlientaDoFaktury.Click += new System.EventHandler(this.btWybierzKlientaDoFaktury_Click);
            // 
            // lbNazwaFirmy
            // 
            this.lbNazwaFirmy.AutoSize = true;
            this.lbNazwaFirmy.Location = new System.Drawing.Point(246, 95);
            this.lbNazwaFirmy.Name = "lbNazwaFirmy";
            this.lbNazwaFirmy.Size = new System.Drawing.Size(105, 16);
            this.lbNazwaFirmy.TabIndex = 33;
            this.lbNazwaFirmy.Text = "lbNazwaFirmy";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(757, 95);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(74, 16);
            this.lbTelefon.TabIndex = 32;
            this.lbTelefon.Text = "lbTelefon";
            // 
            // lbNazwaBanku
            // 
            this.lbNazwaBanku.AutoSize = true;
            this.lbNazwaBanku.Location = new System.Drawing.Point(598, 95);
            this.lbNazwaBanku.Name = "lbNazwaBanku";
            this.lbNazwaBanku.Size = new System.Drawing.Size(110, 16);
            this.lbNazwaBanku.TabIndex = 31;
            this.lbNazwaBanku.Text = "lbNazwaBanku";
            // 
            // lbAdresKlienta
            // 
            this.lbAdresKlienta.AutoSize = true;
            this.lbAdresKlienta.Location = new System.Drawing.Point(426, 95);
            this.lbAdresKlienta.Name = "lbAdresKlienta";
            this.lbAdresKlienta.Size = new System.Drawing.Size(109, 16);
            this.lbAdresKlienta.TabIndex = 30;
            this.lbAdresKlienta.Text = "lbAdresKlienta";
            // 
            // poleFormaPlatnosci
            // 
            this.poleFormaPlatnosci.FormattingEnabled = true;
            this.poleFormaPlatnosci.Items.AddRange(new object[] {
            "Gotówka",
            "Przelew",
            "Rozliczone"});
            this.poleFormaPlatnosci.Location = new System.Drawing.Point(603, 50);
            this.poleFormaPlatnosci.Name = "poleFormaPlatnosci";
            this.poleFormaPlatnosci.Size = new System.Drawing.Size(121, 24);
            this.poleFormaPlatnosci.TabIndex = 28;
            // 
            // btWybWodFakt
            // 
            this.btWybWodFakt.Location = new System.Drawing.Point(260, 50);
            this.btWybWodFakt.Name = "btWybWodFakt";
            this.btWybWodFakt.Size = new System.Drawing.Size(52, 23);
            this.btWybWodFakt.TabIndex = 27;
            this.btWybWodFakt.Text = "wod";
            this.btWybWodFakt.UseVisualStyleBackColor = true;
            this.btWybWodFakt.Click += new System.EventHandler(this.btWybWodFakt_Click);
            // 
            // lbNazwaKlienta
            // 
            this.lbNazwaKlienta.AutoSize = true;
            this.lbNazwaKlienta.Location = new System.Drawing.Point(57, 95);
            this.lbNazwaKlienta.Name = "lbNazwaKlienta";
            this.lbNazwaKlienta.Size = new System.Drawing.Size(114, 16);
            this.lbNazwaKlienta.TabIndex = 26;
            this.lbNazwaKlienta.Text = "lbNazwaKlienta";
            // 
            // wyborTerminu
            // 
            this.wyborTerminu.Location = new System.Drawing.Point(446, 50);
            this.wyborTerminu.Name = "wyborTerminu";
            this.wyborTerminu.Size = new System.Drawing.Size(128, 22);
            this.wyborTerminu.TabIndex = 25;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(14, 160);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(141, 23);
            this.button15.TabIndex = 24;
            this.button15.Text = "Oblicz zużycie";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // poleStawkaVat
            // 
            this.poleStawkaVat.FormattingEnabled = true;
            this.poleStawkaVat.Items.AddRange(new object[] {
            "22",
            "23"});
            this.poleStawkaVat.Location = new System.Drawing.Point(756, 50);
            this.poleStawkaVat.Name = "poleStawkaVat";
            this.poleStawkaVat.Size = new System.Drawing.Size(121, 24);
            this.poleStawkaVat.TabIndex = 23;
            // 
            // btWybierKlientaDoFaktury
            // 
            this.btWybierKlientaDoFaktury.Location = new System.Drawing.Point(14, 49);
            this.btWybierKlientaDoFaktury.Name = "btWybierKlientaDoFaktury";
            this.btWybierKlientaDoFaktury.Size = new System.Drawing.Size(114, 23);
            this.btWybierKlientaDoFaktury.TabIndex = 22;
            this.btWybierKlientaDoFaktury.Text = "Wybór klienta";
            this.btWybierKlientaDoFaktury.UseVisualStyleBackColor = true;
            this.btWybierKlientaDoFaktury.Click += new System.EventHandler(this.btWybierKlientaDoFaktury_Click);
            // 
            // poleNetto
            // 
            this.poleNetto.Location = new System.Drawing.Point(315, 160);
            this.poleNetto.Name = "poleNetto";
            this.poleNetto.Size = new System.Drawing.Size(100, 22);
            this.poleNetto.TabIndex = 21;
            // 
            // lbilosc
            // 
            this.lbilosc.AutoSize = true;
            this.lbilosc.Location = new System.Drawing.Point(211, 140);
            this.lbilosc.Name = "lbilosc";
            this.lbilosc.Size = new System.Drawing.Size(41, 16);
            this.lbilosc.TabIndex = 20;
            this.lbilosc.Text = "Ilość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Netto";
            // 
            // poleNrKlienta
            // 
            this.poleNrKlienta.Location = new System.Drawing.Point(134, 50);
            this.poleNrKlienta.Name = "poleNrKlienta";
            this.poleNrKlienta.Size = new System.Drawing.Size(99, 22);
            this.poleNrKlienta.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nr klienta";
            // 
            // poleIlosc
            // 
            this.poleIlosc.Location = new System.Drawing.Point(180, 160);
            this.poleIlosc.Name = "poleIlosc";
            this.poleIlosc.Size = new System.Drawing.Size(100, 22);
            this.poleIlosc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Forma płatności";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stawka VAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Termin płatności";
            // 
            // poleNrWodomierza
            // 
            this.poleNrWodomierza.Location = new System.Drawing.Point(318, 50);
            this.poleNrWodomierza.Name = "poleNrWodomierza";
            this.poleNrWodomierza.Size = new System.Drawing.Size(100, 22);
            this.poleNrWodomierza.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wodomierz";
            // 
            // btWrocFaktura
            // 
            this.btWrocFaktura.Location = new System.Drawing.Point(713, 334);
            this.btWrocFaktura.Name = "btWrocFaktura";
            this.btWrocFaktura.Size = new System.Drawing.Size(75, 23);
            this.btWrocFaktura.TabIndex = 9;
            this.btWrocFaktura.Text = "Wróć";
            this.btWrocFaktura.UseVisualStyleBackColor = true;
            this.btWrocFaktura.Click += new System.EventHandler(this.btWrocFaktura_Click);
            // 
            // btZapiszFakture
            // 
            this.btZapiszFakture.Location = new System.Drawing.Point(800, 334);
            this.btZapiszFakture.Name = "btZapiszFakture";
            this.btZapiszFakture.Size = new System.Drawing.Size(75, 23);
            this.btZapiszFakture.TabIndex = 8;
            this.btZapiszFakture.Text = "Zapisz";
            this.btZapiszFakture.UseVisualStyleBackColor = true;
            this.btZapiszFakture.Click += new System.EventHandler(this.btZapiszFakture_Click);
            // 
            // gridPozycjiFaktury
            // 
            this.gridPozycjiFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPozycjiFaktury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd});
            this.gridPozycjiFaktury.Location = new System.Drawing.Point(14, 272);
            this.gridPozycjiFaktury.Name = "gridPozycjiFaktury";
            this.gridPozycjiFaktury.Size = new System.Drawing.Size(55, 85);
            this.gridPozycjiFaktury.TabIndex = 7;
            // 
            // idd
            // 
            this.idd.DataPropertyName = "id";
            this.idd.HeaderText = "id";
            this.idd.Name = "idd";
            // 
            // dataFiltra
            // 
            this.dataFiltra.AllowDrop = true;
            this.dataFiltra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataFiltra.Location = new System.Drawing.Point(330, 434);
            this.dataFiltra.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dataFiltra.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dataFiltra.Name = "dataFiltra";
            this.dataFiltra.Size = new System.Drawing.Size(284, 22);
            this.dataFiltra.TabIndex = 10;
            // 
            // btFiltr
            // 
            this.btFiltr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFiltr.Location = new System.Drawing.Point(249, 433);
            this.btFiltr.Name = "btFiltr";
            this.btFiltr.Size = new System.Drawing.Size(75, 23);
            this.btFiltr.TabIndex = 12;
            this.btFiltr.Text = "Filtr";
            this.btFiltr.UseVisualStyleBackColor = true;
            // 
            // btUsunFakture
            // 
            this.btUsunFakture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUsunFakture.Location = new System.Drawing.Point(168, 433);
            this.btUsunFakture.Name = "btUsunFakture";
            this.btUsunFakture.Size = new System.Drawing.Size(75, 23);
            this.btUsunFakture.TabIndex = 11;
            this.btUsunFakture.Text = "Usuń";
            this.btUsunFakture.UseVisualStyleBackColor = true;
            this.btUsunFakture.Click += new System.EventHandler(this.btUsunFakture_Click);
            // 
            // btPoprawFakture
            // 
            this.btPoprawFakture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPoprawFakture.Location = new System.Drawing.Point(87, 433);
            this.btPoprawFakture.Name = "btPoprawFakture";
            this.btPoprawFakture.Size = new System.Drawing.Size(75, 23);
            this.btPoprawFakture.TabIndex = 10;
            this.btPoprawFakture.Text = "Popraw";
            this.btPoprawFakture.UseVisualStyleBackColor = true;
            this.btPoprawFakture.Click += new System.EventHandler(this.btPoprawFakture_Click);
            // 
            // btDodajFakture
            // 
            this.btDodajFakture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDodajFakture.Location = new System.Drawing.Point(6, 433);
            this.btDodajFakture.Name = "btDodajFakture";
            this.btDodajFakture.Size = new System.Drawing.Size(75, 23);
            this.btDodajFakture.TabIndex = 9;
            this.btDodajFakture.Text = "Dodaj";
            this.btDodajFakture.UseVisualStyleBackColor = true;
            this.btDodajFakture.Click += new System.EventHandler(this.btDodajFakture_Click);
            // 
            // gridFaktury
            // 
            this.gridFaktury.AllowUserToAddRows = false;
            this.gridFaktury.AllowUserToDeleteRows = false;
            this.gridFaktury.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFaktury.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridFaktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFaktury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idKlient,
            this.nrFaktury,
            this.imieN,
            this.nazwiskoN,
            this.dataWystawieniaN,
            this.terminPlatnosciN,
            this.nettoN,
            this.nazwaFirmyN,
            this.formaPlatnosciN,
            this.adresKlientN,
            this.nazwaBankuN,
            this.telefonN,
            this.symbolVatN});
            this.gridFaktury.Location = new System.Drawing.Point(6, 7);
            this.gridFaktury.MultiSelect = false;
            this.gridFaktury.Name = "gridFaktury";
            this.gridFaktury.ReadOnly = true;
            this.gridFaktury.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFaktury.Size = new System.Drawing.Size(997, 420);
            this.gridFaktury.TabIndex = 6;
            this.gridFaktury.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFaktury_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idKlient
            // 
            this.idKlient.DataPropertyName = "idKlient";
            this.idKlient.HeaderText = "idKlient";
            this.idKlient.Name = "idKlient";
            this.idKlient.ReadOnly = true;
            this.idKlient.Visible = false;
            this.idKlient.Width = 160;
            // 
            // nrFaktury
            // 
            this.nrFaktury.DataPropertyName = "nrFaktury";
            this.nrFaktury.HeaderText = "Nr faktury";
            this.nrFaktury.Name = "nrFaktury";
            this.nrFaktury.ReadOnly = true;
            this.nrFaktury.Width = 125;
            // 
            // imieN
            // 
            this.imieN.DataPropertyName = "imie";
            this.imieN.HeaderText = "Imie";
            this.imieN.Name = "imieN";
            this.imieN.ReadOnly = true;
            this.imieN.Width = 120;
            // 
            // nazwiskoN
            // 
            this.nazwiskoN.DataPropertyName = "nazwisko";
            this.nazwiskoN.HeaderText = "Nazwisko";
            this.nazwiskoN.Name = "nazwiskoN";
            this.nazwiskoN.ReadOnly = true;
            this.nazwiskoN.Width = 180;
            // 
            // dataWystawieniaN
            // 
            this.dataWystawieniaN.DataPropertyName = "dataWystawienia";
            this.dataWystawieniaN.HeaderText = "Data wystawienia";
            this.dataWystawieniaN.Name = "dataWystawieniaN";
            this.dataWystawieniaN.ReadOnly = true;
            // 
            // terminPlatnosciN
            // 
            this.terminPlatnosciN.DataPropertyName = "terminPlatnosci";
            this.terminPlatnosciN.HeaderText = "Termin płatności";
            this.terminPlatnosciN.Name = "terminPlatnosciN";
            this.terminPlatnosciN.ReadOnly = true;
            // 
            // nettoN
            // 
            this.nettoN.DataPropertyName = "netto";
            this.nettoN.HeaderText = "Netto";
            this.nettoN.Name = "nettoN";
            this.nettoN.ReadOnly = true;
            // 
            // nazwaFirmyN
            // 
            this.nazwaFirmyN.DataPropertyName = "nazwaFirmy";
            this.nazwaFirmyN.HeaderText = "Nazwa firmy";
            this.nazwaFirmyN.Name = "nazwaFirmyN";
            this.nazwaFirmyN.ReadOnly = true;
            // 
            // formaPlatnosciN
            // 
            this.formaPlatnosciN.DataPropertyName = "formaPlatnosci";
            this.formaPlatnosciN.HeaderText = "Forma płatności";
            this.formaPlatnosciN.Name = "formaPlatnosciN";
            this.formaPlatnosciN.ReadOnly = true;
            // 
            // adresKlientN
            // 
            this.adresKlientN.DataPropertyName = "adresKlient";
            this.adresKlientN.HeaderText = "Adres";
            this.adresKlientN.Name = "adresKlientN";
            this.adresKlientN.ReadOnly = true;
            // 
            // nazwaBankuN
            // 
            this.nazwaBankuN.DataPropertyName = "nazwaBanku";
            this.nazwaBankuN.HeaderText = "nazwaBanku";
            this.nazwaBankuN.Name = "nazwaBankuN";
            this.nazwaBankuN.ReadOnly = true;
            this.nazwaBankuN.Visible = false;
            // 
            // telefonN
            // 
            this.telefonN.DataPropertyName = "telefon";
            this.telefonN.HeaderText = "telefon";
            this.telefonN.Name = "telefonN";
            this.telefonN.ReadOnly = true;
            this.telefonN.Visible = false;
            // 
            // symbolVatN
            // 
            this.symbolVatN.DataPropertyName = "symbolVat";
            this.symbolVatN.HeaderText = "symbolVatN";
            this.symbolVatN.Name = "symbolVatN";
            this.symbolVatN.ReadOnly = true;
            this.symbolVatN.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridCennik);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1009, 462);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cennik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridCennik
            // 
            this.gridCennik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCennik.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCennik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCennik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCennik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.txtAge,
            this.txtsymbolVat});
            this.gridCennik.Location = new System.Drawing.Point(34, 30);
            this.gridCennik.Name = "gridCennik";
            this.gridCennik.Size = new System.Drawing.Size(927, 405);
            this.gridCennik.TabIndex = 1;
            this.gridCennik.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCennik_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dataOd";
            this.dataGridViewTextBoxColumn2.HeaderText = "dataOd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataDo";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataDo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // txtAge
            // 
            this.txtAge.DataPropertyName = "netto";
            this.txtAge.HeaderText = "netto";
            this.txtAge.Name = "txtAge";
            // 
            // txtsymbolVat
            // 
            this.txtsymbolVat.DataPropertyName = "symbolVat";
            this.txtsymbolVat.HeaderText = "symbolVat";
            this.txtsymbolVat.Name = "txtsymbolVat";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.GridPracownicy);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1009, 462);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ustawienia";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // GridPracownicy
            // 
            this.GridPracownicy.BackgroundColor = System.Drawing.Color.White;
            this.GridPracownicy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEmployeeID,
            this.txtName,
            this.txtOffice,
            this.txtlogin,
            this.txtPassword,
            this.txtczyAdmin,
            this.txtaktywny,
            this.PositionID});
            this.GridPracownicy.Location = new System.Drawing.Point(41, 14);
            this.GridPracownicy.Name = "GridPracownicy";
            this.GridPracownicy.RowHeadersWidth = 20;
            this.GridPracownicy.Size = new System.Drawing.Size(946, 423);
            this.GridPracownicy.TabIndex = 12;
            this.GridPracownicy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPracownicy_CellValueChanged);
            this.GridPracownicy.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridPracownicy_EditingControlShowing);
            this.GridPracownicy.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridPracownicy_UserDeletingRow);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.DataPropertyName = "EmployeeID";
            this.txtEmployeeID.HeaderText = "EmployeeID";
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Imie";
            this.txtName.Name = "txtName";
            this.txtName.Width = 220;
            // 
            // txtOffice
            // 
            this.txtOffice.DataPropertyName = "Office";
            this.txtOffice.HeaderText = "Nazwisko";
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Width = 220;
            // 
            // txtlogin
            // 
            this.txtlogin.DataPropertyName = "Login";
            this.txtlogin.HeaderText = "Login";
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Width = 170;
            // 
            // txtPassword
            // 
            this.txtPassword.DataPropertyName = "Password";
            this.txtPassword.HeaderText = "Hasło";
            this.txtPassword.Name = "txtPassword";
            // 
            // txtczyAdmin
            // 
            this.txtczyAdmin.DataPropertyName = "czyAdmin";
            this.txtczyAdmin.HeaderText = "Admin";
            this.txtczyAdmin.Name = "txtczyAdmin";
            this.txtczyAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtczyAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtczyAdmin.Width = 65;
            // 
            // txtaktywny
            // 
            this.txtaktywny.DataPropertyName = "Aktywny";
            this.txtaktywny.HeaderText = "Aktywny";
            this.txtaktywny.Name = "txtaktywny";
            this.txtaktywny.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtaktywny.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtaktywny.Width = 70;
            // 
            // PositionID
            // 
            this.PositionID.DataPropertyName = "PositionID";
            this.PositionID.HeaderText = "poz";
            this.PositionID.Name = "PositionID";
            this.PositionID.Visible = false;
            // 
            // ileKartLb
            // 
            this.ileKartLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ileKartLb.AutoSize = true;
            this.ileKartLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ileKartLb.Location = new System.Drawing.Point(1001, 530);
            this.ileKartLb.Name = "ileKartLb";
            this.ileKartLb.Size = new System.Drawing.Size(24, 7);
            this.ileKartLb.TabIndex = 3;
            this.ileKartLb.Text = "label1";
            // 
            // pracownikBindingSource1
            // 
            this.pracownikBindingSource1.DataMember = "pracownik";
            this.pracownikBindingSource1.DataSource = this.logowanie;
            // 
            // logowanie
            // 
            this.logowanie.DataSetName = "logowanie";
            this.logowanie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "pracownik";
            this.pracownikBindingSource.DataSource = this.logowanie;
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.testToolStripMenuItem.Text = "Wpisz login i hasło aby kontynuować";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // telefon
            // 
            this.telefon.HeaderText = "telefon";
            this.telefon.Name = "telefon";
            this.telefon.Visible = false;
            // 
            // adres
            // 
            this.adres.HeaderText = "adres";
            this.adres.Name = "adres";
            this.adres.Visible = false;
            // 
            // nazwaFirmy
            // 
            this.nazwaFirmy.HeaderText = "nazwaFirmy";
            this.nazwaFirmy.Name = "nazwaFirmy";
            this.nazwaFirmy.Width = 250;
            // 
            // nazwa
            // 
            this.nazwa.HeaderText = "Nazwa klienta";
            this.nazwa.Name = "nazwa";
            this.nazwa.Width = 250;
            // 
            // idklient1
            // 
            this.idklient1.DataPropertyName = "idklient";
            this.idklient1.HeaderText = "Nr klienta";
            this.idklient1.Name = "idklient1";
            this.idklient1.Width = 60;
            // 
            // id_
            // 
            this.id_.DataPropertyName = "id";
            this.id_.HeaderText = "id";
            this.id_.Name = "id_";
            this.id_.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 544);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pWynikLogowania);
            this.Controls.Add(this.pHaslo);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ileKartLb);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wodomierz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grupaDodajKlient.ResumeLayout(false);
            this.grupaDodajKlient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grDodajStanWod.ResumeLayout(false);
            this.grDodajStanWod.PerformLayout();
            this.grWybierzKlientaWod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWybKlientaStanWod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWodomierz)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grPozFaktur.ResumeLayout(false);
            this.grPozFaktur.PerformLayout();
            this.grupaWybWodFakt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWyborWodomierz)).EndInit();
            this.grWyboruKlientaDoFaktury.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPozycjiFaktury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaktury)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCennik)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowanie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox haslo;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pLogin;
        private System.Windows.Forms.Label pHaslo;
        private System.Windows.Forms.Label pWynikLogowania;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPoprawStanWod;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btDodajStanWod;
        public System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nazwisko;
        private logowanie logowanie;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private logowanieTableAdapters.pracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.BindingSource pracownikBindingSource1;
        private System.Windows.Forms.Label ileKartLb;
        private System.Windows.Forms.DataGridView GridPracownicy;
        private System.Windows.Forms.DataGridView gridCennik;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsymbolVat;
        private System.Windows.Forms.DataGridView gridFaktury;
        private System.Windows.Forms.DataGridView gridPozycjiFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.GroupBox grPozFaktur;
        private System.Windows.Forms.Button btZapiszFakture;
        private System.Windows.Forms.Button btWrocFaktura;
        private System.Windows.Forms.DateTimePicker dataFiltra;
        private System.Windows.Forms.Button btFiltr;
        private System.Windows.Forms.Button btUsunFakture;
        private System.Windows.Forms.Button btPoprawFakture;
        private System.Windows.Forms.Button btDodajFakture;
        private System.Windows.Forms.TextBox poleNrKlienta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox poleIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poleNrWodomierza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox poleNetto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btWybierKlientaDoFaktury;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox poleStawkaVat;
        private System.Windows.Forms.Button btWybWodFakt;
        private System.Windows.Forms.Label lbNazwaKlienta;
        private System.Windows.Forms.DateTimePicker wyborTerminu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtczyAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtaktywny;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionID;
        private System.Windows.Forms.Label lbilosc;
        private System.Windows.Forms.ComboBox poleFormaPlatnosci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grWyboruKlientaDoFaktury;
        private System.Windows.Forms.Button btWrocWyborKlientaDoFaktury;
        private System.Windows.Forms.Button btWybierzKlientaDoFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklient1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gridWodomierz;
        private System.Windows.Forms.DataGridView gridKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientklienci;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklient3;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmy2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2;
        private System.Windows.Forms.GroupBox grupaWybWodFakt;
        private System.Windows.Forms.Button btWybWod;
        private System.Windows.Forms.Button btWrocWod;
        private System.Windows.Forms.DataGridView gridWyborWodomierz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWodomierz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrIdentyfikacyjny1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wskazanieWodomierza;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOdczytu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwodomierz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientWodomierz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWodomierz1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrIdentyfikacyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn wskazanieWodomierz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOdczytu;
        private System.Windows.Forms.Button btUsunStanWod;
        private System.Windows.Forms.Button btDodajNowyStanWod;
        private System.Windows.Forms.GroupBox grDodajStanWod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox poleNrKlientaStWod;
        private System.Windows.Forms.Button btWrocDodajStanWod;
        private System.Windows.Forms.Button btZapiszStanWod;
        private System.Windows.Forms.DateTimePicker poleDataOdczytuWod;
        private System.Windows.Forms.Button dodajKlientaStanWod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox poleWskazanieWod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox poleNrSeryjny;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox poleNrWod;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbNazwaBanku;
        private System.Windows.Forms.Label lbAdresKlienta;
        private System.Windows.Forms.Label lbNazwaFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlient2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmy1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaBanku;
        private System.Windows.Forms.GroupBox grWybierzKlientaWod;
        private System.Windows.Forms.DataGridView gridWybKlientaStanWod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStwod;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientStWod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyStWod;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieStWod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoStWod;
        private System.Windows.Forms.Button btWybStWod;
        private System.Windows.Forms.Button btWrocKlientStWod;
        private System.Windows.Forms.Label lbNazwaKlientaStanWod;
        private System.Windows.Forms.Button usunKlient;
        private System.Windows.Forms.Button btDodajKlient;
        private System.Windows.Forms.Button btPoprawKlient;
        private System.Windows.Forms.GroupBox grupaDodajKlient;
        private System.Windows.Forms.Button btWrocKlient;
        private System.Windows.Forms.Button btZapiszKlient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox poleAdresDodajKlient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox poleNazwiskoDodajKlient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idDodajKlient;
        private System.Windows.Forms.TextBox poleImieDodajKlient;
        private System.Windows.Forms.Label lbIdKlient;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox poleTelefonDodajKlient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox poleNazwaFirmyDodajKlient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox poleKodDodajKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFaktury;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWystawieniaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminPlatnosciN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyN;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPlatnosciN;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresKlientN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaBankuN;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonN;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolVatN;
    }
}

