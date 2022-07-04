using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiAutomationBL.Requests
{
    public class CreatePostValidRequest
    {
        public int id { get; set; }
        public String title { get; set; }
        public String author { get; set; }
    }
}
