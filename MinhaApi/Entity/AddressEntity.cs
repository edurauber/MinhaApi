﻿namespace MinhaApi.Entity
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int Number { get; set; }
        public string? Address2 { get; set; }
        public int District_Id { get; set; }

    }
}
