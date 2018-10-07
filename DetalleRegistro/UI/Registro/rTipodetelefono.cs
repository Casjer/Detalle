using DetalleRegistro.BLL;
using DetalleRegistro.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetalleRegistro.UI.Registro
{
    public partial class rTipodetelefono : Form
    {
        public rTipodetelefono()
        {
            InitializeComponent();
        }

        private void idNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            private TipoDeTelefono LlenaClase()
            {
                TipoDeTelefono tipo = new TipoDeTelefono();
                tipo.id = Convert.ToInt32(IdNumericUpDown.Value);
                tipo.Tipo = TipotextBox.Text;


                return tipo;
            }

            private void LlenaCampo(TipoDeTelefono tipo)
            {
                IdNumericUpDown.Value = tipo.Id;
                TipotextBox.Text = tipo.Tipo;



            }


            private bool Validar()
            {
                bool paso = true;
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(TipotextBox.Text))
                {
                    errorProvider1.SetError(TipotextBox, "Campo esta vacio");
                    paso = false;
                }

                return paso;
            }

            private void LlenaCampo(TipoDeTelefono tipo)
            {
                IdNumericUpDown.Value = tipo.Id;
                TipotextBox.Text = tipo.Tipo;



            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            TipoDeTelefono tipo;
            if (!Validar())
                return;
            tipo = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = TipoBLL.Guardar(Tipo);


            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
