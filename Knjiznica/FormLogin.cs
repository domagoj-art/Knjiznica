using Newtonsoft.Json;
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

namespace Knjiznica
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        public void GetforLogin()
        {
           string email = txtEmail.Text.Trim();
            int sifra = int.Parse(txtSifra.Text.Trim());
            try
            {
                WebClient client = new WebClient();
                String json = client.DownloadString("http://localhost:5604/api/Zaposlenik/?email=" + email + "&sifra=" + sifra + "");
                Zaposlenik zaposleniks = JsonConvert.DeserializeObject<Zaposlenik>(json);
                var va = zaposleniks.KnjiznicaID;
               
                if(zaposleniks == null)
                {
                    MessageBox.Show("krivi podatci","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var knjiznicaId = zaposleniks.KnjiznicaID;
                      
                    Util.KnjiznicaID = knjiznicaId;
                    this.Close();
                    
                   
                }


                
            }
            catch (WebException e)
            {
                MessageBox.Show("krivi podatci", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            GetforLogin();
           
        }

    }
}
