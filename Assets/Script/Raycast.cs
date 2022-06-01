using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
 [SerializeField] private string selectableTag = "Selectable";
  [SerializeField]  public Transform selection;
   private void Update()
   {
       var ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
       RaycastHit hit;
       if(Physics.Raycast(ray, out hit))
       {
           var selection = hit.transform;
           if (selection.CompareTag(selectableTag))
           {
                transform.localScale = new Vector3(2f, 2f, 2f);
           }
           else
           {
               transform.localScale = new Vector3(1f, 1f, 1f);
           }
       }
   }
}
