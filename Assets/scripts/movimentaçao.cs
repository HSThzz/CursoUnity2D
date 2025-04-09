using UnityEngine;

public class movimentaçao : MonoBehaviour
{
    public Texture2D mousePonteiro; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.GetAxis("Horizontal"));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse esquerdo pressionado");
        }else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse direito pressionado");
        }else if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Mouse meios pressionado");
        }
        

    }
}
