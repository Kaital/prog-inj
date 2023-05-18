using AAA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AAA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            Form2 a=new Form2();
            a.Show();
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Введите пароль и логин!";
            }
            else
            {
                using (Context c = new Context())
                {
                    var employee = c.Employees.Where(u=> u.Login==textBox1.Text && u.Password==textBox2.Text).FirstOrDefault();
                    if (employee != null)
                    {
                        Form3 b = new Form3(employee);
                        this.Hide();
                        b.Text= employee.Name;
                        b .ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        label3.Text = "Неправильный пароль или логин";                        
                    }
                    
                }
            }
            
        }
    }
}
