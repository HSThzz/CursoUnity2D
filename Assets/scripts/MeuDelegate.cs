using UnityEngine;

public class MeuDelegate : MonoBehaviour
{
        delegate void ExecutarMeuDelegate(int numero);
        ExecutarMeuDelegate execute_meu_delegate;//agregando a funçao a uma variavel

    delegate void teste_delegate();
    teste_delegate testando_delegate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        execute_meu_delegate = imprimir_numero;
        execute_meu_delegate(10); //chamada da funçao
        execute_meu_delegate = multiplicar_numero;
        execute_meu_delegate(10);//chamada da funçao

        testando_delegate += fala; //atribuindo funçao
        testando_delegate += fala2;//atribuindo funçao
        testando_delegate(); //executa as duas funçoes ao mesmo tempo
        
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
        Debug.Log("O numero é: " + numero);
    }
    void multiplicar_numero(int numero)
    {
        Debug.Log("O numero é: " + numero *2);
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
