using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    public GameObject goal;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey("up"))
        { 
            transform.position += transform.forward * 0.1f;
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0,5,0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -5, 0);
        }
 　　}

    void OnCollisionStay(Collision other)

    {
        if (other.gameObject.tag == "Goal")
        {
            //setactiveで表示
            this.gameObject.SetActive(true);
        }
    }
}
