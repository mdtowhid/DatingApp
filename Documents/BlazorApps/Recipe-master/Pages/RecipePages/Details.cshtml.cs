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
    public class DetailsModel : PageModel
    {
        private readonly RecipeMaster.Data.RecipeMasterContext _context;

        public DetailsModel(RecipeMaster.Data.RecipeMasterContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.Id == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
