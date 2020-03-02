using System;
using System.Collections.Generic;
using qwe.Classes;
using qwe.Enums;

namespace qwe
{
    class Program1
    {
        static void asd(string[] args)
        {
            var car1 = new Vehicle(2012,"Honda", "Accord", 10000, Color.BLUE,
                new List<Coverage>(){
                new Coverage(CoverageType.BOD),
                new Coverage(CoverageType.LIA)});
            var car2 = new Vehicle(2014,"Honda", "Civic", 25000, Color.RED, new List<Coverage>(){
                new Coverage(CoverageType.COMP),
                new Coverage(CoverageType.LIA)});
            var car3 = new Vehicle(2011,"Toyota", "Camry", 25000, Color.RED, new List<Coverage>(){
                new Coverage(CoverageType.COMP),
                new Coverage(CoverageType.LIA)});
            var dt = DateTime.Now;
            var policy = new Policy(dt.AddMonths(-4), dt.AddMonths(8));

            policy.Vehicles.Add(car1);//note: only added car1 and car2
            policy.Vehicles.Add(car2);
            //...add drivers as well

            policy.AddCoverage(new Coverage(CoverageType.BOD), car1);
            //policy.addCoverage(new Coverage(CoverageType.Liability), car1)
            policy.AddCoverage(new Coverage(CoverageType.LIA), car2);

            // //This must throw an exception because the same coverage is being added to the same car twice
            // policy.AddCoverage(new Coverage(CoverageType.BOD), car1); // *ok

            car1.AddCoverages(new List<Coverage>(){new Coverage(CoverageType.LIA),new Coverage(CoverageType.COMP)},policy);
            ////This must throw an exception because the coverage is being added to a car that is not on the Policy
            // policy.AddCoverage(new Coverage(CoverageType.LIA), car3); // should throw exception *ok
            // //
            var covs = policy.getCarCoverages(car1); //should return coverages for car1 only *ok
            var count = policy.getCoveredCarCount(CoverageType.BOD); //This should return 2 - i.e 2 cars on the policy have the coverage type *ok

            covs.ForEach((cov) =>
                Console.WriteLine(cov.InsuranceCoverageType.ToString().PadRight(20).Replace('\0',' ')+"   "+cov.CoveredCar)
            );

            
            var priceEngine = new PricingEngine().pricePolicy(policy);
            Console.WriteLine(policy);
            Console.WriteLine(priceEngine);
        }
    }
}