using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedrawer : MonoBehaviour
{
    public drawer firstdrawer;
    public GameObject drawer1, drawer2, drawer3;
    // Start is called before the first frame update
    void Start()
    {
        drawer1 = GameObject.Find("Drawer1");
        drawer2 = GameObject.Find("Drawer2");
        drawer3 = GameObject.Find("Drawer3");
    }

    // Update is called once per frame
    void Update()
    {
        if(firstdrawer.moveMode == true && firstdrawer.isEnter == true && Input.GetMouseButtonDown(0))
        {
            firstdrawer.moveMode = false;
            drawer1.transform.localPosition = Vector3.MoveTowards(drawer1.transform.localPosition, new Vector3(0.1f, drawer1.transform.localPosition.y, drawer1.transform.localPosition.z), 1f);
        }
    }
}
