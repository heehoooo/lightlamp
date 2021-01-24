using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject motherDrawer;
    public GameObject player;
    public float speed;

    public float maxPosition;

    public bool isEnter;
    public bool moveMode;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        motherDrawer = GameObject.FindGameObjectWithTag("MotherDrawer");
        moveMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isEnter == true && moveMode == false)
        {
            moveMode = true;
        }
        if(moveMode == true && transform.localPosition.x < maxPosition)
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            isEnter = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            isEnter = false;
        }
    }
}
