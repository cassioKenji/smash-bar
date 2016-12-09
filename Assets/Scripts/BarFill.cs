using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarFill : MonoBehaviour {
	[SerializeField]
	private float fillAmount;

	[SerializeField]
	private Image content;

	void Start () {

	}

	void Update () {
		if (Input.GetKeyDown ("space"))
			FillIncrease ();
		
		UpdateBar ();
		FillDecrease ();
	}

	private void UpdateBar(){
		content.fillAmount = fillAmount;
	}

	private void FillIncrease(){
		if(fillAmount < 1.0f)
			fillAmount += 0.1f;
	}
	private void FillDecrease(){
		if(fillAmount > 0f)
			fillAmount -= 0.1f/0.5f * Time.deltaTime;
	}
	public float GetFill(){
		float fill = content.fillAmount;
		return fill;
	}
}
