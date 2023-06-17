using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Sanduiches", menuName = "Sanduiches/New Sanduiche")]
public class Sanduiches : ScriptableObject 
{
    public string Nome;
    public Sprite Icone;
    public string[] Ingredientes;
    public string Receita;
}

