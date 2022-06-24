using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sific
{
    public partial class KeySystemUI : Form
    {
        public KeySystemUI()
        {
            InitializeComponent();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GETKEY_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/4RwJrU2xu4");
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string gettext = keybox.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 4)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/ItsMeRick/Sific/main/key");

                if (ks.Contains(keybox.Text))
                {
                    //tue side
                    this.Hide();
                    Sific form1 = new Sific();
                    form1.Show();


                }
                else
                {
                    //false side
                    MessageBox.Show("try a other code", "Sific");
                }
            }
        }
    }
}
