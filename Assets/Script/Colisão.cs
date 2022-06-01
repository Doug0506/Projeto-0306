using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisão : MonoBehaviour
{
 void OnTriggerEnter(Collider collider)
     {
          if(collider.tag == "Player") 
          {
               Destroy(gameObject);
          }
     }

}
