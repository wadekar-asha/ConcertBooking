using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBooking.Entities
{

    //Teacher(1)-------------(*)TeacherSubject(*)--------------(1)Subject
    public class TeacherSubject
    {
       // public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
       

    }
}


// Teacher             TeacherSubject                Subject
// Id   name             TeacherId  SubjectId        Id  Name 
// 1     Ramesh             1         1              1    Hindi
// 2     Suresh             1          2              2    maths 
// 3     Amit               2          1             3    Social

// Fluent API

