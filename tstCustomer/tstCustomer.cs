using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clsCustomerLibrary;

namespace tstCustomer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            //test to ensure it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ACustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            ACustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            ACustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            ACustomer.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            ACustomer.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HomeAddress, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            ACustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            ACustomer.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result if correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customername
            if (ACustomer.CustomerID != 1)
            {
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }               
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.DOB != Convert.ToDateTime("11/06/1989"))
            {
                OK = false;
               
            }
             //test to see that the result is correct
             Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.EmailAddress != "igho@yahoo.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.FirstName != "igho")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.LastName != "akponah")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenderFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.Gender != "male")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.PhoneNo != "0123456789")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHomeAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.HomeAddress != "6 Cavendish Mews")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property

            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "igho";
            string LastName = "akponah";
            string Gender = "male";
            string HomeAddress = "6 Cavendish mews";
            string EmailAddress = "igho@yahoo.com";
            string PhoneNo = "0123456789";
            string DOB = DateTime.Now.Date.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Gender, HomeAddress, EmailAddress, PhoneNo, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = ""; //this should fail
            string lastName = "abcd"; 
            string homeAddress = "6 cavendish mews";
            string phoneNo = "0123456789";
            string emailAddress = "abc@123.com";
            string gender = "male";
            
            //invoke the method
            AllOK = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.IsFalse(AllOK);
        }

        
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "A"; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string phoneNo = "0123456789";
            string emailAddress = "abc@123.com";
            string gender = "male";

            //invoke the method
            AllOK = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.IsTrue(AllOK);
        }

        
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "AA"; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string phoneNo = "0123456789";
            string emailAddress = "abc@123.com";
            string gender = "male";

            //invoke the method
            AllOK = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.IsTrue(AllOK);
        }

        /*
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean AllOK = false;
            //create some test data to pass to the method
            string TestData = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDE"; //this should FAIL

            //invoke the method
            AllOK = ACustomer.FirstNameValid(ACustomer.FirstName, TestData);
            //test to see that the result if correct
            //this should fail as it is over 25 characters long
            Assert.IsFalse(AllOK);
        }
        */
    }
}
