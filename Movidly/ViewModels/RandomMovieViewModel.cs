﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movidly.Models;

namespace Movidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}