﻿using System;
using System.Collections.Generic;

namespace BuyandRentHomeWebAPI.Models
{
    public partial class Property
    {
        public Property()
        {
            Photos = new HashSet<Photo>();
        }

        public int Id { get; set; }
        public int SellRent { get; set; }
        public string Name { get; set; }
        public int PropertyTypeId { get; set; }
        public int FurnishingTypeId { get; set; }
        public int Bedroom { get; set; }
        public int? Bathroom { get; set; }
        public int? CommonSpace { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public string StreetAddress { get; set; }
        public int TotalFloor { get; set; }
        public int Floor { get; set; }
        public string Landmark { get; set; }
        public int Area { get; set; }
        public int RentPrice { get; set; }
        public int? OtherCost { get; set; }
        public bool Gym { get; set; }
        public bool Parking { get; set; }
        public bool SwimmingPool { get; set; }
        public string Description { get; set; }
        public DateTime PostedOn { get; set; }
        public int PostedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public int LastUpdatedBy { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual FurnishingType FurnishingType { get; set; }
        public virtual User PostedByNavigation { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
