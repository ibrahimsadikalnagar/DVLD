using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsPeopleB
    {
        enum enMode { AddNew = 0 , Update = 1 };
        enMode Mode = enMode.AddNew;
        public int PeopleId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }  
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth {  get; set; }
        public string Address { get; set; }
        public byte Gendor {  get; set; }
        public string CountryName { get; set; }
        public string ImagePath {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

      
        public clsPeopleB() 
        { 
            PeopleId = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationalId = ""; 
            DateOfBirth = DateTime.Now;
            Email = "";
            Phone = "";
            Address = "";
            ImagePath = ""; 
            Gendor = 0;
            CountryName = "";

            Mode = enMode.AddNew; 
        }
        private clsPeopleB(int peopleId, string firstName, string secondName, string thirdName, string lastName, string nationalId, DateTime dateOfBith, string address, byte gendor, string countryName, string imagePath, string email, string phone)
        {
           
            PeopleId = peopleId;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalId = nationalId;
            DateOfBirth = dateOfBith;
            Address = address;
            Gendor = gendor;
            CountryName = countryName;
            ImagePath = imagePath;
            Email = email;
            Phone = phone;
            Mode = enMode.Update;
        }

        public static clsPeopleB Find(int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                Email = "", Phone = "", CountryName = "", Address = "", ImagePath = ""
                , NationalNo = "";

            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            if (clsPeopleD.GetContactByID(ID, ref FirstName, ref SecondName
            , ref ThirdName, ref LastName, ref NationalNo
            , ref DateOfBirth, ref Gendor, ref Phone, ref Email,
            ref CountryName, ref Address, ref ImagePath))
                return new clsPeopleB(ID, FirstName, SecondName, ThirdName, LastName,
                     NationalNo, DateOfBirth, Address, Gendor, CountryName, ImagePath,Email, Phone);
            else

                return null;
            
        }
        public static DataTable GetAllContact()
        {
            return clsPeopleD.GetAllContact();
        }
        public static DataTable GetAllCountries()
        {
            return clsPeopleD.GetAllCountries();
        }
        public  bool AddAllPeopleAndGetIDLastNewRecord()
        {

            this.PeopleId = clsPeopleD.AddAllContactModified(this.FirstName, this.SecondName, this.ThirdName
                   , this.LastName, this.NationalId, this.DateOfBirth,
                   this.Address, this.Gendor, this.CountryName, this.ImagePath, this.Email, this.Phone);

            return (this.PeopleId != -1);
            



        }

    }
}
