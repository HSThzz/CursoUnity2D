using UnityEngine;

public class invoca : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //executa a funçao descrita no determinado tempo
        //Invoke("destroi", 2f);
        //executa repetidamente depois de dois segundos a cada 2 segundos
        InvokeRepeating("destroi", 2f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CancelInvoke("destroi");
        }
    }
    void destroi()
    {
        //Destroy(gameObject);
        Debug.Log("Objeto foi destruido");
    }
}
