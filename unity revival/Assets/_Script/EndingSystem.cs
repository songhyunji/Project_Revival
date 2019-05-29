using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingSystem : MonoBehaviour
{
	public Text date;
	public Text credit;
	public Sprite[] mailImg = new Sprite[3];
	public Fade fadeScript;

	private Image mail;
	private Color creditTextColor;
	private Button btn;

	public float animTime = 0.5f;         // Fade 애니메이션 재생 시간 (단위:초).  
	private Image fadeImage;            // UGUI의 Image컴포넌트 참조 변수.  
	private float time = 0f;            // Mathf.Lerp 메소드의 시간 값.  
	private bool isPlaying = false;

    // Start is called before the first frame update
    IEnumerator Start()
    {
		StartCoroutine(FadeScene_1());

		date.text = System.DateTime.Now.ToLongDateString() + " " + System.DateTime.Now.ToLongTimeString();
		mail = GetComponent<Image>();
		btn = this.gameObject.GetComponent<Button>();
		int x = PlayerPrefs.GetInt("Score");
		if (x >= 0 && x <= 3)	// bad ending
		{
			mail.sprite = mailImg[0];
		}
		else if (x >= 4 && x <= 7)	// normal ending
		{
			mail.sprite = mailImg[1];
		}
		else if (x >= 8)	// true ending
		{
			mail.sprite = mailImg[2];
		}

		yield return new WaitForSeconds(0.1f);
	}

	public void PressSceen()
	{
		btn.enabled = false;
		StartCoroutine(FadeScene_0());
	}

	IEnumerator FadeScene_0()
	{
		fadeScript.StartFadeAnim(0);
		yield return new WaitForSeconds(0.5f);
		StartCoroutine(CreditFade());
	}

	IEnumerator FadeScene_1()
	{
		fadeScript.StartFadeAnim(1);
		yield return new WaitForSeconds(0.5f);
	}

	IEnumerator CreditFade()
	{
		StartCoroutine(CreditFadeOut());
		yield return new WaitForSeconds(3);
		StartCoroutine(CreditFadeIn());
	}

	// Fade 애니메이션 메소드.  
	IEnumerator CreditFadeOut()
	{
		// 애니메이션 재생중. 
		isPlaying = true;

		// Text 컴포넌트의 색상 값 읽어오기.  
		Color color = credit.color;
		time = 0f;
		color.a = Mathf.Lerp(0f, 1f, time);

		while (color.a < 1f)
		{
			// 경과 시간 계산.  
			// 2초(animTime)동안 재생될 수 있도록 animTime으로 나누기.  
			time += Time.deltaTime / animTime;

			// 알파 값 계산.  
			color.a = Mathf.Lerp(0f, 1f, time);
			// 계산한 알파 값 다시 설정.  
			credit.color = color;

			yield return null;
		}

		// 애니메이션 재생 완료.  
		isPlaying = false;
	}

	// Fade 애니메이션 메소드.  
	IEnumerator CreditFadeIn()
	{
		// 애니메이션 재생중.  
		isPlaying = true;

		// Text 컴포넌트의 색상 값 읽어오기.  
		Color color = credit.color;
		time = 0f;
		color.a = Mathf.Lerp(1f, 0f, time);

		while (color.a > 0f)
		{
			// 경과 시간 계산.  
			// 2초(animTime)동안 재생될 수 있도록 animTime으로 나누기.  
			time += Time.deltaTime / animTime;

			// 알파 값 계산.  
			color.a = Mathf.Lerp(1f, 0f, time);
			// 계산한 알파 값 다시 설정.  
			credit.color = color;

			yield return null;
		}

		// 애니메이션 재생 완료.  
		isPlaying = false;
		SceneManager.LoadScene("Opening");
	}
}
