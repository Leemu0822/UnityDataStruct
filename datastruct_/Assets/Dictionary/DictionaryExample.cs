using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DictionaryExample : MonoBehaviour
{
    [SerializeField] private InputField En_input;

    [SerializeField] private Button search_btn;

    [SerializeField] private Text cn_text;

    private Dictionary<string,string>EnglishDict=new Dictionary<string, string>();
	// Use this for initialization
	void Start () {
		EnglishDict.Add("below","在下面");
        EnglishDict.Add("expert","专家");
	    EnglishDict.Add("garnered","囊括");
        search_btn.onClick.AddListener(() =>
        {
            if (EnglishDict.ContainsKey(En_input.text))
            {
                cn_text.text = EnglishDict[En_input.text];
            }
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
