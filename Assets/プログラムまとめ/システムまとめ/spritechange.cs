using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spritechange : MonoBehaviour
{
    // Start is called before the first frame update
          private Image m_Image;

          public Sprite[] m_Sprite;

          bool Change;

    void Start()
    {
        Change = false;
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Change)
            {
                m_Image.sprite = m_Sprite[0];
                Change = false;
            }
            else
            {
                m_Image.sprite = m_Sprite[1];
                Change = true; 
            }
        }
    }
}
