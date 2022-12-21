using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropper : MonoBehaviour{
    //droppable items
    [SerializeField]
    private List<GameObject> items = new List<GameObject>();
    //game object that gets instantiated when weapon is dropped
    [SerializeField]
    private GameObject placeHolder;

    //list of all the weapons that have been dropped this level
    private List<GameObject> droppedItems = new List<GameObject>();

    public static Weapons Weapons;

    private bool buttonPressed = false;

    //72
    private int total = 0;

    void Start(){
        collision.ItemDropper = this;
        foreach (GameObject item in items){
            total += item.transform.GetChild(0).gameObject.GetComponent<weaponStats>().dropChance;
        }
    }

    void Update()
    {
        if (SpawnEnemy.enemyCount == 0 && Input.GetKeyDown("f") && buttonPressed == false)
        {
            buttonPressed = true; 
            pickUpCurrent(closest());              
        }

        if (SpawnEnemy.enemyCount == 0 && Input.GetKeyDown("g") && buttonPressed == false)
        {
            buttonPressed = true; 
            addInventory(closest());
        }
    }

    //called after enemy dies
    //picks random number and decides if it should drop an item
    public void itemDrop(Vector2 pos)
    {
        int shouldDrop = Random.Range(0, 10);

        if (shouldDrop <= 100)
        {
            makeItem(pos);
        }
    }

    //creates an item randomly from the list of createable items
    private void makeItem(Vector2 pos){
        int chance = Random.Range(0, total + 1);
        int weaponNum = 0; 
            for (int i = 0; i < items.Count - 1; i ++){
                if (chance <= items[i].gameObject.transform.GetChild(0).GetComponent<weaponStats>().dropChance){
                    weaponNum = i;
                    break;
                }
                else
                    chance -= items[i].gameObject.transform.GetChild(0).GetComponent<weaponStats>().dropChance;
            }
        GameObject spawnedWeapon = dropItem(weaponNum, items[weaponNum].transform.GetChild(0).gameObject, pos);

        //makes sure the item cannot be dropped again
        //total -= items[weaponNum].transform.GetChild(0).GetComponent<weaponStats>().dropChance;
        //items.RemoveAt(weaponNum);

        droppedItems.Add(spawnedWeapon);
    }

    //gets the closest item to the player on the ground
    public int closest()
    {          
        int whichWep = 0;
        float dist = Vector2.Distance(PlayerInfo.playerLocation, droppedItems[0].transform.position);
        for (int i = 1; i < droppedItems.Count; i++){
            float distChecker = Vector2.Distance(PlayerInfo.playerLocation, droppedItems[i].transform.position);
            if (distChecker < dist){
                dist = distChecker;
                whichWep = i;
            }
        }
        return whichWep;
    }

    //changes the current item with the item just dropped
    public void pickUpCurrent(int wepNum)
    {
        Vector2 pos = droppedItems[wepNum].transform.position;
        //drops current weapon
        droppedItems.Add(dropItem(Weapons.currentWeapon, Weapons.prefabs[Weapons.currentWeapon].transform.GetChild(0).gameObject, pos));
        //picks up ground weapon
        Weapons.changeWeapon(items[droppedItems[wepNum].GetComponent<ItemPlaceHolder>().wepLoc]);

        Destroy(droppedItems[wepNum]);
        droppedItems.RemoveAt(wepNum);

        

        Weapons.canAttack = true;
        Weapons.swordSwung = false;
        buttonPressed = false; 
    }

    //adds the closest item to your inventory
    public void addInventory(int wepNum)
    {        
        GameObject passWep = items[droppedItems[wepNum].GetComponent<ItemPlaceHolder>().wepLoc];
        Weapons.player.GetComponent<InventoryItems>().addItem(passWep.transform.GetChild(0).gameObject, Weapons.findWep(passWep.name));

        Destroy(droppedItems[wepNum]);
        droppedItems.RemoveAt(wepNum);

        buttonPressed = false; 
    }

    //creates a weapon on the ground
    private GameObject dropItem(int num, GameObject wep, Vector2 pos){
        //creates item placeHolder
        GameObject spawned = Instantiate(placeHolder, pos, Quaternion.identity);
        //changes placeholder sprite to match the item that was "dropped"
        spawned.GetComponent<SpriteRenderer>().sprite = wep.GetComponent<SpriteRenderer>().sprite;
        spawned.GetComponent<SpriteRenderer>().color = wep.GetComponent<SpriteRenderer>().color;
        spawned.GetComponent<ItemPlaceHolder>().wepLoc = num;
        return spawned;
    }
}
