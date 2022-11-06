using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class stabAttack : MonoBehaviour
{
    public Weapons WeaponsScript;
    public GameObject refrence;

    // Start is called before the first frame update
    void Start()
    {
        WeaponsScript = refrence.GetComponent<Weapons>();
        WeaponsScript.yourWeapon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            //if left click
            if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
            {
                Attack();
            }
        }
    }

    public void Attack()
    {
        //this.transform.parent.gameObject.GetComponent<Rigidbody2D>();
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);  
        float x = worldPosition.x - this.transform.parent.gameObject.transform.position.x;
        float y = worldPosition.y - this.transform.parent.gameObject.transform.position.y;
        this.transform.parent.gameObject.GetComponent<Transform>().rotation = new Quaternion (0, 0, Mathf.Atan(y/x), 0);

        WeaponsScript.yourWeapon.SetActive(true);

        Weapons.swordSwung = true;
        Weapons.canAttack = false;
    }
}
