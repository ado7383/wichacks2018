using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class updateText : MonoBehaviour {
	TextMeshPro text;
	string[] dialogue = new string[4];
	int counter = -1;

	IEnumerator writeText(){
		counter ++;
		for(int i = 0; i <=dialogue[counter].Length; i++){
			yield return new WaitForSeconds(0.05F);
			text.SetText(dialogue[counter].Substring(0,i));
			Debug.Log("shit");
		}
	}	
	
	void Start(){
		
       	dialogue[0] = "Sample Text";
	dialogue[1] = "lorem ipsum";
	dialogue[2] = "fjkdflakj";
	dialogue[3] = "what do you mean";	
	text = GameObject.Find("x").GetComponent<TextMeshPro>();
	}
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0)){
		if(counter == dialogue.Length-1){
			SceneManager.LoadScene("Scene1");
		}else{	
		StartCoroutine("writeText");
		}
	}
}
}
