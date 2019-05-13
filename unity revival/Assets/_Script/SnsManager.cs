using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SNSManager : MonoBehaviour
{
	[TextArea]
	public string[] inputDate_sns, inputMemo_sns;
	public GameObject file_sns, date_sns, memo_sns;
	private Text date_text, memo_text;
    // Start is called before the first frame update
    void Start()
    {
		date_text = date_sns.GetComponent<Text>();
		memo_text = memo_sns.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void SNSPress(int i)
	{
		date_text.text = inputDate_sns[i];
		memo_text.text = inputMemo_sns[i];
		file_sns.SetActive(true);
	}

	public void ExitPress()
	{
		file_sns.SetActive(false);
	}

}
