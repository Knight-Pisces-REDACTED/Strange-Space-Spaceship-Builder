using UnityEngine;
using System.Collections.Generic;
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class PlaneGenerator : MonoBehaviour
{
    Mesh floorMesh;
    MeshFilter floorFilter;
    [SerializeField] Vector2 planeSize = new Vector2(1, 1);
    [SerializeField] int planeResolution = 1;
    List<Vector3> verticies;

    void Awake()
    {
        floorMesh = new Mesh();
        floorFilter = GetComponent<MeshFilter>();
        floorFilter.mesh = floorMesh;
    }

    // Update is called once per frame
    void Update()
    {
        planeResolution = Mathf.Clamp(planeResolution, 1, 50);
        GeneratePlane(planeSize, planeResolution);
        
    }
    void GeneratePlane(Vector2 size, int resolution){

    }
    void AssignMesh(){

    }
    void LeftToWriteSine(){

    }
    void RippleSine(){

    }
}
