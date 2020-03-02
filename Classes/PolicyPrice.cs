using System;
using System.Collections.Generic;
using qwe.Enums;
using qwe.Interfaces;

namespace qwe.Classes
{
    public class PolicyPrice : IPolicyPriceQuote
    {
        double _totalamount;
        double _downPayment;
        string _policyNbr;
        Dictionary<CoverageType, Double> _priceBreakDown;
        /*Initialize Policy Price attributes */
        public PolicyPrice(double amount,String policynbr, Dictionary<CoverageType, Double> priceBreakdown)
        {

        }

        /**
        * This interface represents a PolicyPriceQuote as priced by an IPricingEngine implementation
        * The downPayment property should contain a value that is 25% of the TotalPrice property
        * An instance of the IPolicyPriceQuote implementation class will be returned by the PricingEngine
        * when the PricingEngine's pricePolicy method is called.
        */

        /* Implement a PolicyPrice ToString() */
    }
}