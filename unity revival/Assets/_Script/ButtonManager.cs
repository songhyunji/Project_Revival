using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
	public GameObject buttons;
	public GameObject massengerFiles;
	public GameObject snsFiles;
	public GameObject images;
	public GameObject exitBtn;
	public GameObject massengerPanel;
	public GameObject snsPanel;
	public GameObject imagePanel;

	public Local localScript;

	public string massengerName;
	public string snsName;
	public string gallaryName;

	public void MassengerBtnPress()
	{
		buttons.SetActive(false);
		massengerFiles.SetActive(true);
		exitBtn.SetActive(true);
		localScript._text += " > " + massengerName;
	}

	public void SNSBtnPress()
	{
		buttons.SetActive(false);
		snsFiles.SetActive(true);
		exitBtn.SetActive(true);
		localScript._text += " > " + snsName;
	}

	public void GalleryBtnPress()
	{
		buttons.SetActive(false);
		images.SetActive(true);
		exitBtn.SetActive(true);
		localScript._text += " > " + gallaryName;
	}

	public void ExitBtn()
	{
		buttons.SetActive(true);
		massengerFiles.SetActive(false);
		images.SetActive(false);
		snsFiles.SetActive(false);
		exitBtn.SetActive(false);
		localScript._text = "C: > Program files > Project Revival > OOO";
	}
}
