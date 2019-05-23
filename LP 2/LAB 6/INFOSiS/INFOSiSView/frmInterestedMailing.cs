using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace INFOSiSView
{
    public partial class frmInterestedMailing : Form
    {
        public frmInterestedMailing()
        {
            InitializeComponent();
            cbInteres.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbInteres.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbInteres.Items.Add("AutoCAD");
            cbInteres.Items.Add("Excel");
            cbInteres.Items.Add("SQL");
            
            
            
            cbCurso.Enabled = false;
            cbCurso.SelectedItem = -1;
            //lbInteres.Items.Add("Excel Básico");
            //lbInteres.Items.Add("Excel Intermedio");
            //lbInteres.Items.Add("Excel Avanzado");
            //lbInteres.Items.Add("SQL Básico");
            //lbInteres.Items.Add("SQL Intermedio");
            //lbInteres.Items.Add("SQL Avanzado");
            //lbInteres.Items.Add("AutoCAD Básico");
            //lbInteres.Items.Add("AutoCAD Intermedio");
            //lbInteres.Items.Add("AutoCAD Avanzado");
        }

        private void cbInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCurso.Enabled = true;
            cbCurso.Text = "";
            cbCurso.Items.Clear();
            dgvInterested.Rows.Clear();
            
            string tema = (string)cbInteres.SelectedItem;
            if(tema == "AutoCAD")
            {
                dgvInterested.Rows.Add("Jeremi", "Cardenas", "jeremi.cardenas@pucp.pe", "o");
                dgvInterested.Rows.Add("Andres", "Vallenas", "a.vallenas@pucp.pe", "o");
                cbCurso.Items.Add("AutoCAD Básico");
                cbCurso.Items.Add("AutoCAD Intermedio");
                cbCurso.Items.Add("AutoCAD Avanzado");
            }
            else if (tema == "Excel")
            {
                dgvInterested.Rows.Add("Johana", "Vergara", "v.vergara@pucp.pe", "o");
                dgvInterested.Rows.Add("Victor", "Vergara", "jvhernandez@pucp.pe", "a");
                cbCurso.Items.Add("Excel Básico");
                cbCurso.Items.Add("Excel Intermedio");
                cbCurso.Items.Add("Excel Avanzado");
            }
            else
            {
                dgvInterested.Rows.Add("Hector", "Bustamante", "elmataJeremies@pucp.pe", "o");
                dgvInterested.Rows.Add("Julio", "Lau", "chinex@pucp.pe", "o");
                cbCurso.Items.Add("SQL Básico");
                cbCurso.Items.Add("SQL Intermedio");
                cbCurso.Items.Add("SQL Avanzado");
            }
            
        }

        private void frmInterestedMailing_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            foreach(DataGridViewRow row in dgvInterested.Rows)
            {
                string nombre = row.Cells[0].Value.ToString();
                string correo = row.Cells[2].Value.ToString();
                string sexo = row.Cells[3].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
