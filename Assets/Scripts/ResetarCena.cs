using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetarCena : MonoBehaviour
{
    //Reseta a cena atual
    public void OnClick() // void atrelado ao botão de reiniciar, presente na tela de resultado final;
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
