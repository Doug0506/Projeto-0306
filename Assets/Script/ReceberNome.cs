using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ReceberNome : MonoBehaviour
{

public static string nomeplayer;

public TextMeshProUGUI  playername;


    // Update is called once per frame
    void Start()
    {
                playername.text = nomeplayer;
    }
}
