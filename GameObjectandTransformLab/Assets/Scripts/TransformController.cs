
using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
     
       // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        transform.position = p;
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
        
        // Rotation Around the x-Axis
        transform.Rotate(new Vector3(30, 0, 0) * Time.deltaTime);
    }

    }

 
    

