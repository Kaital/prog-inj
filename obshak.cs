using AAA.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAA
{
    public partial class obshak : Form
    {
        string agr;
        private Employee employee;
        public obshak(Employee emp, string agr)
        {
            employee = emp; 
            this.agr = agr;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (agr!="button2"&&employee.position == Position.Foreman )
            {
                MessageBox.Show("Извините, доступ запрещён") ;
                return;
            }
            switch (button1.Text)
            {
                case ("Добавить Сотрудника"):
                    AddE a = new AddE();
                    a.ShowDialog();
                    break;
                case ("Добавить бренд"):
                    AddB b = new AddB();
                    b.ShowDialog();
                    break;
                case ("Добавить план"):
                    AddPl c=new AddPl();
                    c.ShowDialog();
                    break;
                case ("Добавить производство"):
                    AddPr d = new AddPr();
                    d.ShowDialog();
                    break;
                case ("Добавить смену"):
                    AddSh v = new AddSh();
                    v.ShowDialog();
                    break;
            }
        }

        private void obshak_Load(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {

                switch (agr)
                {
                    case "button4":
                        dataGridView1.DataSource = c.Employees.Select(em => new { ФИО = em.Name, Номер_Телефона = em.PhoneNumber, Должность = em.position }).ToList();
                        button1.Text = "Добавить Сотрудника";
                        break;
                    case "button3":
                        dataGridView1.DataSource = c.Brands.Select(em => new { Название = em.Name }).ToList();
                        button1.Text = "Добавить бренд";
                        break;
                    case "button1":
                        dataGridView1.DataSource = c.Plans.Select(em => new { Количество = em.Amount, Дата_начала = em.Date, Срок = em.period }).ToList();
                        button1.Text = "Добавить план";
                        break;
                    case "button2":
                        dataGridView1.DataSource = c.Products.Select(em => new { Марка = em.brand.Name, Количество = em.Amount, Дата = em.Date, Обьяснительная = em.Explanatory }).ToList();
                        button1.Text = "Добавить производство";
                        break;
                    case "button5":
                        dataGridView1.DataSource = c.Shifts.Select(em => new { Отряд = em.count, Бригадир = em.Foreman }).ToList();
                        button1.Text = "Добавить смену";
                        break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                switch (agr)
                {
                    case "button4":
                        dataGridView1.DataSource = c.Employees.Select(em => new { ФИО = em.Name, Номер_Телефона = em.PhoneNumber, Должность = em.position }).ToList();
                        button1.Text = "Добавить Сотрудника";
                        break;
                    case "button3":
                        dataGridView1.DataSource = c.Brands.Select(em => new { Название = em.Name }).ToList();
                        button1.Text = "Добавить бренд";
                        break;
                    case "button1":
                        dataGridView1.DataSource = c.Plans.Select(em => new { Количество = em.Amount, Дата_начала = em.Date, Срок = em.period }).ToList();
                        button1.Text = "Добавить план";
                        break;
                    case "button2":
                        dataGridView1.DataSource = c.Products.Select(em => new { Марка = em.brand.Name, Количество = em.Amount, Дата = em.Date, Обьяснительная = em.Explanatory }).ToList();
                        button1.Text = "Добавить производство";
                        break;
                    case "button5":
                        dataGridView1.DataSource = c.Shifts.Select(em => new { Отряд= em.count, Бригадир = em.Foreman }).ToList();
                        button1.Text = "Добавить смену";
                        break;
                }
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3(employee);
            this.Hide();
            a.Text=employee.Name;
            a.ShowDialog();
            this.Close();
        }
    }
}
