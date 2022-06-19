using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour
{
    public string curWeaponType;
    public bool inTrigger = false;
    void Start()
    {
        
    }
    
    void Update()
    {
        WeaponManager();
    }

    void WeaponManager()
    {
        if (Input.GetMouseButtonDown(1) && !inTrigger)
        {
            dropWeapon(curWeaponType);
        }
    }

    public void dropWeapon(string weapon)
    {
        if (curWeaponType != "Null")
        {
            Instantiate(Resources.Load("Prefabs/Items/" + weapon), transform.position, Quaternion.identity);
            if (!inTrigger)
                curWeaponType = "Null";
        }
        else
        {
            Debug.Log("weapon is null");
        }
    }
}
