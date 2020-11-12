using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace web.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEdited { get; set; }

        public ApplicationUser? Owner { get; set; } //? pomeni, da je lahko atribut tudi null

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}