﻿using System;

namespace TaxiStation.Core.MetaData
{
    public class MetaInfo
    {
        public MetaInfo(Manufacturer manufacturer, Model model, DateTime creatingDate, Specification specification,
            decimal price)
        {
            Manufacturer = manufacturer;
            Model = model;
            CreatingDate = creatingDate;
            Specification = specification;
            Price = price;
        }

        public Manufacturer Manufacturer { get; private set; }
        public Model Model { get; private set; }
        public DateTime CreatingDate { get; private set; }
        public Specification Specification { get; private set; }
        public decimal Price { get; private set; }
    }
}