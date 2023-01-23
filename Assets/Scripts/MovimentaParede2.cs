using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaParede2 : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * velocidade * Time.deltaTime;
    }
}
