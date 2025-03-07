using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formex2 formex2 = new Formex2();
            formex2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formex1 formex1 = new Formex1();
            formex1.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Formex3 formex3 = new Formex3();
            formex3.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Formex4 formex4 = new Formex4();
            formex4.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Formex5 formex5 = new Formex5();
            formex5.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Formex6 formex6 = new Formex6();
            formex6.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Formex7 formex7 = new Formex7();
            formex7.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Formex8 formex8 = new Formex8();
            formex8.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formex09 formex09 = new Formex09();
            formex09.ShowDialog();
        }
    }

}


