using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrmDemo.DBEntities
{
    public class Authors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Comment { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }
        public string Comment6 { get; set; }
        public string Comment7 { get; set; }
        public string Comment8 { get; set; }
        public string Comment9 { get; set; }
        public string Comment10 { get; set; }
        public string Comment11 { get; set; }
        public string Comment12 { get; set; }
        public string Comment13 { get; set; }
        public string Comment14 { get; set; }
        public string Comment15 { get; set; }

    }
}
