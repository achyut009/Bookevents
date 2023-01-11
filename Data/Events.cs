using BooksEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEvents.Data
{
    public class Events
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public DateTime Time { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public string OtherDetail { get; set; }

        public string Type { get; set; }

        public string InvitedBy { get; set; }
        public string UserId { get; set; }

        public UserModel User { get; set; }
    }
}
