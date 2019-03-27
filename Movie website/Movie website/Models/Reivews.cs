﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class Reivews
    {
        public virtual int ReivewId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual int Marks { get; set; }
        public virtual Films FilmId { get; set; }
        public virtual Users UserId { get; set; }
    }
}