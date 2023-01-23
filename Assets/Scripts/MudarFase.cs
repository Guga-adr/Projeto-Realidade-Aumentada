using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarFase : MonoBehaviour
{
    public string ProximaFase;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider colisor){
        if (colisor.gameObject.tag == "Player"){
            SceneManager.LoadScene(ProximaFase);
        }
    }
}
