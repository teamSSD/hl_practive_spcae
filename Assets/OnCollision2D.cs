using UnityEngine;

public class OnCollision2D : MonoBehaviour
{
    [SerializeField]
    private Color m_Color;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.color = m_Color;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log($"{gameObject.name} : OnCollisionStay2D() ½ÇÇà");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
