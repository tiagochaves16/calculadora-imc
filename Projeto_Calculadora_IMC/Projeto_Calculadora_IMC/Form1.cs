using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculadora_IMC
{

    public partial class Form1 : Form
    {
        double peso = 0, altura = 0, imc = 0;


        private void btmLimpa_Click(object sender, EventArgs e)
        {
            txtP.Text = "";
            txtA.Text = "";
            lblResul.Text = "";
            pb.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            try
            {
                //Converte os textos em doubles para fazer as contas
                peso = double.Parse(txtP.Text);
                altura = double.Parse(txtA.Text);

            }
            catch (Exception)
            {

                txtP.Text = "0";
                txtA.Text = "0";
                MessageBox.Show("Digite o peso e a altura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            imc = Math.Round(peso / (Math.Pow(altura, 2)), 2);

            if (imc < 18.5)
            {
                pb.Visible = false;
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = false;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

            else if (imc >= 18.5 && imc < 24.9)
            {
                pb.Visible = false;
                p1.Visible = false;
                p2.Visible = true;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = false;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

            else if (imc > 25.0 && imc < 29.9)
            {
                pb.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = true;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = false;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

            else if (imc >= 30.0 && imc < 39.9)
            {
                pb.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = true;
                p5.Visible = false;
                p6.Visible = false;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

            else if (imc >= 40 && imc < 44.9)
            {
                pb.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = true;
                p6.Visible = false;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

            else
            {
                pb.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = true;
                lblResul.Text = " Seu IMC é: " + imc.ToString();
            }

        }

    }
   
}

// Dev ~~~> Tiago Chaves