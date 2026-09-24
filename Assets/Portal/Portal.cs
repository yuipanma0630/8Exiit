using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform destination;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = new Vector2(destination.position.x, destination.position.y);
       
    }
}
