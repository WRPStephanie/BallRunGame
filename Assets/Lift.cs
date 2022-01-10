using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    bool lift = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!lift) return;
        transform.parent.Translate(0, 10 * Time.deltaTime, 0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            lift = true;
            Debug.Log("ÎßºþÆð·É");
        }
        
    }
}
