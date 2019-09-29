using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{


    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario DATO = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Guardar();
            Iniciar();
            Limpiar();
            Consultal();
        }
        private void BtnLIMPIAR_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void Iniciar()
        {

            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Edad");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Provincia");
            tabla.Columns.Add("Pais");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Celular");
            tabla.Columns.Add("Fecha Nacimiento");
            dtgDato.DataSource = tabla;


        }

        private void Guardar()
        {

            try
            {
                D_Persona persona = new D_Persona()
                {
                    Nombre = textNombre.Text,
                    Apellido = textApellido.Text,
                    Edad =Convert.ToInt16 (textEdad.Text),
                    Direccion = textDireccion.Text,
                    Provincia = textProvincia.Text,
                    Pais = textPais.Text,
                    Telefono =Convert.ToInt32 (textTelefono.Text),
                    Celular = Convert.ToInt32( textCelular.Text),
                    Fecha_Nacimiento= Convert.ToDateTime (FECHAC.Text)


                

            };
                DATO.Guardar(persona);
            

                MessageBox.Show(" Los Dato son correctos").ToString();

        }
       catch(Exception Persona )
            {
                MessageBox.Show(Persona.ToString());
            }
}

        private void Consultal()
        {

            foreach (var item in DATO.Consultar())
            {

                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Apellido"] = item.Apellido;
                fila["edad"] = item.Edad;
                fila["Direccion"] = item.Direccion;
                fila["Provincia"] = item.Provincia;
                fila["Pais"] = item.Pais;
                fila["Telefono"] = item.Telefono;
                fila["Celular"] = item.Celular;
                fila["Fecha Nacimiento"] = item.Fecha_Nacimiento;
                tabla.Rows.Add(fila);
            }


        }
        private void Limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textEdad.Text = "";
            textDireccion.Text = "";
            textProvincia.Text = "";
            textPais.Text = "";
            textTelefono.Text = "";
            textCelular.Text = "";
              FECHAC.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void FECHAC_ValueChanged(object sender, EventArgs e)
        {

        }
    }


}

