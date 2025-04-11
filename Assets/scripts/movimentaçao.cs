using System.Collections;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class movimentaçao : MonoBehaviour
{
    public Texture2D mousePonteiro;
    public Rigidbody2D meuCorpo;
    public SpriteRenderer flip;
    private Animator player;

    public float movSpeed = 5f;
    public float forcaPulo = 190;
    public bool jump = false;
    [SerializeField] private int countPulo = 1;
    [SerializeField] private int maxjump = 2;

    private float horizontal;
    private bool estaNoChao;
    private bool facingright = true;

    //tiro
    public float velTiro;
    public GameObject tiroPrefab;

    //tempo tiro
    public float delaytiro;
    private bool tirodisparado;

    [SerializeField] private Transform groundCheck, bala;
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

        // Checa se está no chão
        estaNoChao = Physics2D.OverlapCircle(groundCheck.position, 0.2f, camadaChao);

        player.SetBool("estaNoChao", estaNoChao);


        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            jump = true;
            countPulo++;
            
        }
        if (Input.GetMouseButtonDown(0) && tirodisparado == false) 
        { 
            if(meuCorpo.velocity.x != 0 && estaNoChao)
            {
                atirar();
            }
        }

        if(estaNoChao)
        {
            countPulo = 1;
        }
        animacoes();
    }

    private void FixedUpdate()
    {
        MovHorizontal(horizontal);
        if (jump && countPulo <= maxjump)
        {
            JumpPlayer();
        }
    }

    void animacoes()
    {
        player.SetFloat("velocidadeY", meuCorpo.velocity.y);
        player.SetBool("run", meuCorpo.velocity.x != 0f && estaNoChao);
        player.SetBool("jump", !estaNoChao);
    }
    private void MovHorizontal(float horizontal)
    {
        meuCorpo.velocity = new Vector2(horizontal * movSpeed, meuCorpo.velocity.y);

        
        if ((horizontal > 0 && !facingright) || (horizontal < 0 && facingright))
        {
            flipar();
        }
    }


    void JumpPlayer()
    {

        meuCorpo.AddForce(new Vector2(0f, forcaPulo));
        estaNoChao = false; 
        jump = false;   
    }

    void flipar()
    {
        facingright = !facingright;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        velTiro *= -1;  
        transform.localScale = theScale;    
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

    void atirar()
    {
        tirodisparado = true;
        StartCoroutine("temptiro");
        GameObject temptiro = Instantiate(tiroPrefab);
        temptiro.transform.position = bala.position;

        //flip
        if (facingright == false)
        {
        temptiro.GetComponent<SpriteRenderer>().flipX = true;
        }

        temptiro.GetComponent<Rigidbody2D>().velocity = new Vector2(velTiro, 0f); 
    }
    IEnumerator temptiro()
    {
        yield return new WaitForSeconds(delaytiro);
        tirodisparado = false;
    }

    
}