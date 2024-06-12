using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
	public class AppUser:IdentityUser<int>
	{
        public string Name { get; set; }
        public string Surname { get; set; }
		public string Address {  get; set; }
		public string City { get; set; }
	
		public string ConfirmCode { get; set; }
		public bool Confirmed { get; set; }
	}
}
