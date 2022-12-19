using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemDropper")]
public class ItemDropper : ScriptableObject{
    [SerializeField]
    private List<GameObject> items = new List<GameObject>();
    [SerializeField]
    private GameObject placeHolder;
    
    private List<GameObject> droppedItems = new List<GameObject>();

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
        if (Input.GetKeyDown("f") && buttonPressed == false)
        {
            //Vector2 location = this.transform.position;
            //float dist = Vector2.Distance(location, PlayerInfo.playerLocation);

            //changes the current item with the item just dropped
            //if (dist <= 2)
            {
                buttonPressed = true;
                //closest(dist);     
                //if (this.gameObject == closestWep){
                    //pickUpCurrent();
                //}                  
            }
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
        //creates item placeHolder then changes its sprite to match the item that was picked
        GameObject spawnedWeapon = Instantiate(placeHolder, pos, Quaternion.identity);
        spawnedWeapon.GetComponent<SpriteRenderer>().sprite = items[weaponNum].GetComponent<SpriteRenderer>().sprite;
        spawnedWeapon.GetComponent<SpriteRenderer>().color = items[weaponNum].GetComponent<SpriteRenderer>().color;

        //makes sure the item cannot be dropped again
        total -= items[weaponNum].transform.GetChild(0).GetComponent<weaponStats>().dropChance;
        items.RemoveAt(weaponNum);

        droppedItems.Add(spawnedWeapon);
    }
}
