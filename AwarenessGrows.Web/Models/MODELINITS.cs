using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AwarenessGrows.Web.Models;

namespace AwarenessGrows.Web.Models
{
    public static class MODELINITS
    {

        public static TextEntryViewModel FINDTEXTENTRY(int id)
        {
            return GETTEXTENTRIES().Where(te => te.TextEntryId == id).First();
        }
        public static List<TextEntryViewModel> GETTEXTENTRIES()
        {
            return new List<TextEntryViewModel>
            {
                new TextEntryViewModel
                {
                    TextEntryId=1,
                    Title="Universal Declaration Of Human Rights",
                    BodyUrl="/Content/UploadedContent/TextFiles/UDHR.txt",
                    SourceUrl="http://www.un.org/en/documents/udhr/",
                    IllistartionUrl="/Content/UploadedContent/images/OHCHR_Logo_811x82.jpeg"
                },

                new TextEntryViewModel
                {
                    TextEntryId=2,
                    Title="Statement by Mr Michael Kirby Chair of the Commission of Inquiry on Human Rights in the Democratic People’s Republic of Korea to the 25th session of the Human Rights Council, Geneva, 17 March 2014",
                    BodyUrl="/Content/UploadedContent/TextFiles/OHCHR_Statement.txt",
                    SourceUrl="http://www.ohchr.org/EN/NewsEvents/Pages/DisplayNews.aspx?NewsID=14385&LangID=E",
                    IllistartionUrl="/Content/UploadedContent/images/OHCHR_Logo_811x82.jpeg"
                }
            };
        }

        public static MultimediaEntryViewModel FINDMMENTRY(int id)
        {
            return GETMMENTRIES().Where(mm => mm.MultimediaEntryId == id).First();
        }
        public static List<MultimediaEntryViewModel> GETMMENTRIES()
        {
            return new List<MultimediaEntryViewModel>
            {
                new MultimediaEntryViewModel
                {
                    MultimediaEntryId=1,
                    MediaType="YouTube",
                    MediaUrl="https://www.youtube.com/embed/7YTvvdPC2Ww",
                    Title="North Korea Documentary: \"The Defectors\" - Sky News",
                    SourceUrl="https://www.youtube.com/watch?v=7YTvvdPC2Ww&list=LLSsXqqBYQ4u3YATED1fQ6-Q"
                }
            };
        }
    }
}