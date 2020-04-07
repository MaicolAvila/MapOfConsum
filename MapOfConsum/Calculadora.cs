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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consum2 obj;
            obj = new Consum2();
            obj.dato1 = double.Parse(textBox1.Text);
            obj.dato2 = double.Parse(textBox2.Text);
            obj.dato3 = double.Parse(textBox3.Text);
            obj.dato4 = double.Parse(textBox4.Text);
            obj.dato5 = double.Parse(textBox5.Text);
            obj.dato6 = double.Parse(textBox7.Text);
            obj.dato7 = double.Parse(textBox8.Text);
            obj.dato8 = double.Parse(textBox9.Text);
            obj.dato9 = double.Parse(textBox10.Text);
            obj.dato10 = double.Parse(textBox11.Text);

            double A = ((0.015 * obj.dato1) * obj.dato6);
            double B = ((0.065 * obj.dato2) * obj.dato7);
            double C = ((0.3 * obj.dato3) * obj.dato8);
            double D = ((0.4 * obj.dato4) * obj.dato9);
            double E = ((1.2 * obj.dato5) * obj.dato10);
            double R = (A + B + C + D + E)*30;
            textBox6.Text = "" + R;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
