using UnityEngine;
//necessario para usar dictionary
using System.Collections.Generic;
public class dictionary : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* Dictionary<string, int> inventario = new Dictionary<string, int>();
        inventario.Add("sapato", 5);
        inventario.Add("blusa", 3);
        inventario.Add("oculos", 3);
        inventario["oculos"] += 3;

        if (inventario.ContainsKey("oculos"))
        {
            Debug.Log(inventario["oculos"]);
        }
        else
        {
            Debug.Log("Nao existem itens em sapato");
        }*/
        Dictionary<string, int> Inventario = new Dictionary<string, int>();
        Inventario["Espada"] = 3;
        Inventario["Poção"] = 5;

        // Percorre cada par (chave, valor)
        foreach (var item in Inventario)
        {
            Debug.Log("Chave: " + item.Key + ", Valor: " + item.Value);
        }

        // Se quiser acessar só as chaves diretamente:
        foreach (var chave in Inventario.Keys)
        {
            Debug.Log("Chave: " + chave);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
