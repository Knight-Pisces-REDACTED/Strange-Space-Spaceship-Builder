using System;
using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting.APIUpdating;
using static Constants.BuilderConstants;

public class Ship
{
    public int hullWeight;
    public int maxWeight;
    public int totalWeight;
    public int shipHeight;
    public int hullLength;
    public int hullWidth;
    public int lWRatio;
    public string hullShape;
    public int wingLength;
    public int wingWidth;
    public int wingHeight;
    public int wingCount;
    public string wingShape;
    public int thrusterCount;
    public int decks;
    public Ship(int weight = 25000, int h = 28, double ratio = (1/5), int wNum = 0){
        maxWeight = weight;
        shipHeight = h;
        decks = shipHeight/4;
        SizeCalc(maxWeight, hullShape, shipHeight, wingCount, wingShape);
    }
    private void SizeCalc(int weight, string shape, int height, int wingNum, string wingShape, int ratio = 0){
        
        if (shape == "Circle"){
            
        } else if (shape == "Rectangle"){
            if (ratio!=0){
                double vol = weight * SPACESHIP_TONS_PER_CUBIC_METER;
            }
            else{
                Console.WriteLine("You need to add a length-width ratio.");//replace with proper error window later
            }
        } else {
            Console.WriteLine("Something got into the SizeCalc function, go debug.");
        }
    }
    public void Move(){
        
    }
}

