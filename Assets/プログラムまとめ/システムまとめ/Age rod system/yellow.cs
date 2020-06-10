//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class yellow : MonoBehaviour
//{
//    public static float currentHP=1000;
//    void Start()
//    {
//    }
//    void OnTriggerStay2D(Collider2D collider)
//    {
//        if(collider.gameObject.layer == LayerMask.NameToLayer("agebar"))
//        {
//            Debug.Log("yellow"+currentHP);
        
//            if (0 <= currentHP)
//            {
//                currentHP=currentHP-0.01f;
//            }

//        }
//    }
//    public static float GetcurrentHP()
//    {
//        return currentHP;
//    }
//}