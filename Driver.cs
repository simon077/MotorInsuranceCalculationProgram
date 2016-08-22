using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorInsuranceCalculationProgram
{
    public class Driver
    {
        //Class Variables
        private string fullName { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string occupation { get; set; }
        private int numberOfClaims { get; set; }
        private List<DateTime> claimDate { get; set; }

        // Constructors
        public Driver() { }

        public Driver(string fullName, DateTime dateOfBirth, string occupation, int numberOfClaims, List<DateTime> claimDate)
        {
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.occupation = occupation;
            this.numberOfClaims = numberOfClaims;
            this.claimDate = claimDate;

        }

        // Gets & Sets
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public int NumberOfClaims
        {
            get { return numberOfClaims; }
            set { numberOfClaims = value; }
        }

        public List<DateTime> ClaimDate
        {
            get { return claimDate; }
            set { claimDate = value; }
        }

    } 

}
