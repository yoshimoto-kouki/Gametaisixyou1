using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        this.transform.localScale = new Vector3(5, 5, 5);
    }

}
