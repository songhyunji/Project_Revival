using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassengerManager : MonoBehaviour
{
	[TextArea]
	public string[] inputDate, inputMemoText;
	public GameObject file, date, memo;
	private Text date_text, memo_text;
    // Start is called before the first frame update
    void Start()
    {
		date_text = date.GetComponent<Text>();
		memo_text = memo.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void MassengerPress(int i)
	{
		date_text.text = inputDate[i];
		memo_text.text = inputMemoText[i];
		file.SetActive(true);
	}

	public void ExitPress()
	{
		file.SetActive(false);
	}

}
