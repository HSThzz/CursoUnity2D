using UnityEngine;

public class TesteEventos : MonoBehaviour
{
    public delegate void OnInformDano();
    public event OnInformDano onDano; //associando evento ao delegate

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onDano += MostraDano;
        onDano();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ocultar blocos de codigo
    #region MinhasFunçoes 
    void MostraDano()
    {
        Debug.Log("Sofreu dano");
    }

}
#endregion