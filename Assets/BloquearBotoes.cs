using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BloquearBotoes : MonoBehaviour
{
    //Script que bloquei interação com outros botoes e chama o fundo cinza quando a tela final é chamada
    public GameObject[] Botoes;
    public GameObject Fundo;
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
