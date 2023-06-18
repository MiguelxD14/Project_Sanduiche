using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Checagem : MonoBehaviour
{
    //Script responsavel por gerenciar a checagem de acertos, troca de sanduiches e adição de pontuação

    public Sanduiches[] SanduicheConfig; // Armazena os tipos de sanduiche existentes
    public string[] Ingredientes; // Armazena os ingredientes selecionados;
    public AudioClip[] Sons; // Gerencia os sons de acerto e erro;
    public GameObject SanduichePedido,pontuacao,Resultados,Cliente; // SanduichePedido: Pega o gameObj responsavel por dizer qual sanduiche deve ser pronto; pontuacao: Acessa o GameObj de pontuação; Resultados: acessa a tela final de resultados; Cliente: gameobject responsavel por controlar a mudança de estados do cliente
    public tempoDecorrido TempoAtual; // Acessa o script que controla o tempo decorrido;
    public int Pontos; // atribui pontuação caso o jogador acerte;
    public bool Acertou = false, Errou = false; // Checa se o jogador acertou alguma combinação
    public int Acertos, Erros; // Quantitativo de Acertos e Erros;
    void Start()
    {
        //Faz as atribuições de gameObjects e chama a função de randomizar os sanduiches;
        SanduichePedido = GameObject.FindGameObjectWithTag("Sanduiche");
        pontuacao = GameObject.FindGameObjectWithTag("Ganho");
        Cliente = GameObject.FindGameObjectWithTag("Cliente");
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
            this.GetComponent<AudioSource>().clip = Sons[0];
            this.GetComponent<AudioSource>().Play();
            pontuacao.GetComponent<TextMeshProUGUI>().text = "R$ " + Pontos.ToString();
            NovoSanduiche();
            Acertou = false;
            
        }

        else if(Errou == true)
        {
            Erros += 1;
            Pontos -= 20;
            this.GetComponent<AudioSource>().clip = Sons[1];
            this.GetComponent<AudioSource>().Play();
            pontuacao.GetComponent<TextMeshProUGUI>().text = "R$ " + Pontos.ToString();
            NovoSanduiche();
            Errou = false;
        }

    }

    public void ResultadosFinais() //Chama a tela de resultado final e atribui informações importantes;
    {
        if(TempoAtual.Tempo == 0)
        {   
            Resultados.SetActive(true);
            Resultados.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "Sanduíches Vendidos: " + Acertos.ToString();
            Resultados.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = "Sanduíches Errados: " + Erros.ToString();
            Resultados.transform.GetChild(4).GetComponent<TextMeshProUGUI>().text = "Lucro do dia: R$ " + Pontos.ToString();
        }
        
    }
    public void AdcionarIngredientes(GameObject Op) // void acessado por cada um dos botões de ingrediente, o gameObject OP é o proprio botão;
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

    void NovoSanduiche() // void responsavel por gerenciar a troca/randomização dos sanduiches. Além dos sprites dos clientes.
    {
        for(int i = 0; i < Ingredientes.Length; i ++)
        {
            Ingredientes[i] = "";
        }
        SanduichePedido.GetComponent<Sanduiche>().SanduicheConfig = SanduicheConfig[Random.Range(0,SanduicheConfig.Length)]; 
        Cliente.GetComponent<Image>().sprite = Cliente.GetComponent<Cliente>().ImagenCliente[Random.Range(0,Cliente.GetComponent<Cliente>().ImagenCliente.Length)];
    }

    void Acerto() //Gerencia as condições de acerto;
    {
        if(SanduichePedido.GetComponent<Sanduiche>().Ingredientes[0] == Ingredientes[0] && 
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[1] == Ingredientes[1] &&
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[2] == Ingredientes[2])
        {
            Acertou = true;
        }
       
    }

    void Erro() //Gerencia as condições de erro;
    {
        if(SanduichePedido.GetComponent<Sanduiche>().Ingredientes[0] != Ingredientes[0] || 
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[1] != Ingredientes[1] ||
        SanduichePedido.GetComponent<Sanduiche>().Ingredientes[2] != Ingredientes[2])
        {
            Errou = true;
        } 
    }

}
