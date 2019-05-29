using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingImage : MonoBehaviour
{
    public GameObject mail;
    public GameObject badending;
    public GameObject normalending;
    public GameObject trueending;
    public Fade fadeScript;
    public GameObject endingclickBtn;

    void Update()
    {
        endingclickBtn.SetActive(false);
        

        SceneManager.LoadScene("Mail System");

        int x = 2;
        if (x >= 0 && x <= 3)
        {
           badending.SetActive(true);
           normalending.SetActive(false);
           trueending.SetActive(false);

            endingclickBtn.SetActive(true);
            { SceneManager.LoadScene("Opening"); }
           
        }

        if (x >= 4 && x <= 7)
        {
            badending.SetActive(false);
            normalending.SetActive(true);
            trueending.SetActive(false);

             endingclickBtn.SetActive(true);
             { SceneManager.LoadScene("Opening"); }
        }

        if (x >= 8)
        {
            badending.SetActive(false);
            normalending.SetActive(false);
            trueending.SetActive(true);

             endingclickBtn.SetActive(true);
             { SceneManager.LoadScene("Opening"); }
        }
        
    }

    
}