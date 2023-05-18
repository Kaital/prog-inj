using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAA
{
    public partial class AddSh : Form
    {
        public AddSh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                var d = c.Shifts.Where(u => u.count.ToString() == textBox1.Text).FirstOrDefault();
                if (d == null)
                {

                    if (textBox1.Text == ""||textBox2.Text=="")
                    {
                        label2.Text=("Заполните все поля");
                        return;
                    }
                    Shift sh = new Shift();
                    sh.count = int.Parse(textBox1.Text);
                    sh.Foreman.Name = textBox2.Text;
                    c.Shifts.Add(sh);
                    c.SaveChanges();
                    Close();
                }
                else
                {
                    label2.Text = "Такая бригада уже зарегистрирована";
                }
            }
        }
    }
}
