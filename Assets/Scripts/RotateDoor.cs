using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoor : MonoBehaviour
{
    public float speed = 1.0f;
    public string direction;
    private int limit = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (direction == "left")
        {
            if (transform.rotation.eulerAngles.y < limit)
            {
                transform.Rotate(0, speed, 0);
            }
        }
        else if (direction == "right")
        {
            if (transform.rotation.eulerAngles.y > limit)
            {
                transform.Rotate(0, -speed, 0);
            }
        }
    }
}
