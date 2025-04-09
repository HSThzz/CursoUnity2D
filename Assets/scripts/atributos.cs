using UnityEngine;

public class atributos : MonoBehaviour
{
    [Header("informaçoes do jogador")]
    [Tooltip("controla velocidade")]
    [SerializeField]//faz uma variavel privativa aparecer no inspector(nao aparece normalmente)
    private float velocidade;

    [Multiline]//da uma caixa de escrita no inspector
    public string info;

    [HideInInspector]//esconde a variavel no inspector
    [Range(0,10)]//define um range
    public int vidas;

    [Space(10)]//espaço entre dois atributos

    [Header("informaçoes do inimigo")]//adicionando atributo ao inspector
    public float velocidadeInimigo;
    public int vidasInimigo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
