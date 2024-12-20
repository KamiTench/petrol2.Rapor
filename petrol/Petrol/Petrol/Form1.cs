using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.anaRezervTableAdapter.Fill(this.petrolSatisSistemiDataSet.AnaRezerv);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void şubeleriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            }

        private void yakıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaRezervToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void şubeYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new SubeYonetimiForm());
            
        }

        private void şubeEkleDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şubeYönetimiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            {
                SubeYonetimiForm subeForm = new SubeYonetimiForm();
                subeForm.ShowDialog();
            }
        }

        private void yakıtTalepleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yakitTalepleriForm YakitTalepleriForm = new yakitTalepleriForm();
            YakitTalepleriForm.Show();
        }

        private void anaDepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaDepoYonetimiForm anaDepoYonetimiForm = new AnaDepoYonetimiForm();
            anaDepoYonetimiForm.Show();
        }
    }

    }
