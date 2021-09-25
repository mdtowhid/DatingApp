using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipeMaster.Data
{
    public class RecipeMasterContext : DbContext
    {
        public RecipeMasterContext (DbContextOptions<RecipeMasterContext> options)
            : base(options)
        {

        }

        public DbSet<RecipeMaster.Models.Recipe> Recipe { get; set; }
        public DbSet<RecipeMaster.Models.LkpRecipeDifficulty> LkpRecipeDifficulty {get; set; }

        public DbSet<RecipeMaster.Models.LkpRecipeCategory> LkpRecipeCategory { get; set; }
        public DbSet<RecipeMaster.Models.RecipeCategory> RecipeCategory { get; set; }


    }
}
