using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wodomierz
{
    public partial class LogowanieDoBazy : Form1
    {
        
        public bool Logowanie()
        {
            MessageBox.Show("jesteś zalogowany");
            return true;
        }

        public void PokazKtoJestZalogowany()
        {
            testToolStripMenuItem.Text = "Zalogowano: " + textBox1.Text + ". Wyloguj.";
        }

    }
}
