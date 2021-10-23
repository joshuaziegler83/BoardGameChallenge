using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRedBadgeProject.Models
{
    public class BoardGame
    {
        public int BoardGameID { get; set; }
        public string Name { get; set; }
        public double CurrentRating { get; set; }
    }
}