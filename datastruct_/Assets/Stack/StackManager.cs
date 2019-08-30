using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StackManager : MonoBehaviour
{
    [SerializeField] private Button delete_btn;
    [SerializeField] private GameObject ball;
    private Stack<GameObject>myStack=new Stack<GameObject>();
	// Use this for initialization
	void Start () {
	    for (int i = 0; i < 5; i++)
	    {
	        GameObject go = Instantiate(ball, new Vector3(0, i, 0), gameObject.transform.rotation);
            myStack.Push(go);
	    }
        delete_btn.onClick.AddListener(() =>
        {
            if (myStack.Count > 0)
            {
                GameObject top_go = myStack.Pop();
                Destroy(top_go);
            }
           
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
