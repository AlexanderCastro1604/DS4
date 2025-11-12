using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        private ControladorEntrada controlador;


        public Form1()
        {
            InitializeComponent();
            btn0.Click += btnNumero_Click;
            btn1.Click += btnNumero_Click;
            btn2.Click += btnNumero_Click;
            btn3.Click += btnNumero_Click;
            btn4.Click += btnNumero_Click;
            btn5.Click += btnNumero_Click;
            btn6.Click += btnNumero_Click;
            btn7.Click += btnNumero_Click;
            btn8.Click += btnNumero_Click;
            btn9.Click += btnNumero_Click;

            // Operadores / control
            btnSumar.Click += btnSumar_Click;
            btnMenos.Click += btnMenos_Click;
            btnMultiplicar.Click += btnMultiplicar_Click;
            btnDividir.Click += btnDividir_Click;
            btnPunto.Click += btnPunto_Click;
            btnIgual.Click += btnIgual_Click;
            btnClear.Click += btnClear_Click;

            // Pantalla
            txtOperacion.ReadOnly = true;
            txtOperacion.Text = string.Empty;
            controlador = new ControladorEntrada();
        }


        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            txtOperacion.Text = controlador.ProcesarEntrada(boton.Text);
        }


        private void btnSumar_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.ProcesarEntrada("+");
        private void btnMenos_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.ProcesarEntrada("-");
        private void btnMultiplicar_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.ProcesarEntrada("*");
        private void btnDividir_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.ProcesarEntrada("/");
        private void btnPunto_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.ProcesarEntrada(".");
        private void btnIgual_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.Evaluar();
        private void btnClear_Click(object sender, EventArgs e) => txtOperacion.Text = controlador.LimpiarTodo();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOperacion.ReadOnly = true;
            txtOperacion.Text = "";
        }
    }
}

