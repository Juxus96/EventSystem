using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyType = 1;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            OnDie();
    }

    private void OnDie()
    {
        EventManager.instance.RaiseEvent("EnemyDie", enemyType);
        Destroy(gameObject);
    }

}
