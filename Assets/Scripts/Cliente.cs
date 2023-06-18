using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cliente : MonoBehaviour
{
    // Script responsavel por trocar os pedidos dos clientes;
    public GameObject SanduichePedido; //Acessa o gameObject do Sanduiche que foi pedido;
    public GameObject spriteSanduiche; //Acessa o gameObject filho que contem o espaço do sprite para por a imagem do sanduiche;
    public Sprite[] ImagenCliente; //Array que gerencia os sprites dos Clientes;
    // Start is called before the first frame update
    void Start()
    {
        //Atribiu o gameObject no inicio da função;
       SanduichePedido = GameObject.FindGameObjectWithTag("Sanduiche");
    }

    // Update is called once per frame
    void Update()
    {   
        //Troca o sprite de sanduiche pelo sprite do Sanduiche pedido, em tempo real;
        spriteSanduiche.GetComponent<Image>().sprite = SanduichePedido.GetComponent<Image>().sprite;
    }
}
