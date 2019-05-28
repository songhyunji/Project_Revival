using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningBtnManager : MonoBehaviour
{
	public Fade fadeScript;

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
}
