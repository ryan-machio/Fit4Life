using System;
using System.ComponentModel.DataAnnotations;

namespace Fit4Life.Models
{
    public class Clients
    {
        [Key] 
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName{ get; set; }
        public string Gender { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        public int Age{ get; set; }
        [Display(Name = "Height (cm)")]

        public double Height{ get; set; }
        [Display(Name = "Weight (kgs)")]
        public double Weight { get; set; }
        [Display(Name = "FM %")]
        [Range(1, 100)]
        public double FatMass{ get; set; }
        [Display(Name = "LBM %")]
        [Range(1, 100)]
        public double LeanBodyMass { get; set; }
        [Display(Name = "TDEE")]
        public double TotalDailyEnergyExpenditure { get; set; }
        [Display(Name = "Last Check-in")]
        [DataType(DataType.Date)]
        public DateTime LastUpdate { get; set; }

    }
}