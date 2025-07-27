using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Move Setting")]
    [Range(0.0f, 10.0f)]
    public float moveSpeed = 3.0f;
    [Space(20)]
    [SerializeField]
    private Vector3 moveDirection;

    private Rigidbody2D rigid2d;
    private void Awake()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveDirection = Vector3.zero;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(x, y, 0);

        if ( Input.GetKey(KeyCode.LeftShift) )
        {
            rigid2d.linearVelocity = moveDirection * moveSpeed * 2;
        }
        else
        {
            rigid2d.linearVelocity = moveDirection * moveSpeed;
        }
    }
}
