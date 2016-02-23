using UnityEngine;
using System.Collections;

public class AnimLum1 : MonoBehaviour {

	public Transform lum1;

	public void Start()
	{
		//GetComponent<Renderer>().enabled = false;
	}

	public void OnTriggerEnter(Collider col)
	{
		lum1.GetComponent<Animator>().SetBool("Go", true);
	}

	public void OnTriggerExit(Collider col)
	{
		lum1.GetComponent<Animator>().SetBool("Go", false);
	}
}
