using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Class_Library
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private int mCustomerID;
        //private data member for the DOB property
        private DateTime mDOB;
        //private data member for the EmailAddress property
        private string mEmailAddress;
        //private data member for the FirstName property
        private string mFirstName;
        //private data member for the Gender property
        private string mGender;
        //private data member for the HomeAddress property
        private string mHomeAddress;
        //private data member for the LastName property
        private string mLastName;
        //private data member for the PhoneNo property
        private string mPhoneNo;
        //private data member for the Active property
        private Boolean mActive;


        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the value of the private data member
                mActive = value;
            }
        }
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the value of the private data member
                mDOB = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }

        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the value of the private data member
                mGender = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                //return the private data
                return mHomeAddress;
            }
            set
            {
                //set the value of the private data member
                mHomeAddress = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data member
                mPhoneNo = value;
            }
        }
        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found there should be either one or zero!
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mHomeAddress = Convert.ToString(DB.DataTable.Rows[0]["HomeAddress"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }


        public string Valid(string firstName, string lastName, string homeAddress, string emailAddress, string gender, string phoneNo, string DOB)
        {
            //create a string variable to store the error
            String Error = "";
            //if the FirstName is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The FirstName field must not be blank : ";
            }
            //if the first name is more than 25 characters long
            if (firstName.Length > 26)
            {
                //record the error 
                Error = Error + "FirstName must not be more than 25 characters";
            }
            //if lastName is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The lastName field must not be blank : ";
            }
            //if lastName is more than 25 characters long
            if (lastName.Length > 26)
            {
                //record the error 
                Error = Error + "lastName must not be more than 25 characters";
            }

            //if homeAddress is blank
            if (homeAddress.Length < 10)
            {
                //record the error
                Error = Error + "The homeAddress field must not be blank : ";
            }
            //if homeAddress is more than 25 characters long
            if (homeAddress.Length > 51)
            {
                //record the error 
                Error = Error + "homeAddress must not be more than 51 characters";
            }

            //if emailAddress is blank
            if (emailAddress.Length < 9)
            {
                //record the error
                Error = Error + "The emailAddress field must not be blank : ";
            }
            //if emailAddress is more than 25 characters long
            if (emailAddress.Length > 51)
            {
                //record the error 
                Error = Error + "emailAddress must not be more than 50 characters";
            }

            //if Gender is blank
            if (gender.Length < 4)
            {
                //record the error
                Error = Error + "The Gender field must not be blank : ";
            }
            //if gender is more than 7 characters long
            if (gender.Length > 6)
            {
                //record the error 
                Error = Error + "Gender must not be more than 6 characters";
            }
            //return any error messages
            return Error;
        }


        

        /*
        public bool Valid(string firstName, string lastName, string homeAddress, string phoneNo, string emailAddress, string gender)
        {
            //create a string variable to store the error
            Boolean FirstNameOK = false;
            Boolean LastNameOK = false;
            Boolean HomeAddressOK = false;
            //if the FirstName is blank or over the limit
            if (firstName.Length == 0 || firstName.Length > 25)
            {
                
                FirstNameOK = false;
                if (lastName.Length == 0)
                {
                    //record the error
                    LastNameOK = false;
                    if (homeAddress.Length == 0 || homeAddress.Length > 50)
                    {
                        HomeAddressOK = false;
                    }
                    else
                    {
                        HomeAddressOK = true;
                    }
                    return HomeAddressOK;
                }
                else
                {
                    LastNameOK = true;
                }
                return LastNameOK;
            }
            else
            {
                FirstNameOK = true;
            }
            return FirstNameOK;
            
        }
        
        else
        {
            FirstNameOK = true;
        }


        return FirstNameOK;
        */
    }
}




/*
 public bool Find(int customerID)
{
    //set the private data members to the test data value
    mCustomerID = 1;
    mHomeAddress = "6 Cavendish Mews";
    mPhoneNo = "0123456789";
    mGender = "male";
    mLastName = "akponah";
    mFirstName = "igho";
    mEmailAddress = "igho@yahoo.com";
    mDOB = Convert.ToDateTime("11/06/1989");
    mActive = true;
    //always return true
    return true;
}

}
*/


