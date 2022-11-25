using UnityEngine;
using UnityEngine.UI;

public class CountBrick : MonoBehaviour
{
    public Text countDisplay;

    
    void Update()
    {
        countDisplay.text =  gameObject.transform.childCount + " bricks";  
    }
}
