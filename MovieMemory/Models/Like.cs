﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMemory.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UpdateId { get; set; }

        public User User { get; set; }
        public Update Update { get; set; }
    }
}