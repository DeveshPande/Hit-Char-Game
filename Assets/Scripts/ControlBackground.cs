using UnityEngine;
using System.Collections;

public class ControlBackground : MonoBehaviour {

	public enum Background{Red,Green,Blue};
	public Background Backgroundcolor;
	//for getting the menu gameobject
	[HideInInspector] public string Sce;
	public GameObject MaincamRed;
	public GameObject MaincamBlue;
	public GameObject MaincamGreen;
	public GameObject FloorBlue;
	public GameObject FloorRed;
	public GameObject FloorGreen;
	public GameObject BaseBlue;
	public GameObject BaseRed;
	public GameObject BaseGreen;

	void Awake()
	{
		Sce=PlayerPrefManager.getbackground ();
		if(Sce=="Blue")
		    Backgroundcolor = Background.Blue;
		if (Sce == "Green")
			Backgroundcolor = Background.Green;
		if (Sce == "Red")
			Backgroundcolor = Background.Red;

		Debug.Log (Sce);
	}
	void Update()
	{
		switch (Backgroundcolor)
		{
		case Background.Blue:
			MaincamBlue.SetActive (true);
			FloorBlue.SetActive (true);
		    BaseBlue.SetActive (true);
			MaincamGreen.SetActive (false);
			FloorGreen.SetActive (false);
			BaseGreen.SetActive (false);
			MaincamRed.SetActive (false);
			FloorRed.SetActive (false);
			BaseRed.SetActive (false);
			break;
		case Background.Green:
			MaincamBlue.SetActive (false);
			FloorBlue.SetActive (false);
			BaseBlue.SetActive (false);
			MaincamGreen.SetActive (true);
			FloorGreen.SetActive (true);
			BaseGreen.SetActive (true);
			MaincamRed.SetActive (false);
			FloorRed.SetActive (false);
			BaseRed.SetActive (false);
			break;
		case Background.Red:
			MaincamBlue.SetActive (false);
			FloorBlue.SetActive (false);
			BaseBlue.SetActive (false);
			MaincamGreen.SetActive (false);
			FloorGreen.SetActive (false);
			BaseGreen.SetActive (false);
			MaincamRed.SetActive (true);
			FloorRed.SetActive (true);
			BaseRed.SetActive (true);
			break;
		}
}
}