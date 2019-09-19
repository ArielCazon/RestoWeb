using RestoWeb.DAL;
using RestoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestoWeb.BOL
{
    public class UsuarioNegocio
    {

        public Usuario ConsultarUsuario(int id)
        {
            try
            {
                UsuarioDB usuario = new UsuarioDB();

                return new Usuario()
                {

                };
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}