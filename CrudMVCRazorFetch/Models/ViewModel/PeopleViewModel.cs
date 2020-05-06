﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CrudMVCRazorFetch.Models.ViewModel
{
    public class PeopleViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Edad")]
        public int? Age { get; set; }
    }
}