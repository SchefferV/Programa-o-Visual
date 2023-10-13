using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            float p = float.Parse(txtPeso.Text);
            float a = float.Parse(txtAltura.Text);
            float resultado = calculaIMC(p, a);
            lbResultadoIMC.Text = $"IMC: {resultado}";
            lbClassific.Text = $"Classificação: {classificaIMC(resultado)}";
        }

        private float calculaIMC(float peso, float altura)
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        private String classificaIMC(float imc)
        {
            String classifc = "";
            if (imc < 16)
            {
                classifc = "Magreza grau III";
            }
            else if (imc >= 16 && imc <= 16.9)
            {
                classifc = "Magreza grau II";
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                classifc = "Magreza grau I";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                classifc = "Adequado";
            }
            else if (imc >= 25 && imc <= 25.9)
            {
                classifc = "Pré-obeso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                classifc = "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                classifc = "Obesidade grau II";
            }
            else
            {
                classifc = "Obesidade grau III";
            }

            return classifc;
        }
    }
}
