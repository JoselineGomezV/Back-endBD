using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Back_endBD.Models
{
    public class AlumnoDBContext : DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public AlumnoDBContext() : base(ConnectionString) {}
        //DBSET OBJETO QUE PERMITE CREAR UNA TABLA EN LA BASE DE DATOS QUE PERMITE LA MANIPULACION DE FORMA TEMPORAL
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Maestros> Maestros { get; set; }
    }
}