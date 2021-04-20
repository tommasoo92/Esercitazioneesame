using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercitazioneesame.Data
{
	public class BancaDati : DbContext
	{
		public DbSet<Reperto> reperti { get; set; }

		public BancaDati(DbContextOptions options) : base(options) { }
	}
}
