using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRedBadgeProject.Models
{
    public class Play
    {
        public int UserID { get; set; }
        public int BoardGameID { get; set; }
        public int TimesPlayed { get; set; }
        public string Review { get; set; }
        public bool IsReviewPrivate { get; set; }
        public double Rating { get; set; }
    }
}