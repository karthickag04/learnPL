using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace brightskills.Models
{
    public class AddCourseModel
    {
        [Key]
        public int? course_id{get; set;}
        public string? course_name {get; set;} 
        public string? course_duration {get; set;} 
        public string? course_description {get; set;} 
        public string? trainer_name {get; set;} 
       

    }
}