using System;
using System.Collections.Generic;

namespace qwe.Classes
{
    public class Vehicle
    {
        private string _vin;
        private int _year;
        private string _make;
        private string _model;
        private Double _price;
        private Color _color;
        private List<Coverage> _coverages;

        public string VIN { get => _vin;}
        public List<Coverage> Coverages { get => _coverages; set => _coverages = value; }
        public int Year { get => _year; set => _year = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public double Price { get => _price; set => _price = value; }
        public Color Color { get => _color; set => _color = value; }

        /** Initialize Vehicle attributes and call the generateVIN() */
        public Vehicle(int year, string make, string model, Double price, Color color , List<Coverage> coverages)
        {

        }

        public Vehicle(){}


        /**
        * Implementation of this method will add a coverage to the specified vehicle and maps the Parent Policy and Covered Car. This method should throw an error if the coverage in the vehicle already exist.
        * @param aDate : Coverage to be added on the Vehicle's Coverages.
        * @param pol : Reference key to Policy.
        */
        public void AddCoverage(Coverage cov, Policy pol){
        }
        /**
        * Implementation of this method will add multiple coverages to the specified vehicle and maps the Parent Policy. This method should throw an error if the coverage in the vehicle already exist.
        * @param covs : List of Coverages to be added on the Vehicle's Coverages.
        * @param pol : Reference key to Policy.
        */
        public void AddCoverages(List<Coverage> covs,Policy pol){

        }

        //Print a VIN. Ex. VIN-Toyota-2015
        private void generateVIN(){
            
        }

        // Implement Vehicle ToString()
    }
}