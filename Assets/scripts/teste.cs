using UnityEngine;
using System.Collections.Generic;//necessario para usar list


public class teste : MonoBehaviour
{

    //variavel life privativa, nao aparece no inspector
    private int life = 2;

    //variavel life privativa
    public int nivel = 3;

    //array
    int[] array_teste = new int[3];

    //list
    List<int> lista_teste = new List<int>();

    //variavel velocity privativa e serializada, mesmo privada aparece no inspector
    [SerializeField] private int velocity = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        array_teste[0] = velocity;
        array_teste[1] = 10;
        array_teste[2] = velocity + 10;
        //
        lista_teste.Add(velocity+30);
        lista_teste.Add(60);
        lista_teste.Add(velocity + 50);
        //
        Debug.Log("Seu nivel do jogador é: " + nivel);
        for (int i = 0; i < array_teste.Length; i++)
        {
            Debug.Log(array_teste[i]);
        }
        Debug.Log(lista_teste.Count);
        for (int i = 0; i < lista_teste.Count; i++)
        {
            Debug.Log(lista_teste[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
