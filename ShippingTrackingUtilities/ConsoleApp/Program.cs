﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingTrackingUtilities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionString.SetupFedExCredential("YourFedexUserKey", "YourFedexPassword");
            ConnectionString.SetupUSPSCredential("YourUSPSUserID");
            ConnectionString.SetupUPSCredential("YourUPSLicenseNo");

            TrackingUtilities utilities = new TrackingUtilities();

            try
            {
                utilities.GetTrackingResult("010425715172328");
                var result = utilities.ShippingResult;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}