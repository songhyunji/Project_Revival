using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour
{
	public Toggle[] answer = new Toggle[8];
	public Fade fadeScript;

	public void PressLastBtn()
	{
		Score();
	}

	IEnumerator FadeScene()
	{
		fadeScript.StartFadeAnim(0);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene("Ending");
	}

	private void Score()
	{
		List<bool> list = new List<bool>();
		int totalscore = 0;

		for (int i = 0; i < 8; i++)
		{
			list.Add(answer[i].isOn);
		}

		foreach (bool ans in list)
		{
			if (ans == true)
			{
				totalscore++;
			}
		}
		Debug.Log(totalscore);
		PlayerPrefs.SetInt("Score", totalscore);

		StartCoroutine(FadeScene());
	}
}
