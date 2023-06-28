using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    internal class AlumnoNegocio
    {
        List<Alumno> listaAlumnos = new List<Alumno>();

        public List<Alumno> listarAlumnos()
        {
            StreamReader extractor = new StreamReader("D:\\Estudios\\LibroC#\\PromedioNotas\\AlumnosBD.txt");
            string linea = extractor.ReadLine();
            AccesoDatos datos = new AccesoDatos();
            Alumno alumno;
            try
            {
                while (linea != null)
                {
                    alumno = new Alumno();
                    alumno.Nombre = datos.extraerPorConsulta("NOMBRE", linea);
                    alumno.NOTA1 = int.Parse(datos.extraerPorConsulta("NOTA1", linea));
                    alumno.NOTA2 = int.Parse(datos.extraerPorConsulta("NOTA2", linea));
                    alumno.NOTA3 = int.Parse(datos.extraerPorConsulta("NOTA3", linea));
                    alumno.NOTA4 = int.Parse(datos.extraerPorConsulta("NOTA4", linea));
                    listaAlumnos.Add(alumno);
                    linea = extractor.ReadLine();
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                extractor.Close();
            }
                return listaAlumnos;
        }
    }
}
