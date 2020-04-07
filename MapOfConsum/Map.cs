using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapOfConsum
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 pag1;
            pag1 = new Form1();
            pag1.Show();
            this.Hide();
        }

        private void est1B_Click(object sender, EventArgs e)
        {

            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "219,12";
                
            }
            else
            {
                Vst12.Text = "219,12";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "533,22";

            }
            else
            {
                sb2.Text = "533,22";
            }

        }

        private void est2B_Click(object sender, EventArgs e)
        {
            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "273,90";
            }
            else
            {
                Vst12.Text = "273,90";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "533,22";

            }
            else
            {
                sb2.Text = "533,22";
            }

        }

        private void label20_Click(object sender, EventArgs e)
        {
            

        }

        private void est3B_Click(object sender, EventArgs e)
        {
            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "453,23";
            }
            else
            {
                Vst12.Text = "453,23";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "533,22";

            }
            else
            {
                sb2.Text = "533,22";
            }

        }

        private void est4B_Click(object sender, EventArgs e)
        {
            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "533,22";
            }
            else
            {
                Vst12.Text = "533,22";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "533,22";

            }
            else
            {
                sb2.Text = "533,22";
            }

        }

        private void est5B_Click(object sender, EventArgs e)
        {
            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "633,86";
            }
            else
            {
                Vst12.Text = "633,86";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "633,86";

            }
            else
            {
                sb2.Text = "633,86";
            }

        }

        private void est6B_Click(object sender, EventArgs e)
        {
            if (Vst11.Text.Trim() == "")
            {
                Vst11.Text = "633,86";
            }
            else
            {
                Vst12.Text = "633,86";
            }
            if (sb1.Text.Trim() == "")
            {
                sb1.Text = "633,86";

            }
            else
            {
                sb2.Text = "633,86";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "")
            {
                MessageBox.Show("Ingresa un valor");
            }
            else
            {
                Consum obj;
                obj = new Consum();
                obj.dato1 = double.Parse(textBox5.Text);
                obj.dato2 = double.Parse(Vst11.Text);
                obj.dato3 = double.Parse(sb1.Text);

                obj.Calculo();
                textBox7.Text = "" + (obj.Resultado / 100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ingresa un valor");
            }
            else
            {
                Consum obj;
                obj = new Consum();
                obj.dato4 = double.Parse(textBox6.Text);
                obj.dato5 = double.Parse(Vst12.Text);
                obj.dato6 = double.Parse(sb2.Text);

                obj.Calculos();
                textBox8.Text = "" + (obj.Resul / 100);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if(textBox5.Text == "")
                {
                    MessageBox.Show("Ingresa un valor");
                }
                else
                {
                    Consum obj;
                    obj = new Consum();
                    obj.dato1 = double.Parse(textBox5.Text);
                    obj.dato2 = double.Parse(Vst11.Text);
                    obj.dato3 = double.Parse(sb1.Text);

                    if (obj.dato1 <= 130)
                    {
                        double A = obj.dato1;
                        double B = (A * obj.dato2);
                        textBox11.Text = "" + (B / 100);
                    }
                    else
                    {
                        double A = (obj.dato1 - 130);
                        double B = (A * obj.dato3);
                        double C = (130 * obj.dato2);
                        double D = (B + C);
                        textBox11.Text = "" + (D / 100);
                    }
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ingresa un valor");
            }
            else
            {
                Consum obj;
            obj = new Consum();
            obj.dato4 = double.Parse(textBox6.Text);
            obj.dato5 = double.Parse(Vst12.Text);
            obj.dato6 = double.Parse(sb2.Text);
            double A = (obj.dato4 - 130);
            double B = (A * obj.dato6);
            double C = (130 * obj.dato5);
            double D = (B + C);
            textBox12.Text = "" + (D / 100);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculadora pag1;
            pag1 = new Calculadora();
            pag1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculadora pag1;
            pag1 = new Calculadora();
            pag1.Show();
        }

        private void mapaBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Ingresa un valor");
            }
            else
            {
                Consum obj;
            obj = new Consum();
            obj.dato4 = double.Parse(textBox6.Text);

            textBox10.Text = "" + ((obj.dato4 * 1000) / 60);



            obj.dato1 = double.Parse(textBox5.Text);

            textBox9.Text = "" + ((obj.dato1 * 1000) / 60);
            }
        }
    }
}
