using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agebaidou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
    Transform myTransform = this.transform;

    Vector3 pos = myTransform.position;
    pos.x += 0.0025f;
        myTransform.position = pos;
        if (Input.GetKeyDown(KeyCode.A))
        {
            pos.x += -0.06f;
            myTransform.position = pos;
        }
    }
}
