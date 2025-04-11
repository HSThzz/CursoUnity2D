using Unity.VisualScripting;
using UnityEngine;

public class movimentaçao : MonoBehaviour
{
    public Texture2D mousePonteiro;
    public Rigidbody2D meuCorpo;
    public SpriteRenderer flip;
    private Animator player;

    public float movSpeed = 5f;
    public float forcaPulo = 6f;
    public bool jump = false;   

    private float horizontal;
    private bool estaNoChao;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask camadaChao;

    void Start()
    {
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
        meuCorpo = GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
        player = GetComponent<Animator>();  
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");


        // Movimento horizontal
        //meuCorpo.velocity = new Vector2(horizontal * movSpeed, meuCorpo.velocity.y);

        // Checa se está no chão
        estaNoChao = Physics2D.OverlapCircle(groundCheck.position, 0.2f, camadaChao);
        player.SetBool("estaNoChao", estaNoChao);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            jump = true;    
            meuCorpo.velocity = new Vector2(meuCorpo.velocity.x, forcaPulo);
        }

        executaM();
    }

    private void FixedUpdate()
    {
        moveP(horizontal);
    }

    void executaM()
    {
        player.SetBool("run", meuCorpo.velocity.x != 0f && estaNoChao);
        player.SetBool("jump", meuCorpo.velocity.y!= 0f && jump);
        fliparT();
    }
    private void moveP(float horizontal)
    {
        meuCorpo.velocity = new Vector2(horizontal * movSpeed, meuCorpo.velocity.y);


    }

    void jumpM()
    {
        meuCorpo.AddForce(new Vector2(0f, forcaPulo));
        estaNoChao = false; 
        jump = false;   
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
            escala.x *= -1f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && escala.x < 0)
        {
            escala.x *= -1f;
        }

        transform.localScale = escala;
    }
}