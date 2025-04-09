using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        destroiObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void destroiObjeto()
    {
        //destroi o objeto imediatamente do tempo de execuçao no tempo colocado no 2 parametro
        Destroy(gameObject, 2f);
    }
}
