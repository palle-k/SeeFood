using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c){
      if(c.tag == "destroyable"){
           Destroy(c.gameObject);
      }
    }
}
