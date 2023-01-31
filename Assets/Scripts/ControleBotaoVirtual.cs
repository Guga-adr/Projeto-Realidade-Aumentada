using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ControleBotaoVirtual : MonoBehaviour
{

  private GameObject VB_Reset;

    // Start is called before the first frame update
    void Start()
    {
      //Pegando os Objetos
      VB_Reset = transform.Find("VB_Reset").gameObject;

      VB_Reset.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);

    }

    private void OnButtonPressed(VirtualButtonBehaviour vb)
      {
        if (vb.VirtualButtonName == "VB_Reset")
        {
          Debug.Log("Botão Reset Pressionado");
          SceneManager.LoadScene("PrimeiraFase");
        }
      }

    void Update()
    {
        
    }
}
