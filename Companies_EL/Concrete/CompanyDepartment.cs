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
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }


        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        //public string CompanyName { get; set; }

        [Required]
        public int DepartmentId { get; set; }


        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        //public string DepartmentName { get; set; }

        public int? UstDepartmentId { get; set; }
        //public int MyProperty { get; set; }


    }

   

       
}
