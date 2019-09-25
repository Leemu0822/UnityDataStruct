using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableExample : MonoBehaviour {
    Hashtable table = new Hashtable();

    // Use this for initialization
    void Start () {
        //往哈希表添加元素
        table.Add(1,10); 
        table.Add("pp",99); 
        table.Add('a',"66");

        //取值
        print(table["pp"]);
       
	}
	
	// Update is called once per frame
	void Update () {
	   
	}
}
