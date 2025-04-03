using UnityEngine;
using System.Linq;
public class SaveSystemManager : MonoBehaviour{
    public static SaveSystemManager Instance{ get; private set; }
    private void Awake()
    {
        if (Instance != null){
            Debug.LogError("Save system happened twice somehow.");
        }
        Instance = this;
        
        
    } 
}