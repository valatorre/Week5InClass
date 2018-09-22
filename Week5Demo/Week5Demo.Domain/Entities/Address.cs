﻿using System;

namespace Week5Demo.Domain.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
    }
}
