using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazor.Pages
{
	public class HobbiesModel : PageModel
	{
		public List<Hobby> HobbiesList { get; set; }

		public void OnGet()
		{
			HobbiesList = new List<Hobby>(){
				new Hobby()
				{
					Name = "Hobby1",
					Description = "Description1"

				},
				new Hobby()
				{
					Name = "Hobby2",
					Description = "Description3"
				},
				new Hobby()
				{
					Name = "Hobby3",
					Description = "Description3"
				}
			};
		}
	}
}
