using System;
using System.Collections.Generic;
using qwe.Classes;
using qwe.Enums;

namespace qwe
{
    class Program
    {
        static void Main(string[] args)
        {
            //// create new customer
            var customer = new Person("Era","Azana",new Address("212 Baker St.","London","United Kingdom",16));
            //// create a new policy with effective date
            var policy   = new Policy(DateTime.Today,DateTime.Today.AddYears(1));

            //// create 2 new Cars and add each coverage
            var car1 = new Vehicle(2016,
                                    "Honda",
                                    "Accord",
                                    10000,
                                    Color.BLUE,
                    new List<Coverage>(){
                        new Coverage(CoverageType.BOD),
                        new Coverage(CoverageType.LIA),
                    }); //75 x 2



            var car2 = new Vehicle(2015,"Nissan","Almera",25000,Color.RED,
                                new List<Coverage>(){
                                    new Coverage(CoverageType.BOD),
                                    new Coverage(CoverageType.LIA)}); //75
            var car3 = new Vehicle(2016,"Mitsubishi","Montero",12500,Color.RED,new List<Coverage>(){
                new Coverage(CoverageType.COMP),
                new Coverage(CoverageType.LIA)}); //75


        //// Add to the insured Vehicles
        policy.Vehicles.Add(car1);
        policy.Vehicles.Add(car2);
        policy.Vehicles.Add(car3);

        //// create 2 new drivers
        var driver1 = new Person("John","Watson",new Address("212 Baker St.","London","United Kingdom",16));
        var driver2 = new Person("Sherlock","Holmes",new Address("212 Baker St.","London","United Kingdom",16));

        //// create spouse instance for insured driver
        var wifey = new Person("Jane","Abbington",new Address("212 Baker St.","London","United Kingdom",16));

        //// add the policyholder, spouse and drivers to the insured driver
        policy.Drivers.Add(customer);
        policy.Drivers.Add(wifey);
        policy.Drivers.Add(wifey);
        // policy.Drivers.Add(driver1);
        // policy.Drivers.Add(driver2);

        var priceEngine = new PricingEngine().pricePolicy(policy);
        Console.WriteLine(policy);
        Console.WriteLine(priceEngine);
        }
    }
}
