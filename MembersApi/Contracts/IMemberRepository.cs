using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembersApi.Models;

namespace MembersApi.Contracts
{
	public interface IMemberRepository: IRepositoryBase<Member>
	{
	}
}
