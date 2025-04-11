using UnityEngine;

public class colisoes : MonoBehaviour
{
    int celulares;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Objetos")
        {
            Debug.Log(colisao.gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "Celular")
        {
        Destroy(colisao.gameObject);
            celulares++;
        Debug.Log("Coletou " + celulares + " celulares");
        }
    }
    /*private void OnCollisionExit2D(Collision2D colisao) 
    {
        Debug.Log(colisao.gameObject.name);
    }
    private void OnCollisionStay2D(Collision2D colisao)
    {
        Debug.Log(colisao.gameObject.name);
    }*/
}
