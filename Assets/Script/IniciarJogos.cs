using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IniciarJogos : MonoBehaviour
{
   public string nomeDaCena;
   
   public Text playerName;
   public void MudarCena()
   {
    Debug.Log("O nome do player é " + playerName);
    ReceberNome.nomeplayer = playerName.text;
    SceneManager.LoadScene(nomeDaCena);
   }

   public void CreditoCena()
   {
       SceneManager.LoadScene(nomeDaCena);
   }
   public void MenuCena()
   {
       SceneManager.LoadScene(nomeDaCena);
   }

   public void SairCena()
   {
       Application.Quit();
   }
}
