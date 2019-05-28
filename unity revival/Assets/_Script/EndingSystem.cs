using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingSystem : MonoBehaviour
{
	[TextArea]
	public string[] title = new string[3];
	[TextArea]
	public string[] contents = new string[3];
	public string date;

	private string _title;
	private string _contents;
	private string _date;
    // Start is called before the first frame update
    void Start()
    {
		_date = System.DateTime.Now.ToLongDateString() + System.DateTime.Now.ToLongTimeString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
