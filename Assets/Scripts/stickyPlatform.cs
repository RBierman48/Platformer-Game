using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlatform : MonoBehaviour
{
  
    void Start()  // Start is called before the first frame update
    {
        
    }

   
    void Update() // Update is called once per frame
    {
        
    }

    private void OnCollisionEnter(Collision collision) 
    { 
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
