using UnityEngine;

public class Brick : MonoBehaviour
{
    
    [SerializeField]
    private float health = 100f;

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Saw"))
        {
            health -= 50;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
