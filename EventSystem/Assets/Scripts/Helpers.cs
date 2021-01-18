using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.instance.SuscribeToEvent("CheckGreater", (int i) => { print("a");  return i > 6; });
        EventManager.instance.SuscribeToEvent("CheckGreater", (int i) => { print("b");  return i < 12; });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
