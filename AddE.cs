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
    public partial class AddE : Form
    {
        public AddE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                {
                    label6.Text = "Заполните все поля";
                }
                else
                {
                    if (textBox3.Text != textBox5.Text)
                    {
                        label6.Text = "Пароли не совпадают";
                    }
                    else
                    {
                        var d = c.Employees.Where(u => u.Login == textBox2.Text).FirstOrDefault();
                        if (d == null)
                        {
                            Employee people = new Employee();
                            people.Name = textBox1.Text;
                            people.Login = textBox2.Text;
                            people.Password = textBox3.Text;
                            people.PhoneNumber = textBox4.Text;
                            switch (comboBox1.SelectedIndex)
                            {
                                case 0:
                                    people.position = Position.Foreman;
                                    break;
                                case 1:
                                    people.position = Position.Booker;
                                    break;
                                case 2:
                                    people.position = Position.Admin;
                                    break;
                                case 3:
                                    people.position = Position.Manager;
                                    break;
                            }
                            c.Employees.Add(people);
                            c.SaveChanges();
                            Close();
                        }
                        else
                        {
                            label6.Text = "Этот логин занят, пожалуйста придумайте другой";
                        }
                    }
                }
            }
        }

        private void AddE_Load(object sender, EventArgs e)
        {
             textBox4.Text = "+7";
            
        }
    }
    
}
