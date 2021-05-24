using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSCript : MonoBehaviour
{
    int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        print(score);
        if (Input.GetKey(KeyCode.UpArrow))
        {

            score = score - 50;
            print("remaining fuel" + score);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            score = score - 10;
            print("remaining fuel" + score);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            score = score - 50;
            print("remaining fuel" + score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
