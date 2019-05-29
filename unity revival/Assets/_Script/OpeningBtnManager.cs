using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningBtnManager : MonoBehaviour
{
	public Fade fadeScript;

	IEnumerator Start()
	{
		PlayerPrefs.DeleteAll();
		StartCoroutine(FadeScene_1());
		yield return new WaitForSeconds(0.1f);
	}

	public void LoginBtnPress()
	{
		StartCoroutine(FadeScene());
	}

	public void ExitBtnPress()
	{
		Application.Quit();
	}

	IEnumerator FadeScene()
	{
		fadeScript.StartFadeAnim(0);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene("Main Computer");
	}

	IEnumerator FadeScene_1()
	{
		fadeScript.StartFadeAnim(1);
		yield return new WaitForSeconds(0.5f);
	}
}
