using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAA
{
    public partial class Form3 : Form
    {
        Employee curEmpl;
        public Form3(Employee empl)
        {
            InitializeComponent();
            curEmpl = empl;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            switch (curEmpl.position)
            {
                case (Position)0:
                    button4.Hide();
                    break;
                case (Position)2:
                    break;
                case (Position)3:
                    break;

            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            obshak a = new obshak(curEmpl, button3.Name);
            a.Text = "Сотрудники";
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            obshak a = new obshak(curEmpl, button2.Name);
            a.Text = "Список производства";
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obshak a = new obshak(curEmpl, button1.Name);
            a.Text = "Планы";
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obshak a = new obshak(curEmpl, button4.Name);
            a.Text = "Сотрудники";
            this.Hide();
            a.ShowDialog();
            this.Close();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obshak a = new obshak(curEmpl, button5.Name);
            a.Text = "Смена";
            this.Hide();
            a.ShowDialog();
            this.Close();
        }
    }
}
