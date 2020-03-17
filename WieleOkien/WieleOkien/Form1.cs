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
        string liczba3;
        string liczba4;
        string liczba5;
        string liczba6;
        string liczba7;
        string liczba8;
        private void Dodawanie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Dodawanie ", "+",liczba1,liczba2);
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
            Owo form2 = new Owo("Odejmowanie ", "-", liczba3, liczba4);
            zapis1 = "Odejmowanie";
            zapis2 = "-";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) - double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "-" + form2.Liczba2 + "=" + wynik.ToString();
            liczba3 = form2.Liczba1;
            liczba4 = form2.Liczba2;

        }
        private void Mnozenie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Mnozenie ", "*", liczba5, liczba6);
            zapis1 = "Mnozenie";
            zapis2 = "*";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) * double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "*" + form2.Liczba2 + "=" + wynik.ToString();
            liczba5 = form2.Liczba1;
            liczba6 = form2.Liczba2;

        }
        private void Dzielenie_Click(object sender, EventArgs e)
        {
            Owo form2 = new Owo("Dzielenie ", "/", liczba7, liczba8);
            zapis1 = "Dzielenie";
            zapis2 = "/";
            form2.ShowDialog();
            double wynik = double.Parse(form2.Liczba1) / double.Parse(form2.Liczba2);
            Label_wynik.Text = form2.Liczba1 + "/" + form2.Liczba2 + "=" + wynik.ToString();
            liczba7 = form2.Liczba1;
            liczba8 = form2.Liczba2;

        }
        private void Label_wynik_Click(object sender, EventArgs e)
        {
            
            if (zapis2 == "+")
            {
                Owo form2 = new Owo(zapis1, zapis2, liczba1, liczba2);
                form2.ShowDialog();
                double wynik = double.Parse(form2.Liczba1) + double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "+" + form2.Liczba2 + "=" + wynik.ToString();
                liczba1 = form2.Liczba1;
                liczba2 = form2.Liczba2;
            }
            else if (zapis2 == "-")
            {
                Owo form2 = new Owo(zapis1, zapis2, liczba3, liczba4);
                form2.ShowDialog();
                double wynik = double.Parse(form2.Liczba1) - double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "-" + form2.Liczba2 + "=" + wynik.ToString();
                liczba3 = form2.Liczba1;
                liczba4 = form2.Liczba2;
            }
            else if (zapis2 == "*")
            {
                Owo form2 = new Owo(zapis1, zapis2, liczba5, liczba6);
                form2.ShowDialog();
                double wynik = double.Parse(form2.Liczba1) * double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "*" + form2.Liczba2 + "=" + wynik.ToString();
                liczba5 = form2.Liczba1;
                liczba6 = form2.Liczba2;
            }
            else
            {
                Owo form2 = new Owo(zapis1, zapis2, liczba7, liczba8);
                form2.ShowDialog();
                double wynik = double.Parse(form2.Liczba1) / double.Parse(form2.Liczba2);
                Label_wynik.Text = form2.Liczba1 + "/" + form2.Liczba2 + "=" + wynik.ToString();
                liczba7 = form2.Liczba1;
                liczba8 = form2.Liczba2;
            }
        }
    }
}
