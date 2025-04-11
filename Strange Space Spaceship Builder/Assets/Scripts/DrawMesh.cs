using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DrawMesh
{
    Mesh mesh;
    public Vector3[] polygonPoints;
    public int[] polygonTriangles;

    public void DrawFilled(int sides, float radius){
        polygonPoints = GetCircumferencePoints(sides, radius).ToArray();
        polygonTriangles = DrawFilledTriangles(polygonPoints);
        mesh.Clear();
        mesh.vertices = polygonPoints;
        mesh.triangles = polygonTriangles;

    }
    public void DrawHollow(int sides, float outerRadius, float innerRadius){
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> outerPoints = GetCircumferencePoints(sides, outerRadius);
        pointList.AddRange(outerPoints);
        List<Vector3> innerPoints = GetCircumferencePoints(sides, innerRadius);
        polygonPoints = pointList.ToArray();
        polygonTriangles = DrawHollowTriangles(polygonPoints);
        mesh.Clear();
        mesh.vertices = polygonPoints;
        mesh.triangles = polygonTriangles;


    }
    public int[] DrawHollowTriangles(Vector3[] points){
        int sides = points.Length/2;
        int triAm = sides*2;
        List<int> newTriangles = new List<int>();
        for (int i =0; i<sides;i++){
            int outerIndex = i;
            int innerIndex = i+sides;
            newTriangles.Add(outerIndex);
            newTriangles.Add(innerIndex);
            newTriangles.Add((i+1)%sides);
            newTriangles.Add(outerIndex);
            newTriangles.Add(sides+((sides+1)%sides));

        }
        return newTriangles.ToArray();
    }
    public List<Vector3> GetCircumferencePoints(int sides, float radius){
        List<Vector3> points = new List<Vector3>();
        float circumPPS = (float)1/sides;
        float TAU = 2*Mathf.PI;
        float radianPPS = circumPPS * TAU;
        for (int i =0; i<sides;i++){
            float currRadian = radianPPS * i;
            points.Add(new Vector3(MathF.Cos(currRadian)* radius, MathF.Sin(currRadian)*radius));
        }   
        return points;
    }
    public int[] DrawFilledTriangles(Vector3[] points){
        int triAm = points.Length - 2;
        List<int> newTriangles = new List<int>();
        for (int i =0; i<triAm;i++){
            newTriangles.Add(0);
            newTriangles.Add(i+2);
            newTriangles.Add(i+1);
        }
        return newTriangles.ToArray();
    }
}
