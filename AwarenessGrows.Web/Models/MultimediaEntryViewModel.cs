using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwarenessGrows.Web.Models
{
    public class MultimediaEntryViewModel
    {
        public int MultimediaEntryId { get; set; }

        public string Title { get; set; }

        public string MediaUrl { get; set; }

        public string MediaType { get; set; }

        public string SourceUrl { get; set; }
    }
}