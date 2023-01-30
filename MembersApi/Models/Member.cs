using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MembersApi.Models
{
	public class Member
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public string MiddleName { get; set; }

		[Phone]
		[Required]
		public string PhoneNumber { get; set; }

		[Required]
		public string MainProgrammingLanguage { get; set; }

		public string OtherLanguages { get; set; }

		public string Interest { get; set; }

		[Required]
		public string YearsOfExperience { get; set; }

		[Required]
		public string CountryOfResidence { get; set; }

		public string CityOfResidence { get; set; }
	}
}
