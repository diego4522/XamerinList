using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class MenuListData : List<MenuItem>
	{
		class EmployeeCell : ViewCell
		{
			
		}

		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "Diego", 
				IconSource = "diego.png", 
				Correo = "diego4522",
				TargetType = typeof(ContractsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Jose", 
				IconSource = "jose.jpg", 
				Correo = "joseotro",
				TargetType = typeof(LeadsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Andre", 
				IconSource = "andre.png", 
				Correo = "adreito",
				TargetType = typeof(AccountsPage)
			});

			this.Add (new MenuItem () {
				Title = "Flavio",
				IconSource = "flavio.jpg",
				Correo = "flavioandre",
				TargetType = typeof(OpportunitiesPage)
			});
			this.Add (new MenuItem () { 
				Title = "Diego", 
				IconSource = "diego.png", 
				Correo = "diego4522",
				TargetType = typeof(Contracts)
			});

			//Contracts
		}
	}
}