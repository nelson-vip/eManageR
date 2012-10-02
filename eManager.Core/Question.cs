using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Core
{
    public class Question
    {
        public virtual int Id { get; set; }
        public virtual int Index { get; set; }
        public virtual string Content { get; set; }
    }
}
