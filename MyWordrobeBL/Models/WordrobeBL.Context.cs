﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWordrobeBL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WordrobeBLewisEntities : DbContext
    {
        public WordrobeBLewisEntities()
            : base("name=WordrobeBLewisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accesory> Accesories { get; set; }
        public virtual DbSet<Bottom> Bottoms { get; set; }
        public virtual DbSet<BottomSize> BottomSizes { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Occasion> Occasions { get; set; }
        public virtual DbSet<Outfit> Outfits { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Sho> Shoes { get; set; }
        public virtual DbSet<ShoeSize> ShoeSizes { get; set; }
        public virtual DbSet<Top> Tops { get; set; }
        public virtual DbSet<TopSize> TopSizes { get; set; }
    }
}
