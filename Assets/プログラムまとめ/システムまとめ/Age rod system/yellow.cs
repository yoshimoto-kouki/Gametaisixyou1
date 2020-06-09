using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow : MonoBehaviour
{
    [SerializeField]
    private float AgeHP = 1000;
    [SerializeField]
    float currentHP;

    void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("ddd");
        
            if (0 <= currentHP)
            {
                currentHP = AgeHP - 1;
            }
            else
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
    }
}