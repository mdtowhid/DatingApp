using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecipeMaster.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Display(Name = "Recipe Name")]
        [Required]
        public string Name { get; set; }
        public string Source { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        [Display(Name = "Servings")]
        public int? NumServings { get; set; }
        [Display(Name = "Difficulty")]
        public int? DifficultyId { get; set; }
        public string Prep { get; set; }
        public string Cook { get; set; }
        public string Total { get; set; }
        public string Notes { get; set; }

        public bool FavoriteFlag { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [NotMapped]
        public string SelectedLkpRecipeCategories { get; set; }
    }
}
