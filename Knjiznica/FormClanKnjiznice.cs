using Knjiznica.ViewModels;
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
    public partial class FormClanKnjiznice : Form
    {
        private string urlClass = "ClanKnjiznice/";
        public FormClanKnjiznice()
        {
            InitializeComponent();
        }

        private void FormClanKnjiznice_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
{
            int knjiznicaId = Util.KnjiznicaID;
            try
            {
                WebClient client = new WebClient();
                String json = client.DownloadString("http://localhost:5604/api/" + urlClass + "/?knjiznicaID=" + knjiznicaId + "");
                List<ClanKnjizniceViewModel> clanKnjiznices = JsonConvert.DeserializeObject<List<ClanKnjizniceViewModel>>(json);
                dataGridView1.DataSource = clanKnjiznices;
                dataGridView1.Columns.Remove("ComboBoxName");
            }
            catch (WebException e)
            {
                
               
            }
           
        }
        private void AddData()
        {
            ClanKnjizniceViewModel noviClanKnjiznice = new ClanKnjizniceViewModel()
            {
                KnjiznicaID = Util.KnjiznicaID,
                Ime = txtIme.Text.Trim(),
                Prezime = txtPrezime.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                KontaktBroj = txtKontaktBroj.Text.Trim(),
                ClanarinaVrijediDo = datumIstekaClanarine.Value
                
            };
            var data = JsonConvert.SerializeObject(noviClanKnjiznice);
            Util.POST(urlClass, data);
        }
        private void UpdateData()
        {
            ClanKnjizniceViewModel noviClanKnjiznice  = new ClanKnjizniceViewModel()
            {

                KnjiznicaID = Util.KnjiznicaID,
                ID = int.Parse(txtID.Text.Trim()),
                Ime = txtIme.Text.Trim(),
                Prezime = txtPrezime.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                KontaktBroj = txtKontaktBroj.Text.Trim(),
                ClanarinaVrijediDo = datumIstekaClanarine.Value


            };
            var data = JsonConvert.SerializeObject(noviClanKnjiznice);
            Util.PUT(urlClass, data);
        }
        public void ClearTextData()
        {
            txtKnjiznicaID.Text = "";
            txtID.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            txtKontaktBroj.Text = "";
            datumIstekaClanarine.Value = DateTime.Today;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFields() == true)
                {
                    AddData();
                    ClearTextData();
                    GetAll();
                }
                
            }
            catch (Exception)
            {

            }
          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text.Trim());
                Util.Delete(urlClass, id);
                ClearTextData();
                GetAll();
            }
            catch (Exception)
            {


            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                ClearTextData();
                GetAll();
            }
            catch (Exception)
            {

                
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtKnjiznicaID.Text = Convert.ToString(dataGridView1[0, row].Value);
            txtID.Text = Convert.ToString(dataGridView1[1, row].Value);
            txtIme.Text = Convert.ToString(dataGridView1[2, row].Value);
            txtPrezime.Text = Convert.ToString(dataGridView1[3, row].Value);
            txtEmail.Text = Convert.ToString(dataGridView1[4, row].Value);
            txtKontaktBroj.Text = Convert.ToString(dataGridView1[5, row].Value);
            datumIstekaClanarine.Text = Convert.ToString(dataGridView1[6, row].Value);
        }
        private bool CheckFields()
        {
            if(txtIme.Text == "" || txtPrezime.Text == "" || txtEmail.Text == "" || txtKontaktBroj.Text == "")
            {
                MessageBox.Show("Popunite sva polja", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (datumIstekaClanarine.Value.Date != DateTime.Today.AddYears(1))
            {
                MessageBox.Show("Članarina mora vrijediti godinu dana od danas", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {

                return true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextData();
        }
    }
}
