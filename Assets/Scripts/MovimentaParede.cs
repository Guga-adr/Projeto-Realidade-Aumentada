using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaParede : MonoBehaviour
{
    public float countDown = 5.0f;

    void Start()
    {

    }

    /*void Update()
    {
        if(transform.position.x < 14.21){
           this.transform.Translate(x: _movimento, y: 0, z: 0); 
        }

        if(transform.position.x >= 14){
           this.transform.Translate(x: -_movimento, y: 0, z: 0); 
        }

        //transform.position -= transform.forward * velocidade * Time.deltaTime;
    }*/
    
    void Update()
    {
        Debug.Log(countDown);
        countDown -= Time.deltaTime;

        // Movimenta a parede de acordo com a orientação de sua rotação.
        if(countDown > 0.0f)
        {
            transform.position += Vector3.forward * Time.deltaTime;
            countDown -= Time.deltaTime;
        }
        else if (countDown <= 0.0f)
        {
            transform.position += Vector3.back * Time.deltaTime;
            countDown -= Time.deltaTime;
            if(countDown <= -5.0f)
            {
                countDown = 5.0f;
            }
        }
    }
}
