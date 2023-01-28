using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembersApi.Contracts;
using MembersApi.Models;

namespace MembersApi.Services
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private MembersContext _membersContext;
		private IMemberRepository _memberRepository;

		public IMemberRepository Member
		{
			get
			{
				if(_memberRepository == null)
				{
					_memberRepository = new MemberRepository(_membersContext);
				}
				return _memberRepository;
			}
		}

		public RepositoryWrapper(MembersContext membersContext)
		{
			_membersContext = membersContext;
		}

		public void Save()
		{
			_membersContext.SaveChanges();
		}
	}
}
