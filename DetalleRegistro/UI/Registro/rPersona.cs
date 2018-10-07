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
    public partial class rPersona : Form
    {
        public List<TelefonosDetalle> detalle { get; set; }

        public rPersona()
        {
            InitializeComponent();
            this.detalle = new List<TelefonosDetalle>();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            FNacimientodateTimePicker.Value = DateTime.Now;

            this.detalle = new List<TelefonosDetalle>()

        }
        private Personas LlenaClase()
        {
            Personas persona = new Personas();
            persona.PersonaId = Convert.ToInt32(IdnumericUpDown.Value);
            persona.Nombres = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.FechaNacimiento = F.NacimientodateTimePicker.Value;

            persona.Telefonos = this.detalle;

            return persona;
        }

        private void LlenaCampo(Personas persona)
        {
            IdnumericUpDown.Value = persona.PersonaId;
            NombretextBox.Text = persona.Nombres;
            CedulamaskedTextBox.Text = persona.Cedula;
            DirecciontextBox.Text = persona.Direccion;
            FNacimientodateTimePicker.Value = persona.FechaNacimiento;

            this.detalle = persona.Telefonos;
            CargarGrid();
        }
        private void CargarGrid()
        {
            TelefonosdataGridView.DataSource = null;
            TelefonosdataGridView.DataSource = this.detalle;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider1.SetError(DirecciontextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("-", "")))
            {
                errorProvider1.SetError(CedulamaskedTextBox, "Campo esta vacio");
            }
            if (this.detalle.Count == 0)
            {
                errorProvider1.SetError(TelefonosdataGridView, "Debe Agregar algun telefono");
                TipodetelefonomaskedTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (TelefonosdataGridView.DataSource != null)
            {
                this.detalle = (List<TelefonosDetalle>)TelefonosdataGridView.DataSource;

                this.detalle.Add(
                    new TelefonosDetalle(
                         Id: 0,
                         PersonaID: (int)IdnumericUpDown.Value,
                        Telefono: TipodetelefonomaskedTextBox.Text,
                        TipoTelefono: TelfonotextBox.Text
                        )
                        );
                CargarGrid();
                TipodetelefonomaskedTextBox.Focus();
                TipodetelefonomaskedTextBox.Clear();

            }


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (TelefonosdataGridView.Rows.Count > 0 && TelefonosdataGridView.CurrentRow != null)
            {
                detalle.RemoveAt(TelefonosdataGridView.CurrentRow.Index);

                CargarGrid();

            }
        }
        private bool ExiteEnLaBaseDeDatos()
        {
            Personas persona = PersonaBLL.Buscar((int)IdnumericUpDown.Value);
            return (persona != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Personas persona;
            if (!Validar())
                return;
            persona = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = PersonaBLL.Guardar(persona);
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("Nose puede Modificar No Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonaBLL.Modificar(persona);
            }
            Limpiar();

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void ELiminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            Personas persona = new Personas();
            int.TryParse(IdnumericUpDown.Text, out id);

            if (PersonaBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                errorProvider1.SetError(IdnumericUpDown, "Persona no Exite");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id;
            Personas persona = new Personas();
            int.TryParse(IdnumericUpDown.Text, out id);

            persona = PersonaBLL.Buscar(id);

            if (persona != null)
            {
                MessageBox.Show("Persona Encotrada");
                LlenaCampo(persona);
            }
            else
            {
                MessageBox.Show("Persona no Encotrada");
            }
        }
    }

}