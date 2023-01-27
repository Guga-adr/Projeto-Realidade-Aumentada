using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaParedeLR : MonoBehaviour
{
    public float countDown;

    void Start()
    {

    }

    void Update()
    {
        Debug.Log(countDown);
        countDown -= Time.deltaTime;

        // Movimenta a parede de acordo com a orientação de sua rotação.
        if(countDown > 0.0f)
        {
            transform.position += transform.right * Time.deltaTime;
            countDown -= Time.deltaTime;
        }
        else if (countDown <= 0.0f)
        {
            transform.position -= transform.right * Time.deltaTime;
            countDown -= Time.deltaTime;
            if(countDown <= -5.0f)
            {
                countDown = 5.0f;
            }
        }
    }
}
