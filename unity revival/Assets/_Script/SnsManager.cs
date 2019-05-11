using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnsManager : MonoBehaviour
{
	public Text dateText;
	public Text memoText;

	private string date;
	private string menmo;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void ExitBtnPress()
	{
		this.gameObject.SetActive(false);
	}

	public void FirstMemo()
	{

	}
}
