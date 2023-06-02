using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universite_Arsiv_Uygulamasi.DAL;

namespace Universite_Arsiv_Uygulamasi
{
    public partial class EmanetListesi : Form
    {
        public EmanetListesi()
        {
            InitializeComponent();
            emanetleriAl();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

       

        

        private void emanetleriAl()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = new EmanetDAO().getReaderEmanet();
            table.Load(reader);
            dataGridView1.DataSource = table;
        }

        private void EmanetListesi_Load(object sender, EventArgs e) {
            dataGridView1.Columns[9].HeaderText = "Emanet Teslim Durumu";
        }
       

        private void EmanetListesi_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Aradığınız " + textBox1.Text + "Bulunamadı");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void emanetGuncelle_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["emanetAlindi"].Value);
                if (isSelected)
                {
                    if (isSelected) { }
                    else
                    {
                        new EmanetDAO().emanetTeslimAlındı(Convert.ToInt32(row.Cells["evrakId"].Value));
                        MessageBox.Show("Emanetler Teslim Alındı !");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date) > 0)
            {
                MessageBox.Show("Başlangıç tarihi son tarihten büyük olamaz.");
                dateTimePicker1.Focus();
                return;
            }

            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = "eCreationTime >= '" + dateTimePicker1.Value.Date + "' and  eCreationTime <= '" + dateTimePicker2.Value.Date + "'";
        }
    }
}
