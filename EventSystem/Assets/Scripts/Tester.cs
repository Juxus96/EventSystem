using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.instance.SuscribeToEvent("MouseClick", MouseClick);
        EventManager.instance.SuscribeToEvent("MouseClick", MouseClicka);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EventManager.instance.RaiseEvent("MouseClick");
            EventManager.instance.RaiseEvent("MouseClick", 5);
        }
        if (Input.GetMouseButtonDown(1))
            EventManager.instance.UnsuscribeFromEvent("MouseClick", MouseClick);
    }

    private void MouseClick()
    {
        Debug.Log("Mouse click!");
    }
    
    private void MouseClicka(int i)
    {
        Debug.Log("Mouse click!" + i);
    }
}
