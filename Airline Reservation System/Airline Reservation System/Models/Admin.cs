//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_Reservation_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Admin
    {
        public int Ticket_Id { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string AirlineName { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string From { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string To { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string Depart_Time { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string Arrival_Time { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string Seat { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string Fare { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public int Day { get; set; }

        [Required(ErrorMessage = "This field is empty")]
        public string Month { get; set; }
    }
}