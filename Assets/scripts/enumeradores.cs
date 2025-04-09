using UnityEngine;

public class enumeradores : MonoBehaviour
{
    public enum Heroi { Parado, Correndo, Morrendo, Pulando }

    public Heroi acao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (acao == Heroi.Parado)
        {
            Debug.Log("Parado");
        }
        else if (acao == Heroi.Pulando)
        {
            Debug.Log("Pulando");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
