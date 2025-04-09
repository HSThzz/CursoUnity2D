using UnityEngine;

public class MeuDelegate : MonoBehaviour
{
        delegate void ExecutarMeuDelegate(int numero);
        ExecutarMeuDelegate execute_meu_delegate;//agregando a fun�ao a uma variavel

    delegate void teste_delegate();
    teste_delegate testando_delegate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        execute_meu_delegate = imprimir_numero;
        execute_meu_delegate(10); //chamada da fun�ao
        execute_meu_delegate = multiplicar_numero;
        execute_meu_delegate(10);//chamada da fun�ao

        testando_delegate += fala; //atribuindo fun�ao
        testando_delegate += fala2;//atribuindo fun�ao
        testando_delegate(); //executa as duas fun�oes ao mesmo tempo
        
        if(testando_delegate != null)
        {
            testando_delegate -= fala; //limpando delegate
            testando_delegate -= fala2;//limpadno delegate
            Debug.Log("Delegate esta vazio");
            testando_delegate(); //agora null
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void imprimir_numero(int numero)
    {
        Debug.Log("O numero �: " + numero);
    }
    void multiplicar_numero(int numero)
    {
        Debug.Log("O numero �: " + numero *2);
    }
    void fala()
    {
        Debug.Log("ola");
    }
    void fala2()
    {
        Debug.Log("tudo bem?");
    }
}
