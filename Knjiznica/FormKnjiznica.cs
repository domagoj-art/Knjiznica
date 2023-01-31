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
    public partial class FormKnjiznica : Form
    {
        private string urlClass = "Knjiznica/";
        public FormKnjiznica()
        {
            InitializeComponent();
        }

        private void FormKnjiznica_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            try
            {
                WebClient client = new WebClient();
                String json = client.DownloadString("http://localhost:5604/api/" + urlClass);
                List<KnjiznicaViewModel> knjiznicas = JsonConvert.DeserializeObject<List<KnjiznicaViewModel>>(json);
                dataGridView1.DataSource = knjiznicas;
            }
            catch (WebException e)
            {

                
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtID.Text = Convert.ToString(dataGridView1[0, row].Value);
            txtNazivKnjiznice.Text = Convert.ToString(dataGridView1[1, row].Value);
            txtAdresaKnjiznice.Text = Convert.ToString(dataGridView1[2, row].Value);
        }

        private void AddData()
        {
            KnjiznicaViewModel novaKnjiznica = new KnjiznicaViewModel()
            {
                NazivKnjiznice = txtNazivKnjiznice.Text.Trim(),
                AdresaKnjiznice = txtAdresaKnjiznice.Text.Trim(),
            };
            var data = JsonConvert.SerializeObject(novaKnjiznica);
            Util.POST(urlClass, data);
        }
        private void UpdateData()
        {
            KnjiznicaViewModel novaKnjiznica = new KnjiznicaViewModel()
            {
                NazivKnjiznice = txtNazivKnjiznice.Text.Trim(),
                AdresaKnjiznice = txtAdresaKnjiznice.Text.Trim(),
                ID = int.Parse(txtID.Text.Trim())


            };
            var data = JsonConvert.SerializeObject(novaKnjiznica);
            Util.PUT(urlClass, data);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddData();
            ClearTextData();
            GetAll();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Util.Delete(urlClass, id);
            ClearTextData();
            GetAll();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateData();
            ClearTextData();
            GetAll();
        }
        public void ClearTextData()
        {
            txtAdresaKnjiznice.Text = "";
            txtID.Text = "";
            txtNazivKnjiznice.Text = "";
        }
    }
}
