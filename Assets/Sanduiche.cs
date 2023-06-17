using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Sanduiche : MonoBehaviour
{
    public Sanduiches SanduicheConfig;

    public string Nome;
    //public string[] Ingredientes;
    public Sprite Icone;
    public string Receita;
    public GameObject Icon, textNome, textReceita;
    // Start is called before the first frame update
    void Start()
    {
        Nome = SanduicheConfig.Nome;
        textNome.GetComponent<Text>().text = Nome;
        Icone = SanduicheConfig.Icone;
        this.GetComponent<Image>().sprite = Icone;
        Receita = SanduicheConfig.Receita;
        textReceita.GetComponent<Text>().text = "Receita: " + Receita;

    }

}
