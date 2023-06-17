using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cliente : MonoBehaviour
{
    // Script responsavel por trocar os clientes e os pedidos;
    public GameObject SanduichePedido;
    public GameObject spriteSanduiche;
   // public Sprites[] Imagens;
    // Start is called before the first frame update
    void Start()
    {
       SanduichePedido = GameObject.FindGameObjectWithTag("Sanduiche");
    }

    // Update is called once per frame
    void Update()
    {   
        spriteSanduiche.GetComponent<Image>().sprite = SanduichePedido.GetComponent<Image>().sprite;
    }
}
