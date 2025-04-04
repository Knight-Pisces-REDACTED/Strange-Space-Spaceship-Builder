using System;
using UnityEngine;

[System.Serializable]
public class Ship{
    public string shipClassName;
    public double HP;
    public Faction faction;
    public ShipHull hull;
    public ShipWings myWings;
    public Ship(String name, Faction myFact){
        
    }
}