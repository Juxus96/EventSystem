using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private int playerExp;
    private int playerGold;
    // Start is called before the first frame update
    void Start()
    {
        EventManager.instance.SuscribeToEvent("EnemyDie", GainExp);
        EventManager.instance.SuscribeToEvent("EnemyDie", GainGold);
    }


    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        EventManager.instance.RaiseEvent("EnemyDie",1);
    //    }
    //    if (Input.GetMouseButtonDown(1))
    //        EventManager.instance.UnsuscribeFromEvent("MouseClick", GainExp);
    //}



    private void GainExp(int enemyType)
    {
        playerExp += EnemyStorage.instance.enemies[enemyType].exp;
        Debug.Log(playerExp);
    }

    private void GainGold(int enemyType)
    {
        playerGold += EnemyStorage.instance.enemies[enemyType].gold;
        Debug.Log(playerGold);

    }
}
