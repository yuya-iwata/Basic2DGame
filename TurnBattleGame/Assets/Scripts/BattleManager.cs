using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Manage Battle
//Player vs Enemy
public class BattleManager : MonoBehaviour
{
    //Get Player
    public UnitManager player;
    //Get Enemy
    public UnitManager enemy;
    // Start is called before the first frame update
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Attack Player to Enemy

    //Attack Enemy to Player
}
