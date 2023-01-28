using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MembersApi.Models;

namespace MembersApi.Utilities
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Member, MemberViewModel>().ReverseMap();
		}
		
	}
}
