using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembersApi.Contracts;
using MembersApi.Models;

namespace MembersApi.Services
{
	public class MemberRepository : RepositoryBase<Member>, IMemberRepository
	{
		public MemberRepository(MembersContext membersContext) : base(membersContext)
		{
		}
	}
}
