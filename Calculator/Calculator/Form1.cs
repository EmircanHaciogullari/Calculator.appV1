using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _ekrantemmizlik;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekrantemmizlik)
            {
                EkranLabel1.Text = "";
                _ekrantemmizlik = false;
            }

            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "0";
        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemmizlik = true;
            _ilksayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void eşittirbutton_Click(object sender, EventArgs e)
        {
            int İkinciSayi = Convert.ToInt32(EkranLabel1.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + İkinciSayi;
                    break;

                case '-':
                    sonuc = _ilksayi - İkinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * İkinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / İkinciSayi;
                    break;
                    default:
                    sonuc=0;
                        break;

            }
            EkranLabel1.Text = Convert.ToString(sonuc);
        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemmizlik = true;
            _ilksayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void çarpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemmizlik = true;
            _ilksayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void bölmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemmizlik = true;
            _ilksayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void temizleCbutton_Click(object sender, EventArgs e)
        {
            EkranLabel1.Text = "0";
        }
    }
}
