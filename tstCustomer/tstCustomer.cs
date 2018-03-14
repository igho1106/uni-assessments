using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

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
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
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
                OK = false;
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

            if (ACustomer.EmailAddress != "abc@123.com")
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

            if (ACustomer.FirstName != "John")
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

            if (ACustomer.LastName != "Meyer")
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

            if (ACustomer.Gender != "Male")
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

            if (ACustomer.HomeAddress != "9 Millstone Lane")
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
            string FirstName = "abcd";
            string LastName = "efgh";
            string HomeAddress = "9 Millstone Lane";
            string Gender = "male";
            string EmailAddress = "abcd@yahoo.com";
            string PhoneNo = "01234567891";
            string DOB = "02/02/2000";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, HomeAddress, EmailAddress, Gender, PhoneNo, DOB, postCode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = ""; //this should fail
            string lastName = "abcd"; 
            string homeAddress = "9 Millstone Lane";
            string phoneNo = "01234567891";
            string emailAddress = "abcd@123.com";
            string gender = "male";
            string DOB = "11/06/89";
            string postCode = "LE1 1BH";

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void FirstNameMin()//check
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "A"; //this should fail
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "abcd@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()//check
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "A"; 
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "abcd@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            firstName = firstName.PadRight(13, 'A');//this should pass

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "AA"; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = ""; //this should pass
            string lastName = "A";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";     
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";

            firstName = firstName.PadRight(25, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should pass as it is 25 charaacters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "bb";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";

            firstName = firstName.PadRight(26, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is over 25 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = ""; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            firstName = firstName.PadRight(24, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should pass as it'll return no error
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = ""; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            firstName = firstName.PadRight(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "";//this should fail
            string homeAddress = "6 cavendish mews";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; 
            string lastName = "";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            lastName = lastName.PadRight(13, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            lastName = lastName.PadRight(25, 'A');

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            lastName = lastName.PadRight(24, 'A');//this should pass

            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1B";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH1";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1A 1BH1";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1A 1BH12";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1A 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //Boolean AllOK = false;
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "a";//this should pass
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "";
            postCode = postCode.PadRight(15, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = ""; //this should pass
            string lastName = "";
            string homeAddress = "6 cavendish mews";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            lastName = lastName.PadRight(26, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is over 26 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //boolean variable to store the result of the validation
            //create some test data to pass to the method
            string firstName = "AA"; //this should pass
            string lastName = "ab";
            string homeAddress = "6 cavendish mews";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";            
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //set to false as it does not meet req.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "a"; //this should pass
            string lastName = "abcd";
            string homeAddress = "6 cavendish mews";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            lastName = lastName.PadRight(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "aa";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(9, 'A');//this should fail and cause an error
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HomeAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(10, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(11, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(50, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(49, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(51, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string phoneNo = "01234567891";
            string emailAddress = "abc@123.com";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            homeAddress = homeAddress.PadRight(100, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, phoneNo, emailAddress, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "";
            string phoneNo = "01234567891";
            string emailAddress = "@aol.com";//this should fail
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, phoneNo, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "a@aol.com";//this should pass
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";//this should pass
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";//this should pass
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            emailAddress = emailAddress.PadRight(50, 'A');
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            emailAddress = emailAddress.PadRight(51, 'A');//this should pass
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "";
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            emailAddress = emailAddress.PadRight(49, 'A');//this should pass
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string phoneNo = "01234567891";
            string emailAddress = "";
            string gender = "male";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            emailAddress = emailAddress.PadRight(100, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, phoneNo, gender, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string phoneNo = "01234567891";
            string emailAddress = "ab@aol.com";//this should pass
            string gender = "Female";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";//this should pass
            string gender = "male";
            string phoneNo = "01234567891";
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; 
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "male";
            string phoneNo = "01234567891";//this should pass
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "0123456789177777";//this should fail
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567891234561";//this should fail
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "012345678912345";//this should fail
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567";//this should fail
            string DOB = "11/06/1989";
            string postCode = "LE1 1BH";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; //this should pass
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567";//this should fail
            string DOB = "11/06/2002";
            string postCode = "LE1 1BH";
            phoneNo = phoneNo.PadRight(100, 'A');//this should fail
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            //this should fail as it is 100 characters long
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa"; 
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567891";
            string postCode = "LE1 1BH";
            //phoneNo = phoneNo.PadRight(100, 'A');//this should fail
            //create a variable to store the test DOB
            DateTime dOB;
            //set the date to todays date
            dOB = DateTime.Now.Date;
            //change the date to whatever the date is, less than 17 years (Underage)
            dOB = dOB.AddYears(-17);
            //convert the date variable to a string variable
            string DOB = dOB.ToString();
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa";
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567891";
            string postCode = "LE1 1BH";
            //phoneNo = phoneNo.PadRight(100, 'A');//this should fail
            //create a variable to store the test DOB
            DateTime dOB;
            //set the date to todays date
            dOB = DateTime.Now.Date;
            //change the date to whatever the date is less than 170
            dOB = dOB.AddYears(-18); dOB.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = dOB.ToString();
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa";
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567891";
            string postCode = "LE1 1BH";
            //phoneNo = phoneNo.PadRight(100, 'A');//this should fail
            //create a variable to store the test DOB
            DateTime dOB;
            //set the date to todays date
            dOB = DateTime.Now.Date;
            //change the date to whatever the date is less than 170
            dOB = dOB.AddYears(-18); dOB.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = dOB.ToString();
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DOBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string firstName = "aa";
            string lastName = "abcd";
            string homeAddress = "9 Millstone Lane";
            string emailAddress = "ab@aol.com";
            string gender = "Female";
            string phoneNo = "01234567891";
            string postCode = "LE1 1BH";
            //set the DOB to a non date value
            string DOB = "this is not a data!";
            //invoke the method
            Error = ACustomer.Valid(firstName, lastName, homeAddress, emailAddress, gender, phoneNo, DOB, postCode);
            //test to see that the result if correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
