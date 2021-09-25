using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecipeMaster.Data;
using RecipeMaster.Models;

namespace RecipeMaster.Pages.RecipePages
{
    public class CreateModel : PageModel
    {
        private readonly RecipeMaster.Data.RecipeMasterContext _context;

        public CreateModel(RecipeMaster.Data.RecipeMasterContext context)
        {
            _context = context;
        }

      
        [BindProperty]
        public Recipe Recipe { get; set; }
        [BindProperty]
        public List<SelectListItem> LkpRecipeDifficulty { get; set; }
        [BindProperty]
        public List<SelectListItem> LkpRecipeCategory { get; set; }

        public IActionResult OnGet()
        {
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

        void AddLkpRecipeCategories(string[] splittedRecipeCategories, List<LkpRecipeCategory> lkpRecipeCategories, ref List<int> ids)
        {
            foreach (var item in splittedRecipeCategories)
            {
                var trimmedItem = item.Trim();
                var isExistLkpRecipeCategory = lkpRecipeCategories.FirstOrDefault(x => x.CategoryName == trimmedItem);
                if (isExistLkpRecipeCategory != null)
                {
                    ids.Add(isExistLkpRecipeCategory.Id);
                }
                if (isExistLkpRecipeCategory == null)
                {
                    var newLkhCategory = new LkpRecipeCategory
                    {
                        CategoryName = item,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now
                    };
                    _context.LkpRecipeCategory.Add(newLkhCategory);
                    _context.SaveChanges();
                    ids.Add(newLkhCategory.Id);
                }
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Add Creation Date and User
            Recipe.CreatedDate = DateTime.Now;
            Recipe.CreatedBy = 1; // TO DO update this after implementing authentication
            List<int> ids = new List<int>();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Recipe.SelectedLkpRecipeCategories != null && Recipe.SelectedLkpRecipeCategories.Length > 0)
            {
                string recipeCategories = Recipe.SelectedLkpRecipeCategories;
                var lkpRecipeCategory = _context.LkpRecipeCategory.ToList();
                string[] splittedRecipeCategories = recipeCategories.Split(',');
                
                AddLkpRecipeCategories(splittedRecipeCategories, lkpRecipeCategory, ref ids);
            }

            Recipe.CategoryNames = Recipe.SelectedLkpRecipeCategories;
            _context.Recipe.Add(Recipe);
            await _context.SaveChangesAsync();

            foreach (int id in ids)
            {
                _context.RecipeCategory.Add(new RecipeCategory
                {
                    CategoryId = id,
                    CreatedBy = 1,
                    RecipeId = Recipe.Id,
                    CreatedDate = Recipe.CreatedDate
                }); 

                await _context.SaveChangesAsync(); 
            }

            
            return RedirectToPage("./Index");
        }
    }
}
