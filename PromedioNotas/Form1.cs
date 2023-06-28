using System.Windows.Forms;
using System;

namespace PromedioNotas
{
    public partial class ControlPromedioNotas : Form
    {
        private List<Alumno> listaAlumnos;
        private List<int> listaNotas;
        public ControlPromedioNotas()
        {
            InitializeComponent();
            cargarListaAlumnos();
            cargarAutocomplete();
        }

        private void cargarListaAlumnos()
        {
            AlumnoNegocio negocio = new AlumnoNegocio();
            listaAlumnos = negocio.listarAlumnos();
        }

        private void cargarAutocomplete()
        {
            try
            {
                var autocompletar = new AutoCompleteStringCollection();
                creadorListaAutocomplete(autocompletar);
                tboxNombreAlumno.AutoCompleteCustomSource = autocompletar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void creadorListaAutocomplete(AutoCompleteStringCollection lista)
        {
            try
            {
                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    lista.Add(listaAlumnos[i].Nombre);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tboxNombreAlumno.Text = "";
            tboxNota1.Text = "";
            tboxNota2.Text = "";
            tboxNota3.Text = "";
            tboxNota4.Text = "";
            tboxPromedioNotas.Text = "";
            tboxNotaMasBaja.Text = "";
            lblAprbadoDesaprobado.Text = "-";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listaNotas = new List<int>();
            Alumno alumnoEncontrado = listaAlumnos.FirstOrDefault(alumno => alumno.Nombre == tboxNombreAlumno.Text);
            tboxNota1.Text = alumnoEncontrado.NOTA1.ToString();
            tboxNota2.Text = alumnoEncontrado.NOTA2.ToString();
            tboxNota3.Text = alumnoEncontrado.NOTA3.ToString();
            tboxNota4.Text = alumnoEncontrado.NOTA4.ToString();
            listaNotas.Add(alumnoEncontrado.NOTA1);
            listaNotas.Add(alumnoEncontrado.NOTA2);
            listaNotas.Add(alumnoEncontrado.NOTA3);
            listaNotas.Add(alumnoEncontrado.NOTA4);
            promedioYNotaMasBaja();
        }

        private void estadoDelAlumno()
        {
            double nota = double.Parse(tboxPromedioNotas.Text);
            if(nota>6)
            {
                lblAprbadoDesaprobado.Text = "APROBADO";
            }
            else
                lblAprbadoDesaprobado.Text = "DESAPROBADO";
        }

        private void promedioYNotaMasBaja()
        {
            int notaBaja = listaNotas[0];
            double total = 0;
            for(int i=0;i<listaNotas.Count;i++)
            {
                if (listaNotas[i] < notaBaja)
                {
                    notaBaja = listaNotas[i];
                }
                total += listaNotas[i];
            }
            total = total - notaBaja;
            tboxPromedioNotas.Text = (total/3).ToString("N1");
            tboxNotaMasBaja.Text = notaBaja.ToString();
            estadoDelAlumno();
        }

    }
}