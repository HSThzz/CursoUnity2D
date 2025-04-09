using System.Collections;
using UnityEngine;

public class rotinas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("destroiObjeto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //rotina
    IEnumerator destroiObjeto()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Objeto destruido");
    }

}
