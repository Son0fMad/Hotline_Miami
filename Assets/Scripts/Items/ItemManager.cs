using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Item item;
    private PlayerWeaponManager pw;
   void Start()
   {
       pw = FindObjectOfType<PlayerWeaponManager>();
   }
    void Update()
    {
                
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            col.GetComponent<PlayerWeaponManager>().inTrigger = true;

            if (Input.GetMouseButtonDown(1))
            {
                StartCoroutine("wait");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Player")
        {
            col.GetComponent<PlayerWeaponManager>().InTrigger = false;
        }
    }

    IEnumerator wait()
    {
        if (pw.curWeaponType != "Null")
        {
            pw.dropWeapon(pw.curWeaponType);
        }
        yield return new WaitForSeconds(0.05f);
        pw.curWeaponType = item.weaponType.ToString();
        Destroy(gameObject);
    }
}
