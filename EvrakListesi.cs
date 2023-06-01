using MySql.Data.MySqlClient;
using System;
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
    public partial class EvrakListesi : Form
    {
        public EvrakListesi()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            evraklariAl();
        }

        private void evraklariAl()
        {
            DataTable table = new DataTable();
            MySqlDataReader reader = new EvrakDAO().getReader();
            table.Load(reader);
            dataGridView1.DataSource = table;
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //validation
            if (DateTime.Compare(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date) > 0)
            {
                MessageBox.Show("Başlangıç tarihi son tarihten büyük olamaz.");
                dateTimePicker1.Focus();
                return;
            }

            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = "creationTime >= '" + dateTimePicker1.Value.Date + "' and  creationTime <= '" + dateTimePicker2.Value.Date + "'";
        }
    }
}
