using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Local : MonoBehaviour
{
	public string _text;
	private Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
		textComponent = GetComponent<Text>();
		_text = "C: > Program files > Project Revival > 차유정";
	}

    // Update is called once per frame
    void Update()
    {
		textComponent.text = _text;
    }
}
