using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "≈ˆµΩŒ“¡À");
        if (other.name == "Ball")
        {
            Time.timeScale = 0;
        }
        

    }
    
    
}
