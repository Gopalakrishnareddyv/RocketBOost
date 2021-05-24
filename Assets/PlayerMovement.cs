using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float boostspeed;
    public float movementspeed;
    //float score=1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, boostspeed, 0));
            //score = score -50;
            //print("remaining fuel"+score);
            
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(movementspeed, 0, 0));

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-movementspeed, 0,0));

        }
    }
}
