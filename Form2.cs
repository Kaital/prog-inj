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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                        var d=c.Employees.Where(u=>u.Login==textBox2.Text).FirstOrDefault();
                        if(d==null) 
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

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox4.Text = "+7";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
