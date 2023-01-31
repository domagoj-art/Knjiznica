using Knjiznica.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class FormPosudbe : Form
    {
        private string urlClass = "Posudba/";
        DataTable dt;
        int knjiznicaId = Util.KnjiznicaID;
        public FormPosudbe()
        {
            InitializeComponent();
        }

        public void GetAllKnjiznicas() { 
        WebClient client = new WebClient();
        String json = client.DownloadString("http://localhost:5604/api/Knjiznica");
        List<KnjiznicaViewModel> knjiznicas = JsonConvert.DeserializeObject<List<KnjiznicaViewModel>>(json);
           
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = knjiznicas;
            comboBoxKnjiznicaID.DataSource = bindingSource1.DataSource;
            comboBoxKnjiznicaID.DisplayMember = "NazivKnjiznice";
            comboBoxKnjiznicaID.ValueMember = "ID";
            comboBoxKnjiznicaID.SelectedIndex = -1;
            comboBoxKnjiznicaID.SelectedText = "--Select--";
            comboBoxKnjiznicaID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxKnjiznicaID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void GetAllKnjigas()
        {
            WebClient client = new WebClient();
            String json = client.DownloadString("http://localhost:5604/api/Knjiga/?knjiznicaID=" + knjiznicaId + "");
            List<KnjigaViewModel> Knjigas = JsonConvert.DeserializeObject<List<KnjigaViewModel>>(json);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Knjigas;
            comboBoxKnjigaID.DataSource = bindingSource1.DataSource;
            comboBoxKnjigaID.DisplayMember = "comboBoxName";
            comboBoxKnjigaID.ValueMember = "ID";
            comboBoxKnjigaID.SelectedIndex = -1;
            comboBoxKnjigaID.SelectedText = "--Select--";
            comboBoxKnjigaID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxKnjigaID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void GetAllClans()
        {
            WebClient client = new WebClient();
            String json = client.DownloadString("http://localhost:5604/api/ClanKnjiznice/?knjiznicaID=" + knjiznicaId + "");
            List<ClanKnjizniceViewModel> clanKnjiznices = JsonConvert.DeserializeObject<List<ClanKnjizniceViewModel>>(json);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = clanKnjiznices;
            comboBoxClanID.DataSource = bindingSource1.DataSource;
            comboBoxClanID.DisplayMember = "ComboBoxName";
            comboBoxClanID.ValueMember = "ID";
            comboBoxClanID.SelectedIndex = -1;
            comboBoxClanID.SelectedText = "--Select--";
            comboBoxClanID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClanID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void GetAllZaposleniks()
        {
            
            WebClient client = new WebClient();
            String json = client.DownloadString("http://localhost:5604/api/Zaposlenik/?knjiznicaID=" + knjiznicaId + "");
            //String json = client.DownloadString("http://localhost:5604/api/Zaposlenik");
            List<ZaposlenikViewModel> zaposleniks = JsonConvert.DeserializeObject<List<ZaposlenikViewModel>>(json);
            
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = zaposleniks;
            comboBoxZaposlenikID.DataSource = bindingSource1.DataSource;
            comboBoxZaposlenikID.DisplayMember = "ComboBoxName";
            comboBoxZaposlenikID.ValueMember = "ID";
            comboBoxZaposlenikID.SelectedIndex = -1;
            comboBoxZaposlenikID.SelectedText = "--Select--";
            comboBoxZaposlenikID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxZaposlenikID.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void GetAll()
        {
            try
            {
                string filter = txtSearch.Text;
                WebClient client = new WebClient();
                String json = client.DownloadString("http://localhost:5604/api/Posudba/?filter="+filter+"&knjiznicaId="+ knjiznicaId);
                var posudbas = JsonConvert.DeserializeObject<List<PosudbaAllViewModel>>(json);
                dataGridView1.DataSource = posudbas;
            }
            catch (WebException e)
            {

                dataGridView1.DataSource = null;
            }


        }
        private void AddData()
        {
            PosudbaViewModel novaPosudba = new PosudbaViewModel()
            {

                KnjigaID = int.Parse(comboBoxKnjigaID.SelectedValue.ToString()),
                ClanID = int.Parse(comboBoxClanID.SelectedValue.ToString()),
                KnjiznicaID = knjiznicaId,
                ZaposlenikID = int.Parse(comboBoxZaposlenikID.SelectedValue.ToString()),
                DatumPreuzimanja = dateTimeRent.Value,
                DatumVracanja = dateTimeReturn.Value
                
                


            };
            var data = JsonConvert.SerializeObject(novaPosudba);
            Util.POST(urlClass, data);
        }
        private void UpdateData()
        {
            PosudbaViewModel novaPosudba = new PosudbaViewModel()
            {
                KnjigaID = int.Parse(comboBoxKnjigaID.SelectedValue.ToString()),
                ClanID = int.Parse(comboBoxClanID.SelectedValue.ToString()),
                KnjiznicaID = knjiznicaId,
                ZaposlenikID = int.Parse(comboBoxZaposlenikID.SelectedValue.ToString()),
                DatumPreuzimanja = dateTimeRent.Value,
                DatumVracanja = dateTimeReturn.Value,
                ID = int.Parse(txtID.Text.Trim())


            };
            var data = JsonConvert.SerializeObject(novaPosudba);
            Util.PUT(urlClass, data);
        }
        
        public void ClearTextData()
        {
            txtID.Text = "";
            comboBoxKnjiznicaID.SelectedIndex = -1;
            comboBoxKnjiznicaID.Text = "--Select--";
            comboBoxKnjigaID.SelectedIndex = -1;
            comboBoxKnjigaID.Text = "--Select--";
            comboBoxClanID.SelectedIndex = -1;
            comboBoxClanID.Text = "--Select--";
            comboBoxZaposlenikID.SelectedIndex = -1;
            comboBoxZaposlenikID.Text = "--Select--";
            dateTimeReturn.Value = DateTime.Today;
            dateTimeRent.Value = DateTime.Today;
            
        }

        private void FormPosudbe_Load(object sender, EventArgs e)
        {
            
            GetAll();
            GetAllKnjiznicas();
            GetAllKnjigas();
            GetAllClans();
            GetAllZaposleniks();
        }
       

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtID.Text = Convert.ToString(dataGridView1[0, row].Value);
            comboBoxKnjiznicaID.SelectedValue = dataGridView1[1, row].Value;
            comboBoxKnjigaID.SelectedValue = dataGridView1[2, row].Value;
            comboBoxClanID.SelectedValue = dataGridView1[3, row].Value;
            comboBoxZaposlenikID.SelectedValue = dataGridView1[4, row].Value;
            dateTimeRent.Text = Convert.ToString(dataGridView1[5, row].Value);
            dateTimeReturn.Text = Convert.ToString(dataGridView1[6, row].Value);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddData();
            ClearTextData();
            GetAll();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateData();
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
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAll();

        }
    
    }
}
