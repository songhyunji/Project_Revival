using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonInteractable_1 : MonoBehaviour
{
	public GameObject[] small = new GameObject[8];
    public Button _btn;
	private Toggle[] _small = new Toggle[8];
	private int arrayLength;
	private bool returnvalue = false;

	void Start()
    {
        Button btn = _btn.GetComponent<Button>();
		for(int i = 0; i < small.Length; i++)
		{
			_small[i] = small[i].GetComponent<Toggle>();
		}
		arrayLength = small.Length;
        btn.interactable = false;
    }

    
    void Update()
    {
		if(Toggle_bool(arrayLength))
		{
			_btn.interactable = true;
		}
		else
		{
			_btn.interactable = false;
		}
    }

	private bool Toggle_bool(int i)
	{
		int k = (i / 2);    // i는 무조건 2의 배수, k는 1 이상의 양수
		List<bool> list = new List<bool>();
		for (int j = 0; j < k; j++)
		{
			list.Add(_small[2 * j].isOn || _small[2 * j + 1].isOn);
		}
		if (!list.Contains(false))	// 리스트 안에 false가 없으면
		{
			return true;
		}
		else	// 리스트 안에 false가 있으면
		{
			return false;
		}
	}
}


