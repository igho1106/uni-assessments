using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace clsCustomerLibrary
{
    public class clsCustomerCollection
    {
        public int Count { get; set; }
        public List<clsCustomer> CustomerList { get; set; }
        public clsCustomer ThisCustomer { get; set; }
    }
}