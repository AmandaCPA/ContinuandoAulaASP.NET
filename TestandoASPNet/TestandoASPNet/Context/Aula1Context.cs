using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestandoASPNet.Models;

namespace TestandoASPNet.Context
{
    public class Aula1Context : DbContext
    {
        public Aula1Context()
            : base("Aula1Context")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        
    }
}