﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelsAndRepository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VSMDatabaseEntitiesModels : DbContext
    {
        public VSMDatabaseEntitiesModels()
            : base("name=VSMDatabaseEntitiesModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<artikul> artikuls { get; set; }
        public virtual DbSet<barcode> barcodes { get; set; }
        public virtual DbSet<Default_partner> Default_partner { get; set; }
        public virtual DbSet<doc_type> doc_type { get; set; }
        public virtual DbSet<document> documents { get; set; }
        public virtual DbSet<document_detail> document_detail { get; set; }
        public virtual DbSet<dogovor> dogovors { get; set; }
        public virtual DbSet<dogovor_dost> dogovor_dost { get; set; }
        public virtual DbSet<obect> obects { get; set; }
        public virtual DbSet<pari> paris { get; set; }
        public virtual DbSet<partner> partners { get; set; }
        public virtual DbSet<podvid> podvids { get; set; }
        public virtual DbSet<Proizvoditel> Proizvoditels { get; set; }
        public virtual DbSet<revizia> revizias { get; set; }
        public virtual DbSet<stoka> stokas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vid> vids { get; set; }
        public virtual DbSet<zajavka> zajavkas { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
    }
}
