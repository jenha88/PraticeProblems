using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Part1
{
   public class Address
    {
        public int  StreetNum {get;set;}
        public string StreetNam {get;set;}
        public string State{get;set;}
        public string City {get;set;}
        public int ZipCode{get;set;}

        public Address() //default constructor 
        {
            StreetNum = 0;
            StreetNam = "";
            State = "";
            City = "";
            ZipCode = 0;

        }
        public Address(int streetnumber,string streetname, string state, string city, int zipcode) //setting the constructor to pass the information
        {
            streetnumber = StreetNum;
            streetname = StreetNam;
            state = State;
            city = City;
            zipcode = ZipCode;
        }

    } 
}
