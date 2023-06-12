using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ErroForm erroForm = new ErroForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float soma = 0, media, valor, lengh =0;

            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        if(((TextBox)control).Text == "")
                        {
                            ((TextBox)control).Text = "0";
                            lengh--;
                        }
                        lengh++;
                        valor = Convert.ToSingle(((TextBox)control).Text);
                        soma += valor;
                    }
                    media = soma / lengh;
                    this.Controls["label6"].Text = media.ToString();
                }
            }
            catch(Exception ex)
            {
                erroForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
