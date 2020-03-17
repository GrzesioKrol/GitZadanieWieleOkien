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
    public partial class Owo : Form
    {
        public Owo(string a, string b,string l1,string l2)
        {            
            InitializeComponent();
            this.Text = a;
            Label_tytul.Text = a;            
            Label_znak.Text = b;
            L1.Text = l1;
            L2.Text = l2;
        }
        public string Liczba1{ get; set; }
        public string Liczba2 { get; set; }
        private void Wynik_Click(object sender, EventArgs e)
        {
            this.Liczba1 = L1.Text;
            this.Liczba2 = L2.Text;
            this.Close();
        }
    }
}
