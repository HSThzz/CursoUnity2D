using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class movimentaçao : MonoBehaviour
{
    public Texture2D mousePonteiro;
    public Rigidbody2D meuCorpo;
    private float horizontal;
    private float vertical;
    private float movSpeed = 10f;
    public SpriteRenderer flip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
        meuCorpo = GetComponent<Rigidbody2D>();
        meuCorpo.gravityScale = 9.8f;
        flip = GetComponent<SpriteRenderer>();
        flip.flipX = false;


    }

    // Update is called once per frame
  
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        movimenta(horizontal);

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // pulo();
            Debug.Log("pulo executado");

        }
    }

    void movimenta(float horizonal)
    {

        if ((Input.GetKeyDown(KeyCode.LeftArrow)) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            fliparT();
        }
        meuCorpo.linearVelocity = new Vector2(horizonal * movSpeed, meuCorpo.linearVelocityY);
    }
    void fliparS()
    {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                flip.flipX = true;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                flip.flipX = false;
            }
    }
    void fliparT()
    {
        Vector3 escala = transform.localScale;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && escala.x > 0)
        {
            escala.x = escala.x * -1f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && escala.x < 0)
        {
            escala.x = escala.x * -1f;
        }
            transform.localScale = escala;

    }
}
