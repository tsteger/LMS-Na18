using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Na18.Models
{
    public class MyActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MyTypes MyTypes { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public List<Document> documents { get; set; }
        public int PersonId { get; set; }
    }
}
