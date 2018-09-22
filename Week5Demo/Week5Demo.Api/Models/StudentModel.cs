using System;
using System.Collections.Generic;

namespace Week5Demo.Api.Models
{
    public class StudentModel
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public ICollection<AddressModel> Addresses { get; set; }
    }
}