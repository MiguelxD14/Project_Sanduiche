using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ScriptableObj responsavel por agregar as informações de cada tipo de Sanduiche;
[CreateAssetMenu(fileName = "Sanduiches", menuName = "Sanduiches/New Sanduiche")] // Cria uma nova seleção nome menu de add do Unity, da o nome do arquivo, nome do Menu e Submenu;
public class Sanduiches : ScriptableObject 
{
    //Abaixo estão todas as informaçôes relevantes para criação e distinção dos sanduiches;
    public string Nome;
    public Sprite Icone;
    public string[] Ingredientes;
    public string Receita;
}

