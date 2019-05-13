using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassengerManager : MonoBehaviour
{
	[TextArea]
	public string[] inputDate_msg, inputMemo_msg;
	public GameObject file_msg, date_msg, memo_msg;
	private Text date_text, memo_text;
    // Start is called before the first frame update
    void Start()
    {
		date_text = date_msg.GetComponent<Text>();
		memo_text = memo_msg.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void MassengerPress(int i)
	{
		date_text.text = inputDate_msg[i];
		memo_text.text = inputMemo_msg[i];
		file_msg.SetActive(true);
	}

	public void ExitPress()
	{
		file_msg.SetActive(false);
	}

}
