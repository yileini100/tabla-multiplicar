using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicar_tabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            int num, tabla, resultado;
            tabla = int.Parse(txt_Ingrese_Numero.Text);

            for (num = 1; num <= 12; num++)
            {
                resultado = num * tabla;
                lst_tabla.Items.Add(tabla + "x" + num + "=" + resultado);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lst_tabla.Items.Clear();
            txt_Ingrese_Numero.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

