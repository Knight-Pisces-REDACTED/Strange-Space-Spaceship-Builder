using System;
using UnityEngine;

[System.Serializable]
public class Ship{
    public string shipClassName;
    public double HP;
    public string faction;
    public ShipHull hull;
    public Ship(String name, string myFact){
        
    }
}