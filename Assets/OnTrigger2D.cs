using UnityEngine;

public class OnTrigger2D : MonoBehaviour
{
    [SerializeField]
    private Transform moveObject;
    [SerializeField]
    private Vector3 moveDirection;
    [SerializeField]
    private float moveSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        moveObject.position += moveDirection * moveSpeed * Time.deltaTime;   
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        moveObject.position = new Vector3(0, 2.5f, 0);
    }
}
