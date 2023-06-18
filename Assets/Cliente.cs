using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cliente : MonoBehaviour
{
    // Script responsavel por trocar os pedidos dos clientes;
    public GameObject SanduichePedido;
    public GameObject spriteSanduiche;
    public Sprite[] ImagenCliente;
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
