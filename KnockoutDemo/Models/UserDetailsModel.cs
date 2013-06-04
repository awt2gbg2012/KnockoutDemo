using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutDemo.Models
{
    public class UserDetailsModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public List<Friend> friends { get; set; }
    }

    public class Friend
    {
        public string name { get; set; }
        public bool isOnTwitter { get; set; }
        public string twitterHandle { get; set; }
    }
}