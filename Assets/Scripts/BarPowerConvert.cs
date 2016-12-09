using UnityEngine;
using System.Collections;
using System;

public class BarPowerConvert : MonoBehaviour{

	private BarFill bf;

	void Awake(){
	
		bf = GetComponent<BarFill> ();
	}

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown ("space"))
			print(FillConvert ());	
	}

	private int FillConvert (){
		
		float rawFill = bf.GetFill ();
		int intFill = (int)rawFill * 10;
		return intFill * 10;
	}
}
