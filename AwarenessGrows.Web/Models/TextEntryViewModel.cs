using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwarenessGrows.Web.Models
{
    public class TextEntryViewModel
    {

        public int TextEntryId { get; set; }

        public string Title { get; set; }

        public string BodyUrl { get; set; }

        public string SourceUrl {get;set;}

        public string IllistartionUrl { get; set; }
    }
}