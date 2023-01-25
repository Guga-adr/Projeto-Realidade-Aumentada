using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCaixa : MonoBehaviour
{
    
    //Controla a velocidade de rotação da caixa
    public float velocidade;
    
    //Método executa após o cálculo de física
    private void FixedUpdate() {
        
        float desl = velocidade * Time.fixedDeltaTime, 
              rotacaoHorizontal = Input.GetAxis("Horizontal") * desl,
              rotacaoVetical = Input.GetAxis("Vertical") * desl;

        transform.Rotate(rotacaoVetical, 0, -rotacaoHorizontal);

    }

}
