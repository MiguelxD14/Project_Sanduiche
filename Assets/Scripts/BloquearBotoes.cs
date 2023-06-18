using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BloquearBotoes : MonoBehaviour
{
    //Script que bloquei interação com outros botoes e chama o fundo cinza quando a tela final é chamada
    public GameObject[] Botoes; // Array que gerencia os botões a serem bloqueados;
    public GameObject Fundo; // GameObject que deixa tira o foco da tela prinicipal e ressalta a tela final;
    // Start is called before the first frame update
    void Start()
    {
        Fundo.SetActive(true);
        for(int i = 0; i < Botoes.Length; i++)
        {
            Botoes[i].GetComponent<Button>().interactable = false;
        }
    }
}
