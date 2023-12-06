using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppOrarend
{
    public partial class FormOrarend : Form
    {

        public FormOrarend()
        {
            InitializeComponent();
        }
        private void FormOrarend_Load(object sender, EventArgs e)
        {
            updateTermekekLista();
        }

        private void updateTermekekLista()
        {
            listBox_hetfo.Items.Clear();
            listBox_hetfo.Items.AddRange(Program.db.getTanorak("hétfő").ToArray());
            listBox_kedd.Items.Clear();
            listBox_kedd.Items.AddRange(Program.db.getTanorak("kedd").ToArray());
            listBox_szerda.Items.Clear();
            listBox_szerda.Items.AddRange(Program.db.getTanorak("szerda").ToArray());
            listBox_csutortok.Items.Clear();
            listBox_csutortok.Items.AddRange(Program.db.getTanorak("csütörtök").ToArray());
            listBox_pentek.Items.Clear();
            listBox_pentek.Items.AddRange(Program.db.getTanorak("péntek").ToArray());

        }


        private void listBox_hetfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_kedd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox_szerda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_csutortok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_pentek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
