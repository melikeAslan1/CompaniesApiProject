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
    [Table("CompanyDepartments")]
    public class CompanyDepartment:IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }


        [Required]
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Required]
        public int DepartmentId { get; set; }


        [Required]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }


        public int? UstDepartmentId { get; set; }


    }

   

       
}
