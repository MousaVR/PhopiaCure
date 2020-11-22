using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class PlayerMovementController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.eulerAngles.x > 30  && Camera.main.transform.eulerAngles.x <90 )
        {
            Vector3 dir  = Camera.main.transform.forward;
            dir.y = 0;
            transform.Translate(dir * Time.deltaTime);
        }
    }
}
