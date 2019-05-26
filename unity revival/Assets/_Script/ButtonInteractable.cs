using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInteractable : MonoBehaviour
{
    public Toggle small11, small12, small21, small22, small31, small32, small41, small42;
    public Button btn;

   
    void Start()
    {
        btn = GetComponent<Button>();
        small11 = GetComponent<Toggle>();
        small12 = GetComponent<Toggle>();
        small21 = GetComponent<Toggle>();
        small22 = GetComponent<Toggle>();
        small31 = GetComponent<Toggle>();
        small32 = GetComponent<Toggle>();
        small41 = GetComponent<Toggle>();
        small42 = GetComponent<Toggle>();
        btn.interactable = false;
    }

    
    void Update()
    {
        if ((small11.isOn || small12.isOn)&& (small21.isOn || small22.isOn) && (small31.isOn || small32.isOn)&& (small41.isOn || small42.isOn))
        {
            btn.interactable = true;
        }
        else
        {
            btn.interactable = false;
        }
    }
}
