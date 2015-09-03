using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvWorks.Core
{
    [Table("Person.Person")]
    public class PersonReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessEntityID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; private set; }       

        [Required]
        [StringLength(50)]
        public string LastName { get; private set; }

        //Does not map to Table Person
        public string FullName
        {
            get { return string.Concat(FirstName + " " + LastName); }
        }

    }
}