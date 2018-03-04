using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;

namespace clsCustomerLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        
        public clsCustomer ThisCustomer { get; set; }


        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            { //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            { //return the count of the list
                return mCustomerList.Count;
            }
            set
            { 
                // TBC
            }
        }
    }

    
}