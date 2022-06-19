using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator anim;

    PlayerWeaponManager pw;

    int weaponID = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
        pw = GetComponent<PlayerWeaponManager>();
    }

    void Update()
    {
        WeaponAnimation(pw.curWeaponType);
        anim.SetInteger("weapons", weaponID);
    }

    void WeaponAnimation(string weapon)
    {
        switch (weapon)
        {
            case "Null":
                weaponID = 0;
                break;
            case "Pistol":
                weaponID = 1;
                break;
            case "UZI":
                weaponID = 2;
                break;
            default:

                break;
        }
    }
}
