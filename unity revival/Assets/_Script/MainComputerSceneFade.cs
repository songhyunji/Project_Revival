using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainComputerSceneFade : MonoBehaviour
{
	public Fade fadeScript;

	// Start is called before the first frame update
	IEnumerator Start()
    {
		fadeScript.StartFadeAnim(1);
		yield return new WaitForSeconds(1f);
	}
}
