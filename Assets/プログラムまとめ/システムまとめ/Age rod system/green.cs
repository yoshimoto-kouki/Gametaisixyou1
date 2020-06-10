//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class green : MonoBehaviour
//{
//    float greenHP;
//    // Start is called before the first frame update
//    void Start()
//    {
//    }

//    private void OnTriggerStay2D(Collider2D collider)
//    {
//        greenHP = orange.GetorangeHP();
//        if (collider.gameObject.layer == LayerMask.NameToLayer("agebar"))
//        {

//            if (0 <= greenHP)
//            {
//                greenHP = greenHP + 0.1f;
//            }
//            else
//            {
//                UnityEditor.EditorApplication.isPlaying = false;
//            }
//        }
//    }
//}
