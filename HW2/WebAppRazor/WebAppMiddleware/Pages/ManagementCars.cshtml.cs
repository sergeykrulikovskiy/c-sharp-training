using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppRazor.Pages { 
    public class ManagementCarsModel : PageModel
    {
		public List<string> Engines { get; set; }
		public List<string> Vendors { get; set; }
		
		public IList<Car>? carListResult { get; set; }
		
		[BindProperty(SupportsGet = true)]
		public string Vendor { get; set;  }
		[BindProperty(SupportsGet = true)]
		public string Engine { get; set; }
        
		[BindProperty]
        public List<SelectListItem> VendorsListForDropdown { get; set; }

        public async Task OnGet()
        {
			IManagementCars managementCars = new ManagementCars();
			
			Engines = managementCars.getEngines();
			Vendors = managementCars.getVendors();

			VendorsListForDropdown = Vendors.Select(x => new SelectListItem { Text = x, Value = x }).ToList();

			if (!String.IsNullOrEmpty(Vendor) && !String.IsNullOrEmpty(Engine))
				carListResult = managementCars.SearchCar(car => car.Name.ToLower() == Vendor.ToLower() && car.Engine.ToLower() == Engine.ToLower());
			else
			{
				if (!String.IsNullOrEmpty(Vendor))
					carListResult = managementCars.SearchCar(car => car.Name.ToLower() == Vendor.ToLower());

				if (!String.IsNullOrEmpty(Engine))
					carListResult = managementCars.SearchCar(car => car.Engine.ToLower() == Engine.ToLower());
			}

		}
	}
}
