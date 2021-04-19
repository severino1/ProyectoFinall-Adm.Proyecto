using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using WEB.Models;
namespace WEB.Models
{
    public class datosbdcontex : DbContext
    {
        public datosbdcontex() : base("WEB.Properties.Settings.CadenaConexion")
        {
        }
        //esta clase es para crear cadena de conexion -para enityframework
        public DbSet<Usuario>Usuarios { get; set; }
    }
}
