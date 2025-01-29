using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RpgRecommendation.Models
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

        public DbSet<Rpg> Rpgs { get; set; }
    }

    public class Rpg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorldType { get; set; } // Ex: "aberto", "linear"
        public string CombatType { get; set; } // Ex: "tempo real", "turnos"
        public string StoryTone { get; set; } // Ex: "sombria", "leve"
        public bool HasCharacterCustomization { get; set; }
        public string GraphicsStyle { get; set; } // Ex: "realistas", "estilizados"
    }
}