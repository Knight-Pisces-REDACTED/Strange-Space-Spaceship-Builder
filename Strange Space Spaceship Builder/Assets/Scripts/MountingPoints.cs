using UnityEngine;

public class MountingPoints : MonoBehaviour
{
    GameObject bl;
    int currPart = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bl = GameObject.Find("BuildLogicer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    { 
        if (Input.GetMouseButtonDown(0)){
            currPart = bl.GetComponent<BuildLogic>().getCurrentPart();
            Debug.Log("PLACE");
        } else if (Input.GetMouseButtonDown(1)){
            currPart = 0;
            Debug.Log("CLEAR");
        }
        GetComponent<SpriteRenderer>().sprite = bl.GetComponent<BuildLogic>().getSpriteFromPart(currPart);
    }
    
}
