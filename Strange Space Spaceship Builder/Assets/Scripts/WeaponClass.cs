using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;
using Vector3 = UnityEngine.Vector3;

public class WeaponClass {

    public string name;
    public Techs reqTech;
    public WeaponSupertypes type;
    public double damage;
    public double range;
    public double accuracy;
    public double weight;
    public double cost;
    public double falloffP;
    public double falloffR;
    /// <summary>
    /// This is the basic weapon class. It does stuff. FalloffRate is how many hundred meters are in a range bracket.
    /// </summary>
    /// <param name="weaponName"></param>
    /// <param name="baseType"></param>
    /// <param name="weaponDamage"></param>
    /// <param name="weaponRange"></param>
    /// <param name="baseAccuracy"></param>
    /// <param name="baseWeight"></param>
    /// <param name="baseCost"></param>
    /// <param name="tech"></param>
    /// <param name="falloffRate"></param>
    /// <param name="falloffPercent"></param>
    public WeaponClass(string weaponName, WeaponSupertypes baseType, double weaponDamage, double weaponRange, double baseAccuracy, double baseWeight, double baseCost, Techs tech, double falloffRate, double falloffPercent){
        name = weaponName;
        reqTech = tech;
        type = baseType; 
        weight = baseWeight;
        cost = baseCost;
        accuracy = baseAccuracy;
        range = weaponRange;
        damage = weaponDamage;
        falloffR = falloffRate;
        falloffP = falloffPercent;
    }
    public double calcAccuracy(double r, double targDist, double targSpeed){
        Random check = new Random();
        double accInst = check.Next(1, 100);
        double accAdj = accInst + (r - targDist) - Math.Abs(targSpeed);
        return accAdj;
    }
    public double calcDamage(double dam, double rate, double dist, double perc){
        double adjRate = rate * 100;
        double count = dist/adjRate;
        double uDam = dam * perc;
        double adjDamage = dam - (uDam * count);
        return adjDamage;
    }
    public void Shoot(ShipInst target){
        if (type == WeaponSupertypes.Direct) {
            Vector3 wep = Vector3.zero;
            Vector3 targ = Vector3.right;
            double dist = (wep-targ).magnitude;
        if (dist > range){
            double hitCheck = calcAccuracy(range, dist, target.speed);
            if (hitCheck >= accuracy){
                target.hitPoints -= calcDamage(damage, falloffR, dist, falloffP);
                }
            }
        }
    }

}