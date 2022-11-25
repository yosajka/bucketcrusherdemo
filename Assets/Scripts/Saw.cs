using UnityEngine;

public class Saw : MonoBehaviour
{
    
    [SerializeField]
    private float spinSpeed;

    
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.back, spinSpeed * Time.deltaTime);
    }

    private void OnMouseDrag(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePosition.x,mousePosition.y);
    }
}
