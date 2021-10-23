using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRedBadgeProject.Models
{
    public class Friend
    {
        public int FriendID { get; set; }
        public int UserID1 { get; set; }
        public int UserID2 { get; set; }
    }
}