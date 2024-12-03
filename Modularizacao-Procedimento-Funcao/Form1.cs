using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Modularizacao_Procedimento_Funcao
{

    public partial class Form1 : Form
    {
        //Declaração de variaveis globais
        double resultado = 0;
        string expressao = "";

        // Função Soma
        void Soma(double num1, double num2)
        {
            resultado = num1 + num2;
            expressao = num1 + " + " + num2;
        }

        // Função Subtração
        void Subtracao(double num1, double num2)
        {
            resultado = num1 - num2;
            expressao = num1 + " - " + num2;
        }

        // Função Multiplicação
        void Multiplicacao(double num1, double num2)
        {
            resultado = num1 * num2;
            expressao = num1 + " x " + num2;
        }

        // Função Divisão
        void Divisao(double num1, double num2)
        {
            resultado = num1 / num2;
            expressao = num1 + " / " + num2;
        }

        // Função Resto
        void Resto(double num1, double num2)
        {
            resultado = num1 % num2;
            expressao = num1 + " % " + num2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtExpressao.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbDivisao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbResto.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumero1.Text);

            double num2 = double.Parse(txtNumero2.Text);

            if (rdbSoma.Checked == true)

            {

                Soma(num1, num2);

            }

            else if (rdbSubtracao.Checked == true)

            {

                Subtracao(num1, num2);

            }

            else if (rdbMultiplicacao.Checked == true)

            {

                Multiplicacao(num1, num2);

            }

            else if (rdbDivisao.Checked == true)

            {

                Divisao(num1, num2);

            }

            else if (rdbResto.Checked == true)

            {

                Resto(num1, num2);

            }


            txtResultado.Text = resultado.ToString();

            txtExpressao.Text = expressao;

        }
    }
}
