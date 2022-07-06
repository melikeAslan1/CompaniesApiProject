using Companies_EL.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies_EL.Concrete
{
    [Table("Companies")]
    public class Company : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string CompanyType { get; set; }

        [StringLength(50)]
        public string TaxAdministration { get; set; }

        public int TaxId { get; set; }

        [StringLength(50)]
        public string CompanyCity { get; set; }
        [StringLength(50)]
        public string CompanyDistrict { get; set; }
        [StringLength(50)]
        public string CompanyAddress { get; set; }

        public virtual ICollection<Department> departments { get; set; }
    }
}
