using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Manage Character
public class UnitManager : MonoBehaviour
{
    //Status 
    public int hp;
    public int at;


    //Attack target
    public void Attack(UnitManager target)
    {
        target.Damage(at);
    }

    //Take damage
    void Damage(int damage)
    {
        hp -= 10;
        Debug.Log(name+"‚Í" + damage + "ƒ_ƒ[ƒW‚ğó‚¯‚½");
    }

}
