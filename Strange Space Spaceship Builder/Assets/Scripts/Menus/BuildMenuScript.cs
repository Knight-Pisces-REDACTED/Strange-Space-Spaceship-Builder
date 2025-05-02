using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BuildMenuScript : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown fact;
    public Sprite[] sprites = new Sprite[3];
    public Sprite facSprite;
    public void Awake()
    {
    }
    public void Start()
    {
        facSprite = sprites[0];
    }
    public void Update()
    {
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
            facSprite = TransformImage(0);
        } else if (val == 1){
            Globals.currentFaction = "Daicosreyn";
            facSprite = TransformImage(1);
        }
        else if (val == 2){
            Globals.currentFaction = "Rehman Empire";
            facSprite = TransformImage(2);
        }
    }
    public Sprite TransformImage(int v){
        Debug.Log("Updating image");
        return sprites[v];
    }
    public Sprite GetFacSprite(){
        return facSprite;
    }
}
