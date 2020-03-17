using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WieleOkien
{
    public partial class Form1 : Form
    { 
        public Form1()
        {            
            InitializeComponent();                      
        }
        string zapis1;
        string zapis2;
        string liczba1;
        string liczba2;

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Dodawanie ", "+","","");
            zapis1 = "Dodawanie";
            zapis2 = "+";
            
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) + double.Parse(form2.Liczba2);
            Label_wynik.Text =form2.Liczba1+"+"+ form2.Liczba2+"="+wynik.ToString();
            liczba1 = form2.Liczba1;
            liczba2 = form2.Liczba2;


        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Odejmowanie ", "-", "", "");
            zapis1 = "Odejmowanie";
            zapis2 = "-";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) - double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "-" + form2.Liczba2 + "=" + wynik.ToString();
            liczba1 = form2.Liczba1;
            liczba2 = form2.Liczba2;

        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Mnozenie ", "*", "", "");
            zapis1 = "Mnozenie";
            zapis2 = "*";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) * double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "*" + form2.Liczba2 + "=" + wynik.ToString();
            liczba1 = form2.Liczba1;
            liczba2 = form2.Liczba2;

        }

        private void Dzielenie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Dzielenie ", "/", "", "");
            zapis1 = "Dzielenie";
            zapis2 = "/";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) / double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "/" + form2.Liczba2 + "=" + wynik.ToString();
            liczba1 = form2.Liczba1;
            liczba2 = form2.Liczba2;

        }

        private void Label_wynik_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo(zapis1, zapis2,liczba1,liczba2);
            form2.ShowDialog();
            if (zapis2 == "+")
            {
                double wynik = double.Parse(form2.Liczba1) + double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "+" + form2.Liczba2 + "=" + wynik.ToString();
            }
            else if (zapis2 == "-")
            {
                double wynik = double.Parse(form2.Liczba1) - double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "-" + form2.Liczba2 + "=" + wynik.ToString();
            }
            else if (zapis2 == "*")
            {
                double wynik = double.Parse(form2.Liczba1) * double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "*" + form2.Liczba2 + "=" + wynik.ToString();
            }
            else
            {
                double wynik = double.Parse(form2.Liczba1) / double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "/" + form2.Liczba2 + "=" + wynik.ToString();
            }

            liczba1 = form2.Liczba1;
            liczba2 = form2.Liczba2;

        }
    }
}
