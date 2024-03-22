using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSoftwareII.Models
{
	public class City : CommonInfo
	{
		public int cityID { get; set; }
		public string city { get; set; }
		public int countryID { get; set; }
	}
}