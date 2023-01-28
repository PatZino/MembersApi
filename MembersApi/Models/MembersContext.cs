using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MembersApi.Models
{
	public class MembersContext: DbContext
	{
		public MembersContext(DbContextOptions options): base(options)
		{
		}
		public DbSet<Member> Members { get; set; }
	}
}
