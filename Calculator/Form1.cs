using System;
using operations;
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
        private Operations op = new Operations();
        private double valor1;
        private double valor2;
        private char _operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {            
            var boton = ((Button)sender);
            if (textBox1.Text == "0")
                textBox1.Text = "";
            
            textBox1.Text += boton.Text;
        }

        private void addoperation(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            valor1 = Convert.ToDouble(textBox1.Text);
            _operation = Convert.ToChar(boton.Tag);

            textBox1.Text = "0";
        }

        private void showResult(object sender, EventArgs e) 
        {
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (_operation) 
            {
                case '-':
                    textBox1.Text = Convert.ToString(op.resta(valor1, valor2));
                    break;

                case '+':
                    textBox1.Text = Convert.ToString(op.suma(valor1, valor2));
                    break;

                case '*':
                    textBox1.Text = Convert.ToString(op.multiplicacion(valor1, valor2)); 
                    break;

                case '/':
                    textBox1.Text = Convert.ToString(op.division(valor1, valor2));
                    break;

                default:
                    textBox1.Text = "ECUACION INVALIDA";
                    break;
            }
            valor1 = 0;
            valor2 = 0;
        }

        private void delete(object sender, EventArgs e) 
        {
            if(textBox1.Text.Length > 1) 
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void clearAll(object sender, EventArgs e) 
        {
            textBox1.Text = "0";
            valor1 = 0;
            valor2 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
