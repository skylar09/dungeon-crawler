using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    //each inventory slot in order of left to right then top down
    public List<Image> InventorySlots = new List<Image>();
    //numbers that correspond to a specific weapon based on where they are in the items list
    //this is used for telling which weapon is in which inventory slot
    public static List<int> itemNums = new List<int>();

    //the inventory
    public GameObject inventory;

    public static bool newItem = false;
    public static int totalItems = 0;

    public static int inventoryLocation;

    // Start is called before the first frame update
    void Start()
    {
        //just make sure inventoryParent is first gameObject
        //inventory.transform.GetChild(0).gameObject.GetComponent<makeInventorySlots>().makeSlots(player);

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
            if (inventory.activeInHierarchy == true)
            {
                inventory.SetActive(false);
                this.GetComponent<pauseGame>().unpause();
            }

            else
            {
                inventory.SetActive(true);
                this.GetComponent<pauseGame>().pause();
            }
            
        }
    }

    //adds an item to the next free inventory slot
    public void addItem(GameObject item, int replaceItem)
    {
        InventorySlots[totalItems].GetComponent<Image>().enabled = true;
        //changes the sprite of an inventory slot to an item at a certain spot in the items list
        InventorySlots[totalItems].sprite = item.GetComponent<SpriteRenderer>().sprite;
        
        //changes the color of the inventory slot bc there are some items that are just color changed
        InventorySlots[totalItems].color = item.GetComponent<SpriteRenderer>().color;

        //adds the number of that item in the items list to the itemNums list
        itemNums.Add(replaceItem);
        
        totalItems ++;
        newItem = false;
    }

    //changes the sprite at a certain slot to the sprite of the current weapon
    public int changeCurrent(int num, GameObject item)
    {
        InventorySlots[inventoryLocation].sprite = item.GetComponent<SpriteRenderer>().sprite;
        int toReturn = itemNums[inventoryLocation];
        itemNums[inventoryLocation] = num;

        //changes the color of the inventory slot bc there are some items that are just color changed
        InventorySlots[inventoryLocation].color = item.GetComponent<SpriteRenderer>().color;
        
        Weapons.canAttack = true;
        Weapons.swordSwung = false;

        return toReturn;
    }
}
