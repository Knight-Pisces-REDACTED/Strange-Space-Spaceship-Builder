using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Internal;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting.APIUpdating;
using static Constants.BuilderConstants;
using static ShipFrames;

public class ShipHull : MonoBehaviour
{
    public double hullWeight;
    public double hullMaxWeight;
    public double hullHeight;
    public double hullLength;
    public double hullWidth;
    public double hullRatio;
    public string hullShape;
    public double decks;
    string currentFrame;
    private List<GameObject> existingMounts;
    public GameObject prefab;
    public ShipHull(string hullShape, double weight = 25000, double h = 28){
        hullMaxWeight = weight;
        hullHeight = h;
        decks = hullHeight/4;
        switch(hullShape){
            case "Saucer":
                SaucerHull();
                break;
            case "Brick":
                PolygonalHull(hullShape, hullRatio);
                break;
            case "Diamond":
                PolygonalHull(hullShape, hullRatio);
                break;
            case "Wedge":
                PolygonalHull(hullShape, hullRatio);
                break;
            case null:
            Debug.LogError("The hull shape disappeared, setting to Brick.");
            hullShape = "Brick";
            break;
        }

    }
    //Base hull weight is the base hull only. Adding wings just adds more slots and opens more mounting points for thrusters.
    private double FlatCalc(double weight, double height){
        double vol = weight * SPACESHIP_TONS_PER_CUBIC_METER;
        double flat = vol / height;
        return flat;
    }
    private void SaucerHull(){
        double flat = FlatCalc(hullMaxWeight, hullHeight);
        double r = math.sqrt(flat/math.PI);
        double midship = hullHeight/2;
        
        //Use diameter for steps
    }
    private void PolygonalHull(string shape, double ratio){
        if (ratio!=0){
            if (shape == "Brick"){
                double flat = FlatCalc(hullMaxWeight, hullHeight);
                hullLength = math.sqrt((flat*flat)*ratio);
                hullWidth = hullLength/ratio;
            }
            else if (shape == "Wedge"){
                double flat = FlatCalc(hullMaxWeight, hullHeight) * 2;
                hullLength = math.sqrt((flat*flat)*ratio);
                hullWidth = hullLength/ratio;
            }
            else if (shape == "Diamond"){
                double flat = FlatCalc(hullMaxWeight, hullHeight) * 2;
                hullLength = math.sqrt((flat*flat)*ratio);
                hullWidth = hullLength/ratio;
            }
        } else {
            Debug.LogError("You need to add a length-width ratio.");//replace with proper error window later
        }
    }
    public void LoadFrame(string frameName){
        Frame myFrame = ShipFrames.GetFrame(frameName);
        for (int i = 0; i < existingMounts.Count; i++){
            Destroy(existingMounts[i]);
        }
        existingMounts.Clear();
        for(int i = 0; i < myFrame.mounts.Length; i++){
            Instantiate(prefab, myFrame.mounts[i], quaternion.identity);
        }
    }
}

