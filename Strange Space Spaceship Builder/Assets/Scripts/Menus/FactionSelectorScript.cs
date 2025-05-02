using UnityEngine;
using TMPro;
public class FactionSelectorScript : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropdown.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int FactionSelector(){
        int val = dropdown.value;
        return val;
    }
}
