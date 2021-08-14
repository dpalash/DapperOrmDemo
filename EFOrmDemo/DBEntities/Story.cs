namespace EFOrmDemo.DBEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Story
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateTime { get; set; }

        [StringLength(450)]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
