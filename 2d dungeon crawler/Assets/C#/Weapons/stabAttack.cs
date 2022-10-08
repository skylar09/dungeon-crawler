// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class stabAttack : MonoBehaviour
// {
//     public Weapons WeaponsScript;

//     // Start is called before the first frame update
//     void Start()
//     {
//         WeaponsScript = refrence.GetComponent<Weapons>();
//         WeaponsScript.yourWeapon.SetActive(false);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (!EventSystem.current.IsPointerOverGameObject())
//         {
//             //if left click
//             if (Input.GetMouseButtonDown(0) && Weapons.canAttack == true)
//             {
//                 activateWeapon();
//             }
//         }
//     }

//     public void bla()
//     {
//         weaponRef.GetComponent<Weapons>().yourWeapon = gameObject;
//     }
// }
