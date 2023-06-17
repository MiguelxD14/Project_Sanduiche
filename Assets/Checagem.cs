using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checagem : MonoBehaviour
{
    //Script responsavel por gerenciar a checagem de acertos, troca de sanduiches e adição de pontuação

    public Sanduiches[] SanduicheConfig; // Armazena os tipos de sanduiche existentes
    public string[] Ingredientes; // Armazena os ingredientes selecionados;
    public GameObject SanduichePedido,pontuacao,Resultados,Cliente; // SanduichePedido: Pega o gameObj responsavel por dizer qual sanduiche deve ser pronto; pontuacao: Acessa o GameObj de pontuação; Resultados: acessa a tela final de resultados; Cliente: gameobject responsavel por controlar a mudança de estados do cliente
    public tempoDecorrido TempoAtual; 
    public int Pontos; // atribui pontuação caso o jogador acerte;
    public bool Acertou = false, Errou = false; // Checa se o jogador acertou alguma combinação
    public int Acertos, Erros, Perdas; // Quantitativo de Acertos, Erros e Perdas (Perdas se tratam das vezes em que o jogador não entregou nenhum pedido dentro dex segundos)
    void Start()
    {
        SanduichePedido = GameObject.FindGameObjectWithTag("Sanduiche");
        pontuacao = GameObject.FindGameObjectWithTag("Ganho");
       // Cliente = GameObject.FindGameObjectWithTag("Cliente");
        TempoAtual = GameObject.FindGameObjectWithTag("Tempo").GetComponent<tempoDecorrido>();
        NovoSanduiche();
    }
    void Update()
    {
        ResultadosFinais();
        if(Acertou == true)
        {
            Acertos += 1;
            Pontos += 20;
            pontuacao.GetComponent<TextMeshProUGUI>().text = "R$ " + Pontos.ToString();
            NovoSanduiche();
            Acertou = false;
            
        }

        else if(Errou == true)
        {
            Erros += 1;
            Pontos -= 20;
            pontuacao.GetComponent<TextMeshProUGUI>().text = "R$ " + Pontos.ToString();
            NovoSanduiche();
            Errou = false;
        }

    }

    public void ResultadosFinais()
    {
        if(TempoAtual.Tempo == 0)
        {   
        Resultados.SetActive(true);
        Resultados.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Sanduiches Vendidos: " + Acertos.ToString();
        Resultados.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Sanduiches Errados: " + Erros.ToString();
        Resultados.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Sanduiches Perdidos: " + Perdas.ToString();
        Resultados.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Lucro do dia: R$ " + Pontos.ToString();
        }
        
    }
    public void AdcionarIngredientes(GameObject Op)
    {
       
        string Ingrediente;
        Ingrediente = Op.gameObject.name;

        if(Ingredientes[0] == "")
        {
            Ingredientes[0] = Ingrediente;
            
        }
        else
        if(Ingredientes[0] != "" && Ingredientes[1] == "")
        {

            Ingredientes[1] = Ingrediente;
            
        }
        else
        if(Ingredientes[1] != "" && Ingredientes[2] == "" )
        {
            Ingredientes[2] = Ingrediente;
            
        }
        
        if(Ingredientes[2] != "")
        {
            Erro();
            Acerto();
        }
       
       
    }

    void NovoSanduiche()
    {
        for(int i = 0; i < Ingredientes.Length; i ++)
        {
            Ingredientes[i] = "";
        }
        SanduichePedido.GetComponent<Sanduiche>().SanduicheConfig = SanduicheConfig[Random.Range(0,SanduicheConfig.Length)]; 
    }

    void Acerto()
    {
        if(SanduichePedido.GetComponent<Sanduiche>().Ingredientes[0] == Ingredientes[0] && 
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[1] == Ingredientes[1] &&
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[2] == Ingredientes[2])
        {
            Acertou = true;
        }
       
    }

    void Erro()
    {
        if(SanduichePedido.GetComponent<Sanduiche>().Ingredientes[0] != Ingredientes[0] || 
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[1] != Ingredientes[1] ||
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[2] != Ingredientes[2])
        {
            Errou = true;
        } 
    }

    // void Perdeu()
    // {
    //     if(Acertou == false && Errou == false && TempoAtual.Tempo -= 10)
    // }
}
