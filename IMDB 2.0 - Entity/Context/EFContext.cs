﻿using IMDB_2._0___Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IMDB_2._0___Entity.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("IMDB2_Entity") { }
        public DbSet<Filme> Filmes { get; set; }

    }
}