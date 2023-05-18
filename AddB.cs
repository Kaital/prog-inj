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
    public partial class AddB : Form
    {
        public AddB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context c = new Context())
            {
                var d = c.Brands.Where(u => u.Name == textBox1.Text).FirstOrDefault();
                if (d == null)
                {

                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Введите название цемента");
                        return;
                    }
                    Brand brand = new Brand();
                    brand.Name = textBox1.Text;
                    c.Brands.Add(brand);
                    c.SaveChanges();
                    Close();
                }
                else
                {
                    label2.Text = "Такой бренд уже существует";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
