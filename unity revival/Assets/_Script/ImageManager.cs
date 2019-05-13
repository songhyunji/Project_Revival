using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
	[TextArea]
	public string[] inputname;
	public Sprite[] inputImage;
	public GameObject file_img, name, image;
	private Text name_text;
	private Image image_data;
    // Start is called before the first frame update
    void Start()
    {
		name_text = name.GetComponent<Text>();
		image_data = image.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void SNSPress(int i)
	{
		name_text.text = inputname[i];
		image_data.sprite = inputImage[i];
		file_img.SetActive(true);
	}

	public void ExitPress()
	{
		file_img.SetActive(false);
	}

}
