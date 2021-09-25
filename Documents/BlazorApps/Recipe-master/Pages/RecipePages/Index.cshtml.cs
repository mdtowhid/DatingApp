using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeMaster.Data;
using RecipeMaster.Models;

namespace RecipeMaster.Pages.RecipePages
{
    public class IndexModel : PageModel
    {
        private readonly RecipeMaster.Data.RecipeMasterContext _context;

        public IndexModel(RecipeMaster.Data.RecipeMasterContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
