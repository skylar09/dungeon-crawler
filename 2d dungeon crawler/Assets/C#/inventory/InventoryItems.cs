using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public List<Image> InventorySlots = new List<Image>();
    public static List<int> itemNums = new List<int>();

    public GameObject ui_Window;

    public static bool newItem = false;
    public int totalItems = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < InventorySlots.Count; i ++)
        {
            InventorySlots[i].GetComponent<InventoryButtons>().locationNum = i;
        }
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
            addItem();
        }
    }

    public void addItem()
    {
        InventorySlots[totalItems].sprite = items[dropItem.createdItemsNumber[pickUpItem.closestItem]].GetComponent<SpriteRenderer>().sprite;
        itemNums.Add(dropItem.createdItemsNumber[pickUpItem.closestItem]);

        dropItem.createdItemsNumber.RemoveAt(pickUpItem.closestItem);

        totalItems ++;
        newItem = false;
        pickUpItem.buttonPressed = false;
    }

    public void changeCurrent(int inventoryLocation, int replaceItem)
    {
        InventorySlots[inventoryLocation].sprite = items[replaceItem].GetComponent<SpriteRenderer>().sprite;
        itemNums[inventoryLocation] = replaceItem;
    }
}
