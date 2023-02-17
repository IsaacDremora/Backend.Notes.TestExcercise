using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain
{
    public class Note
    {
        public Guid UserID { get; set; }
        public Guid ID { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public DateTime CrationDate { get; set; }
        public DateTime? EditDate { get; set; }


    }
}
