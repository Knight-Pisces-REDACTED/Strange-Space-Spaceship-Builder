using System;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting.APIUpdating;
using static Constants.BuilderConstants;

public class ShipHull
{
    public int hullWeight;
    public int hullMaxWeight;
    public int hullHeight;
    public int hullLength;
    public int hullWidth;
    public int lWRatio;
    public string hullShape;
    public int decks;
    public ShipHull(int weight = 25000, int h = 28, double ratio = 1/5){
        hullMaxWeight = weight;
        hullHeight = h;
        decks = hullHeight/4;
        SizeCalc(hullMaxWeight, hullShape, hullHeight);
    }
    //Base hull weight is the base hull only. Adding wings just adds more slots and opens more mounting points for thrusters.
    private void SizeCalc(int weight, string shape, int height, int ratio = 0){
        double vol = weight * SPACESHIP_TONS_PER_CUBIC_METER;
        double flat = vol / height;
        if (shape == "Circle"){

        } else if (shape == "Rectangle"){
            if (ratio!=0){
            }
            else{
                Console.WriteLine("You need to add a length-width ratio.");//replace with proper error window later
            }
        } else {
            Console.WriteLine("Something got into the SizeCalc function, go debug.");
        }
    }
}

