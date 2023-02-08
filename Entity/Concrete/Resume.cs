using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public DateTime JobTime { get; set; }
        public string City { get; set; }



    }
}
