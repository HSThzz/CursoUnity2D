using UnityEngine;

public class movimentaçao : MonoBehaviour
{
    public Texture2D mousePonteiro;
    public Rigidbody2D meuCorpo;
    public SpriteRenderer flip;

    public float movSpeed = 5f;
    public float forcaPulo = 6f;

    private float horizontal;
    private bool estaNoChao;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask camadaChao;

    void Start()
    {
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
        meuCorpo = GetComponent<Rigidbody2D>();
        flip = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        // Flip
        if (horizontal < 0)
            flip.flipX = true;
        else if (horizontal > 0)
            flip.flipX = false;

        // Movimento horizontal
        meuCorpo.velocity = new Vector2(horizontal * movSpeed, meuCorpo.velocity.y);

        // Checa se está no chão
        estaNoChao = Physics2D.OverlapCircle(groundCheck.position, 0.2f, camadaChao);

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            meuCorpo.velocity = new Vector2(meuCorpo.velocity.x, forcaPulo);
        }
    }

    // Gizmo para ver o GroundCheck
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, 0.2f);
        }
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




