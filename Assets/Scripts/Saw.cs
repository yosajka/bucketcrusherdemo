using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Saw : MonoBehaviour
{
    
    [SerializeField]
    private float rotateAngle;
    private Rigidbody2D rbody;

    public float angularSpeed;

    

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        
    }

    // void Update()
    // {
    //     transform.RotateAround(transform.position, Vector3.back, spinSpeed * Time.deltaTime);
    // }

    
    void FixedUpdate()
    {
        angularSpeed = rbody.angularVelocity * Mathf.Rad2Deg;
        rbody.angularVelocity = rotateAngle;
    }

    private void OnMouseDrag(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x,mousePosition.y);
    }
}
