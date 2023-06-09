using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        //player.Attack(enemy);
        //enemy.Attack(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Attack Player to Enemy
    public void OnAttackButton()
    {
        player.Attack(enemy);
        if (enemy.hp > 0)
        {
            EnemyTurn();
        }
        else
        {
            BattleEnd();
        }

    }

    //Attack Enemy to Player
    void EnemyTurn()
    {
        enemy.Attack(player);
        if(player.hp == 0)
        {
            BattleEnd();
        }
    }

    void BattleEnd()
    {
        Debug.Log("�ΐ�I��");

        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
