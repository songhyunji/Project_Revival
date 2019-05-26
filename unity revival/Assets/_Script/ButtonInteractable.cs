using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInteractable : MonoBehaviour
{
    public Toggle _small11, _small12, _small21, _small22, _small31, _small32, _small41, _small42;
    public Button _btn;

   
    void Start()
    {
        Button btn = _btn.GetComponent<Button>();
        Toggle small11 = _small11.GetComponent<Toggle>();
        Toggle small12 = _small12.GetComponent<Toggle>();
        Toggle small21 = _small21.GetComponent<Toggle>();
        Toggle small22 = _small22.GetComponent<Toggle>();
        Toggle small31 = _small31.GetComponent<Toggle>();
        Toggle small32 = _small32.GetComponent<Toggle>();
        Toggle small41 = _small41.GetComponent<Toggle>();
        Toggle small42 = _small42.GetComponent<Toggle>();
        btn.interactable = false;
    }

    
    void Update()
    {
        if (_small31 == null && _small32 == null && _small41 == null && _small42 == null)
        {

            if (_small21 == null && _small22 == null)
            {
                if (_small11.isOn || _small12.isOn)
                {
                    _btn.interactable = true;
                }
                else
                {
                    _btn.interactable = false;
                }
            }
            else
            {
                if ((_small11.isOn || _small12.isOn) && (_small21.isOn || _small22.isOn))
                {
                    _btn.interactable = true;
                }
                else
                {
                    _btn.interactable = false;
                }
            }
        }
        
        else
        {
            if ((_small11.isOn || _small12.isOn) && (_small21.isOn || _small22.isOn) && (_small31.isOn || _small32.isOn) && (_small41.isOn || _small42.isOn))
            {

                _btn.interactable = true;
            }
            else
            {
                _btn.interactable = false;
            }
        }
    }
}
