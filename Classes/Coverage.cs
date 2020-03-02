using System;
using System.Collections.Generic;
using qwe.Enums;
using qwe.Interfaces;

namespace qwe.Classes
{
    public class Coverage
    {
        /**
        * Created by Wayne Iluyomade on 2/14/2016.
        * Insurance coverage is issued by an insurer in the event of an unforeseen or unwanted occurrences.
        * There are general different types of insurance coverages. For an Auto Insurance Policy, examples include:
        * Bodily Injury Coverage: the insurer pays for any hospital bills for injured driver and passengers
        * Liability Coverage: the insurer pays for any damages to another person's property during in an accident
        * Comprehensive Coverage: the insurer pays for the insured's own car damage in event of an accident
        *
        * This implementation of a Coverage also specifies the annual base rate for each coverage
        */

        private CoverageType _covType;
        private AbstractPolicy _policy; //The policy on which coverage exists
        private Vehicle _vehicle;   //the vehicle that is covered by this coverage
        private Dictionary<CoverageType, Double>  _baseRates = new Dictionary<CoverageType, Double>()
        {
            {CoverageType.BOD, 75.00},
            {CoverageType.LIA, 85.00},
            {CoverageType.COMP, 105.00}
        };
        //construct(){} //No default constructor. We must only contruct coverages of the correct type
        public Coverage(CoverageType covType){
            _covType = covType;
        }

        public Vehicle CoveredCar { get => _vehicle; set => _vehicle = value; }
        public AbstractPolicy ParentPolicy { get => _policy; set => _policy = value; }
        public CoverageType InsuranceCoverageType { get => _covType; set => _covType = value; }

        public Double getBaseRate(){
            return _baseRates[InsuranceCoverageType];
        }
    
    }
}