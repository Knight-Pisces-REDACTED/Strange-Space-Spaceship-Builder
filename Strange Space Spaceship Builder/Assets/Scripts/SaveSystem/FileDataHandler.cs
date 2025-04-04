//Grabbed this from Shaped by Rain Studios, but slightly adapted it.
using UnityEngine;
using System;
using System.IO;
using Mono.Cecil;
public class FileDataHandler{
    private string directoryName = "";
    private string dataName = "";
    public void saveShip(Ship tbs){
        string fullPath = Path.Combine(directoryName, dataName);
        try{
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            string ShipToStore = JsonUtility.ToJson(tbs, true);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create)){
                using (StreamWriter writer = new StreamWriter(stream)){
                    writer.Write(ShipToStore);
                }
            }
        }
        catch (Exception e) {
            Debug.LogError("Error saving ship to" + fullPath + "\n" + e);
        }
    }
    public Ship LoadShip(){
        string fullPath = Path.Combine(directoryName, dataName);
        Ship loadedShip = null;
        if (File.Exists(fullPath)){
            string toLoad = "";
            try{
              using (FileStream stream = new FileStream(fullPath, FileMode.Open)){
                using (StreamReader reader = new StreamReader(stream)){
                    reader.ReadToEnd();
                }
            }
            loadedShip = JsonUtility.FromJson<Ship>(toLoad);  
            } catch (Exception e) {
                Debug.LogError("Something went wrong when reading the file.\n" + e);
            }
        }
        return loadedShip;
    }
}