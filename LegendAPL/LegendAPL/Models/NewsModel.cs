using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegendALP.Models
{
    public class NewsModel
    {
        public string IDNews { get; set; }
        public string NewsHeader { get; set; }
        public string NewsIMGPath { get; set; }
        public string NewsDate { get; set; }
        public string NewsText { get; set; }
        public string NewsYear { get; set; }

        public List<ContactDetails> ContactDetails { get; set; }

        public NewsModel()
        {
            ContactDetails = new List<ContactDetails>();
        }
    }
}