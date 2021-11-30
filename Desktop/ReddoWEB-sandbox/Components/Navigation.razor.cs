using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddocoin.Components
{
    public partial class Navigation
    {
        public string LogoUrl { get; set; } = "./Images/Vertical Logo with Icon.png";

        public bool Show { get; set; } = false;
        public string MenuClassNames { get; set; } = "NavigationLinks";
        public void MenuToggler()
        {
            Show = !Show;
            if (Show)
            {
                MenuClassNames = "NavigationLinks active";
            }
            else
            {
                MenuClassNames = "NavigationLinks";
            }
            StateHasChanged();
        }

        public void HideMenu()
        {
            Show = false;
            MenuClassNames = "NavigationLinks";
        }
    }
}
