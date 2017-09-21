namespace SWDomain.Model
{
    using SWDomain.Model.Base;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TItem")]
    public partial class Item : EntityBase
    {
        public Item() : base("Item") { }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
