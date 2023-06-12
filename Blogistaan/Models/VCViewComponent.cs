using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Models
{
	public class VCViewComponent: ViewComponent
	{
		public string Invoke()
		{


			return ("Hello");
		}
	}
}
