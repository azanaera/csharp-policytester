using System;
using System.Collections.Generic;
using qwe.Enums;

namespace qwe.Interfaces
{
    public interface IPolicyPriceQuote
    {
        /**
        * This interface represents a PolicyPriceQuote as priced by an IPricingEngine implementation
        * The downPayment property should contain a value that is 25% of the TotalPrice property
        * An instance of the IPolicyPriceQuote implementation class will be returned by the PricingEngine
        * when the PricingEngine's pricePolicy method is called.
        */
        string PolicyNumber();
        double DownPayment();
        double TotalPrice();
        Dictionary<CoverageType, Double> PriceBreakDown();
         
    }
}