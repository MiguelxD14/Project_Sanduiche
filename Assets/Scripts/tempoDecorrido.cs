using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tempoDecorrido : MonoBehaviour
{
    //Script que controla as funções do tempo decorrido
    
    public int Tempo = 120; // Variavel de controle de tempo
    // Update is called once per frame
    
    void Start()
    {
        StartCoroutine("Diminuir"); //Inicia a contagem quando o contador é ativado;
    }
    void Update()
    {
       this.GetComponent<TextMeshProUGUI>().text = Tempo.ToString(); //Acessa o componente de texto da contagem e converte o float Tempo para string
    }
    
    IEnumerator Diminuir()
    {
        yield return new WaitForSeconds(1F); 
        if(Tempo != 0) // Se o tempo for menor diferente de 0;
        {
            Tempo -= 1; //Diminui em 1 o valor de tempo por segundo;
            StartCoroutine("Diminuir"); //Chama novamente a corotina;
        } 
    }
    
}
