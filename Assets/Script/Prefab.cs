using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab : MonoBehaviour
{
   
    public GameObject myPrefab;

    void Start()
    {

        StartCoroutine(teste());
    }

    IEnumerator teste()
    {
        
        yield return new WaitForSeconds(5);
        Destroy(myPrefab);

    }

    void Update() {

    Instantiate(myPrefab, new Vector3(-91.5f, 2.5f, 2f), Quaternion.identity);

    }
}
