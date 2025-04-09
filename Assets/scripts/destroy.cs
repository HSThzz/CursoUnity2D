using UnityEngine;

public class destroy : MonoBehaviour
{
    GameObject celular;
    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject celular = GameObject.FindGameObjectWithTag("Objetos");
        GameObject player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Aqui comparamos a distância ao invés de igualdade absoluta
        if (Vector2.Distance(player.transform.position, celular.transform.position) < 0.1f)
        {
            destroiObjeto();
        }

        void destroiObjeto()
        {
            Destroy(gameObject);

        }
    }
}
