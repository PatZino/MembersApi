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

		[Display(Name = "First Name")]
		[Required(ErrorMessage = "First Name is required")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "Last Name is required")]
		public string LastName { get; set; }

		[Display(Name = "Middle Name")]
		public string MiddleName { get; set; }

		[Display(Name = "Main Programming Language")]
		[Required(ErrorMessage = "Main Programming Language is required")]
		public string MainProgrammingLanguage { get; set; }

		[Display(Name = "Other Languages")]
		public string OtherLanguages { get; set; }

		public string Interest { get; set; }

		[Display(Name = "Years of experience")]
		[Required(ErrorMessage = "Years of experience is required")]
		public string YearsOfExperience { get; set; }

		[Display(Name = "Country Of Residence")]
		[Required(ErrorMessage = "Country Of Residence")]
		public string CountryOfResidence { get; set; }

		[Display(Name = "City Of Residence")]
		public string CityOfResidence { get; set; }
	}
}
