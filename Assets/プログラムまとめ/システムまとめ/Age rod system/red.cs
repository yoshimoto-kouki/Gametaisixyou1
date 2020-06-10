//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class red : MonoBehaviour
//{
//    float currentHP;
//    // Start is called before the first frame update
//    void Start()
//    {
//        currentHP = yellow.GetcurrentHP();
//    }

//    private void OnTriggerStay2D(Collider2D collider)
//    {
//        if (collider.gameObject.layer == LayerMask.NameToLayer("agebar"))
//        {
//            if (0 <= currentHP)
//            {
//                currentHP--;
//            }
//            else
//            {
//                UnityEditor.EditorApplication.isPlaying = false;
//            }
//        }
//    }
//    // Update is called once per frame
//}
