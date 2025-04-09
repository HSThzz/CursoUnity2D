using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class interpoladorT : MonoBehaviour
{
    public Transform inicio;
    public float fim = 9f;
    public float tempo = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimentando o personagem em uma linha horizontal
                                                    //posicao eixo x         e            posicao y
        if(tempo <= 2)
        {
        transform.position = new Vector2(math.lerp(inicio.position.x, fim, tempo += 0.1f), -2.36f);
        }
    }
}
