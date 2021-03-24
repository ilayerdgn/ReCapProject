using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }

    }
}
