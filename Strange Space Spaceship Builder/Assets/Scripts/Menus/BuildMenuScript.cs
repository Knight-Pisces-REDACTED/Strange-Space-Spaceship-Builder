using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BuildMenuScript : MonoBehaviour
{
    public TMP_Dropdown fact;
    public Sprite[] sprites = new Sprite[3];
    public void Awake()
    {
        //fact = GameObject.Find("FactionSelector").GetComponent<Dropdown>();
    }
    public void NewShip(){
        Globals.currentShip = new Ship("New Ship", Globals.currentFaction);
    }
    public void LoadShips(){
        Debug.Log("Load button clicked");
    }
    public void EnterBuilder(){
        Debug.Log("Enter builder clicked");
        SceneManager.LoadScene("BuilderScene");
    }
    public void FactionSelector(TMP_Dropdown dropdown){
        int val = dropdown.value;
        if(val == 0){
            Globals.currentFaction = null;
            Debug.Log("Null");
        } else if (val == 1){
            Globals.currentFaction = "Daicosreyn";
            Debug.Log("Daicosreyn");
        }
        else if (val == 2){
            Globals.currentFaction = "Rehman Empire";
        }
        Debug.Log(val);
    }
    public Sprite TransformImage(){
        if (Globals.currentFaction == "Daicosreyn"){
            return sprites[1];
        }
        else if (Globals.currentFaction == "Rehman Empire"){
            return sprites[2];
        }
        else{
            return sprites[0];
        }
    }
}
