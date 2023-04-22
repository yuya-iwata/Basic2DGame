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
        hp -= damage;
        Debug.Log(name+"は" + damage + "ダメージを受けた");

        if (hp <= 0)
        {
            hp = 0;
            Debug.Log(name + "は戦闘不能");
        }
    }

}
