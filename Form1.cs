using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
        //    lista.Items.Add(1);
        //    lista.Items.Add(2);
        //    lista.Items.Add(3);
        //    lista.Items.Add(4);
        for(int valor = 0; valor <= 50; valor++)
            {
                lista.Items.Add(valor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
