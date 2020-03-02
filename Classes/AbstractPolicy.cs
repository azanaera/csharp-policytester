
using qwe.Enums;
using qwe.Classes;
using System;
using System.Collections.Generic;

namespace qwe.Classes
{
    /**
 * Created by Wayne Iluyomade on 2/15/2016.
 * Base class for Policy. Specifies base methods for Policy instances
 * All implementations of this class must utilize the provided assignPolicyNumber to acquire a unique policy number
 * for each instance.
 * Each policy has an Effective Date which is the date the insurance coverage becomes effective and an Expiration Date
 * which is the date when coverage ends.
 */
  public abstract class AbstractPolicy {
  const int POLICY_NUMBER_LENGTH = 8;
  private static int _initial = 200; //used as starting point for PolicyNumbers
  protected string _policyNbr ;

    public string PolicyNumber {
        get { return _policyNbr; }
    }
  public abstract DateTime EffectiveDate {get;set;} 
  public abstract DateTime ExpirationDate {get;set;} 
  public abstract List<Vehicle> Vehicles {get;} 
  public abstract List<Person> Drivers {get;} 

  protected string assignNextPolicyNumber() {
    /**
      this should return a string containing a Policy Number with the correct length. ex. 00000200, 00000201
      this should also increment for the next time.
      *clue - use padleft and replace methods **search nyo sa google 
    **/
    return "";
  }
  
    /**
   * The implementation of this method should add the specified coverage to the Policy and associate the coverage with
   * the specified Car. The Car must already exist on the Policy -  this method must throw an exception
   * indicating that the specified car does not exist on the Policy
   *
   * @param cov - coverage to be added to the policy
   * @param veh - vehicle to be covered by the specified coverage
   * @throws Exception if the specified car is not already on the Policy or if the specified car already has the coverage added.
   */
   public abstract void AddCoverage(Coverage cov, Vehicle veh);

  /**
   * The implementation of this method should return the coverages that are associated with the specified vehicle
   * @param veh
   * @return
   */
  public abstract List<Coverage> getCarCoverages(Vehicle veh);

  /**
   * Implementation of this method will return true if this policy is in force.
   * A Policy is in force on the specified date if the date falls on or between the effective date and the expiration date.
   * @param aDate : the date being checked.
   * @return
   */
  public abstract bool isPolicyInForce(DateTime aDate);

  /**
   * The Implementation of this method must return the number of cars that have coverages of the specified type on this Policy
   * @param coverageType
   * @return
   */
  public abstract int getCoveredCarCount(CoverageType coverageType);
   
  }
}