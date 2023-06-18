using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Sanduiche : MonoBehaviour
{
    // Script utilizado para gerenciar os tipos de sanduiches, apartir dos scriptableObjs
    public Sanduiches SanduicheConfig;  // Chama o script do scriptableObj;

    //Pega todas as exatas informações do scriptableObj selecionado;
    public string Nome;
    public string[] Ingredientes;
    public Sprite Icone;
    public string Receita;
    public GameObject Icon, textNome, textReceita;
    
    void Update()
    {
        //Atribui as informações em tempo real;
        Nome = SanduicheConfig.Nome;
        textNome.GetComponent<Text>().text = Nome;
        Ingredientes = SanduicheConfig.Ingredientes;
        Icone = SanduicheConfig.Icone;
        this.GetComponent<Image>().sprite = Icone;
        Receita = SanduicheConfig.Receita;
        textReceita.GetComponent<Text>().text = "Receita: " + Receita;

        
    }
}
