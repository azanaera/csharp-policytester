using System;
using System.Collections.Generic;
using qwe.Enums;
using qwe.Interfaces;

namespace qwe.Classes
{
    public class Policy : AbstractPolicy
    {  
        private Person _primaryInsuredPerson;
        private List<Vehicle> _vehicles;
        private List<Person> _drivers;
        private DateTime _effectivedate = DateTime.Now; // for modification
        private DateTime _expirationdate = new DateTime();

        public override DateTime EffectiveDate { 
            get => this._effectivedate; 
            set => _effectivedate = value; 
        }
        public override DateTime ExpirationDate { 
            get => this._expirationdate;
            set => _expirationdate = value; 
            }

        public override List<Vehicle> Vehicles { get => _vehicles; }

        public override List<Person> Drivers { get => _drivers; }
        public Person PrimaryInsuredPerson { get => _primaryInsuredPerson; set => _primaryInsuredPerson = value; }

        private Policy(){}
        /*Initialize policy and call the assignPolicyNumber here*/
        public Policy(DateTime effectDate, DateTime expireDate)
        {
            
        }


        /* Implement a Policy ToString() */
    }
}