﻿namespace CarRentalManagement.Client.Static
{
        public static class Endpoints
        {
            private static readonly String Prefix = "api";

            public static readonly string MakesEndpoint = $"{Prefix}/makes";
            public static readonly string ModelsEndpoint = $"{Prefix}/models";
            public static readonly string ColoursEndpoint = $"{Prefix}/colours";
            public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
            public static readonly string CustomersEndpoint = $"{Prefix}/customers";
            public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";
    }
}