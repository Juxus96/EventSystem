using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStorage : MonoBehaviour
{
    public static EnemyStorage instance;

    public EnemyData[] enemies;

    private void Awake()
    {
        instance = this;
    }

}
