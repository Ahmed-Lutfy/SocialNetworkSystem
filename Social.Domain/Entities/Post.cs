using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Domain.Entities
{
   public class Post : BaseEntity
    {
       
        public int user_id { get; set; }
        public string content { get; set; }
        public string media_url { get; set; }
        public string status { get; set; }
        public bool isActive { get; set; }
        

    }
}
