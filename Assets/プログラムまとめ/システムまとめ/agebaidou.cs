using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agebaidou : MonoBehaviour
{
    public static float currentHP = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("yellow"))
        {
            Debug.Log("yellow" + currentHP);
            if (0 < currentHP)
            {
                currentHP = currentHP - 0.1f;
            }
        }
        if (collider.gameObject.layer == LayerMask.NameToLayer("orange"))
        {
            Debug.Log("orange" + currentHP);
            if (0 < currentHP)
            {
                currentHP = currentHP - 0.2f;
            }
        }
        if (collider.gameObject.layer == LayerMask.NameToLayer("green"))
        {
            Debug.Log("green" + currentHP);
            if (1 < currentHP)
            {
                currentHP = currentHP + 0.1f;
            }
        }
        if (collider.gameObject.layer == LayerMask.NameToLayer("red"))
        {
            Debug.Log("red" + currentHP);
            if (0 < currentHP)
            {
                currentHP = currentHP - 0.4f;
            }
        }
    }
            // Update is called once per frame
            void Update()
            {
                Transform myTransform = this.transform;

                Vector3 pos = myTransform.position;
                pos.x += 0.003f;
                myTransform.position = pos;
                if (Input.GetKeyDown(KeyCode.A))
                {
                    pos.x += -0.06f;
                    myTransform.position = pos;
                }
            }
    public static float GetcurrentHP()
    {
        return currentHP;
    }
        }
