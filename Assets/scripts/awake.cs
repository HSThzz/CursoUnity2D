using UnityEngine;

public class awake : MonoBehaviour
{
    //ela � rodada antes da fun�ao start, mesmo se o script estiver desativado
    private void Awake()
    {
        Debug.Log("A fun�ao awake foi inicializada");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("A fun�ao awake foi inicializada");
    }

    // Update is called once per frame
    //nao usar codigos pesados dentro desse bloco de codigo, ex: reconhecer teclas 
    void Update()
    {
        
    }
}
