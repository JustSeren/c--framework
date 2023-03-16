using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8CodeFirst.Entity
{
    internal class Lesson
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student> students { get; set; }
    }
}
//add-migration addTableAndRelation
//update-database