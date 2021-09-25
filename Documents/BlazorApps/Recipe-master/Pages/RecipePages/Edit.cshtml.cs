using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecipeMaster.Data;
using RecipeMaster.Models;

namespace RecipeMaster.Pages.RecipePages
{
    public class EditModel : PageModel
    {
        private readonly RecipeMaster.Data.RecipeMasterContext _context;

        public EditModel(RecipeMaster.Data.RecipeMasterContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipe Recipe { get; set; }
        [BindProperty]
        public List<SelectListItem> LkpRecipeDifficulty { get; set; }
        [BindProperty]
        public List<SelectListItem> LkpRecipeCategory { get; set; }
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

            LkpRecipeDifficulty = _context.LkpRecipeDifficulty.Select(a =>
               new SelectListItem
               {
                   Value = a.Id.ToString(),
                   Text = a.Difficulty
               }
           )
           .ToList();

            LkpRecipeCategory = _context.LkpRecipeCategory.Select(b =>
              new SelectListItem
              {
                  Value = b.Id.ToString(),
                  Text = b.CategoryName
              }
          )
          .ToList();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(Recipe.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipe.Any(e => e.Id == id);
        }
    }
}
