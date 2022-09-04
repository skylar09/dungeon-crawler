using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    //all the possible items that you can have in the inventory
    public List<GameObject> items = new List<GameObject>();
    //each inventory slot in order of left to right then top down
    public List<Image> InventorySlots = new List<Image>();
    //numbers that correspond to a specific weapon based on where they are in the items list
    //this is used for telling which weapon is in which inventory slot
    public static List<int> itemNums = new List<int>();

    //the inventory
    public GameObject ui_Window;

    public static bool newItem = false;
    public int totalItems = 0;

    public static int inventoryLocation, replaceItem;
    public static bool changeUIWeapon = false;

    // Start is called before the first frame update
    void Start()
    {
        //assigns a number to each inventory slot in order of left to right the top down
        for (int i = 0; i < InventorySlots.Count; i ++)
        {
            InventorySlots[i].GetComponent<InventoryButtons>().locationNum = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //turns on and off the inventory
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

        if (changeUIWeapon == true)
        {
            changeCurrent();
        }
    }

    //adds an item to the next free inventory slot
    public void addItem()
    {
        InventorySlots[totalItems].GetComponent<Image>().enabled = true;
        //changes the sprite of an inventory slot to an item at a certain spot in the items list
        InventorySlots[totalItems].sprite = items[dropItem.createdItemsNumber[pickUpItem.closestItem]].GetComponent<SpriteRenderer>().sprite;
        
        //changes the color of the inventory slot bc there are some items that are just color changed
        InventorySlots[totalItems].color = items[dropItem.createdItemsNumber[pickUpItem.closestItem]].GetComponent<SpriteRenderer>().color;

        //adds the number of that item in the items list to the itemNums list
        itemNums.Add(dropItem.createdItemsNumber[pickUpItem.closestItem]);

        //needed so that the adding items doesn't get messed up
        dropItem.createdItemsNumber.RemoveAt(pickUpItem.closestItem);

        totalItems ++;
        newItem = false;
        pickUpItem.buttonPressed = false;
    }

    //changes the sprite at a certain slot to the sprite of the current weapon
    public void changeCurrent()
    {
        InventorySlots[inventoryLocation].sprite = items[replaceItem].GetComponent<SpriteRenderer>().sprite;
        itemNums[inventoryLocation] = replaceItem;

        //changes the color of the inventory slot bc there are some items that are just color changed
        InventorySlots[inventoryLocation].color = items[replaceItem].GetComponent<SpriteRenderer>().color;
    }
}
