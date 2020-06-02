using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guruguru : MonoBehaviour
{
    public float rotate_speed = 3.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.rotate_speed = 10.0f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            this.rotate_speed=3f;
        }
        transform.Rotate(this.rotate_speed, this.rotate_speed, 0);
    }
}
