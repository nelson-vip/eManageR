using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Core
{
    public class Exam
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int Level { get; set; }
        public virtual int Year { get; set; }
        public virtual int Location { get; set; }
        public virtual int County { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
