using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ShipFrames{
    public class Frame{
        public string frameName;
        public string frameShape;
        public Vector3[] mounts;
    }
    public static Dictionary<string, Frame> frames =  new Dictionary<string, Frame>(){
        {"Triangle Frigate", new Frame{
            frameName = "Triangle Frigate", 
            frameShape = "Wedge", 
            mounts = new Vector3[]{
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0),
                new Vector3(0, 0, 0)
            }
            }
        },
        {"Template", new Frame{
            frameName= "E", 
            frameShape = "E", 
            mounts = new Vector3[]{
                new Vector3(0, 0 ,0)
            }
            }
        }
    };
    public static Frame GetFrame(string name){
        return frames[name];
    }

}