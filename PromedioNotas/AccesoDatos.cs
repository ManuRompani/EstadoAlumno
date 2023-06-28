using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PromedioNotas
{
    internal class AccesoDatos
    {
        public string extraerPorConsulta(string consulta, string linea)
        {
            bool designarCarga = true;
            string comparador = "";
            string respuesta = "";
            try
            {
                for (int i = 0; i < linea.Length; i++)
                {
                    switch (linea[i])
                    {
                        case '=':
                            designarCarga = false;
                            break;
                        case ';':
                            if (comparador == consulta)
                            {
                                if (respuesta == "")
                                    return null;
                                else
                                    return respuesta;
                            }
                            else
                            {
                                comparador = "";
                                respuesta = "";
                            }
                            designarCarga = true;
                            break;
                        default:
                            if (designarCarga == true)
                                comparador += linea[i];
                            else
                                respuesta += linea[i];
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return respuesta;
        }
    }
}
