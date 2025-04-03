using UnityEngine;

[System.Serializable]
public class Ship{
    public double HP;
    public Faction faction;
    public ShipHull hull;
    public ShipWings myWings;
    public Ship(Faction myFact, ShipHull myHull, ShipWings myWings = null){
        
    }
}