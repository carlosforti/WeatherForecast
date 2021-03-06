﻿using System;

namespace WeatherForecast.Core.Entities
{
    public class Location
    {
        public Location(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Location(int id, string name, string geolocation, string type)
            : this(id, name)
        {
            Type = type;

            var latitudeAndLongitude = geolocation.Split(',');

            if(latitudeAndLongitude.Length != 2)
            {
                throw new FormatException("Geolocation should have the format: '[latitude],[longitude]'");
            }

            Latitude = float.Parse(latitudeAndLongitude[0]);
            Longitude = float.Parse(latitudeAndLongitude[1]);
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public float? Latitude { get; private set; }
        public float? Longitude { get; private set; }
        public string Type { get; set; }
    }
}