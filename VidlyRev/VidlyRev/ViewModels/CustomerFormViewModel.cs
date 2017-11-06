﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRev.Models;

namespace VidlyRev.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title { get { return Customer.Id == 0 ? "New Customer" : "Edit Customer"; } }
    }
}