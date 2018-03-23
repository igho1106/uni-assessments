using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Class_Library;
using clsCustomerLibrary;

namespace tstCustomerCollection
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assin to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.EmailAddress = "abc@123.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.PhoneNo = "01234567891";
            TestItem.HomeAddress = "8 Millstone Lane";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }



        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assin to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties 
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.DOB = DateTime.Now.Date;
            TestCustomer.EmailAddress = "abc@123.com";
            TestCustomer.FirstName = "John";
            TestCustomer.LastName = "Doe";
            TestCustomer.PhoneNo = "01234567891";
            TestCustomer.HomeAddress = "3 Millstone Lane";

            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assin to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DOB = DateTime.Now.Date;
            TestItem.EmailAddress = "abc@123.com";
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.PhoneNo = "01234567891";
            TestItem.HomeAddress = "3 Millstone Lane";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create a the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.DOB = DateTime.Now.AddYears(-19);
            TestItem.EmailAddress = "abc@123.com";
            TestItem.HomeAddress = "2 Leicester square";
            TestItem.FirstName = "John";
            TestItem.Gender = "Male";
            TestItem.LastName = "James";
            TestItem.PhoneNo = "01234567891";
            TestItem.PostCode = "LO8 18H";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
    }
}