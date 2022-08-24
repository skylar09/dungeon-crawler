using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public List<GameObject> itemPositions = new List<GameObject>();

    public GameObject ui_Window;

    public static bool newItem = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            if (ui_Window.activeInHierarchy == true)
            {
                ui_Window.SetActive(false);
            }

            else
            {
                ui_Window.SetActive(true);
            }
            
        }

        if (newItem == true)
        {
            display();
        }
    }

    public void display()
    {
        itemPositions[items.Count - 1].GetComponent<SpriteRenderer>().sprite = items[items.Count - 1].GetComponent<SpriteRenderer>().sprite;
    }
}
