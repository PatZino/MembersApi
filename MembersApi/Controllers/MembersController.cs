using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MembersApi.Contracts;
using MembersApi.Models;
using Microsoft.AspNetCore.Mvc;

// https://localhost:5001/swagger/index.html

namespace MembersApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MembersController : ControllerBase
	{
		private readonly IMapper _mapper;
		private readonly IRepositoryWrapper _repository;

		public MembersController(IRepositoryWrapper repository, IMapper mapper)
		{
			_mapper = mapper;
			_repository = repository;
		}

		[HttpGet]
		public IEnumerable<Member> Get()
		{
			var allMembers = _repository.Member.FindAll();
			return allMembers;
		}

		[HttpGet("{id}")]
		public Member Get(int id)
		{
			var memberDetails = _repository.Member.FindByCondition(x => x.Id == id).FirstOrDefault();
			return memberDetails;
		}

		[HttpPost]
		public ActionResult Post([FromBody] MemberViewModel model)
		{
			var createModel = _mapper.Map<Member>(model);

			try
			{
				_repository.Member.Create(createModel);
				_repository.Save();
				return Ok();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromBody] MemberViewModel model)
		{
			var memberDetails = _repository.Member.FindByCondition(x => x.Id == id).FirstOrDefault();
			
			try
			{
				if (memberDetails == null)
				{
					return BadRequest();
				}

				var updateModel = _mapper.Map<MemberViewModel, Member>(model, memberDetails);
				_repository.Member.Update(updateModel);
				_repository.Save();
				return NoContent();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return BadRequest();
			}
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			var memberDetails = _repository.Member.FindByCondition(x => x.Id == id).FirstOrDefault();
			_repository.Member.Delete(memberDetails);
			_repository.Save();
		}
	}
}
