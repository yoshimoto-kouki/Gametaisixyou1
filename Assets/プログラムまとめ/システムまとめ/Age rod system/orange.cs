//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class orange : MonoBehaviour
//{
//    public static float orangeHP;
//    // Start is called before the first frame update
//    void Start()
//    {
 
//    }

//        void OnTriggerStay2D(Collider2D collider)
//        {
//        if (collider.gameObject.layer == LayerMask.NameToLayer("agebar"))
//        { orangeHP = yellow.GetcurrentHP();
            
//            Debug.Log("orange" + orangeHP);
//            if (0 <= orangeHP)
//            {
//                orangeHP=orangeHP-0.02f;
//            }
//            //else
//            //{
//            //    UnityEditor.EditorApplication.isPlaying = false;
//            //}
//        }
//    }
//    public static float GetorangeHP()
//    {
//        return orangeHP;
//    }
//}
