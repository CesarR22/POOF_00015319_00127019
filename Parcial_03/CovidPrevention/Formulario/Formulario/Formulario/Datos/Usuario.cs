using Formulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario.Datos
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();

        /// <summary>
        /// Guarda Usuario
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// Consulta
        /// </summary>
        /// <returns>datos usuario
        /// </returns>
        public List<UsuarioModelo> Consultar()
        {
            return lista;
        }

        internal void Guardar(UsuarioModel model)
        {
            throw new NotImplementedException();
        }
    }
}
