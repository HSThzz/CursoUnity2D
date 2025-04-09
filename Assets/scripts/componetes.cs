using UnityEngine;

public class componetes : MonoBehaviour
{
    //declarando como componete de spriterenderer
    private SpriteRenderer verSprite, flipSprite, colorSprite;
    //declarando uma variavel de cores mescladas
    private Color color = new Color32(100,50,100,50);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //variaveis que guardam o componete da interface grafica
        verSprite = GetComponent<SpriteRenderer>();
        flipSprite = GetComponent<SpriteRenderer>();
        colorSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //recuperando imput do teclado
        if (Input.GetKeyDown(KeyCode.G))
        {
            //dando a componete gravidade a um objeto
            gameObject.AddComponent<Rigidbody2D>();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            verSprite.enabled = !verSprite.enabled; 
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            flipSprite.flipX = !flipSprite.flipX;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            colorSprite.color = color;
        }



    }
}
