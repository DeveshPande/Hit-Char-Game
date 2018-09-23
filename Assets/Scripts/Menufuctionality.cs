using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menufuctionality : MonoBehaviour {

	//for getting the menu option available
	public enum Mainstate {MainMenu,Setting,Backgroundcolorchange};
	public enum background{Red,Green,Blue};
	public Mainstate Currentstate;
	public background backgroundcolor;
	//for getting the menu gameobject
	public GameObject mainmenu;
	public GameObject settingmenu;
	public GameObject backgroundchangemenu;
	public GameObject backgroundblue;
	public GameObject backgroundRed;
	public GameObject backgroundgreen;

	void Awake()
	{
		Currentstate = Mainstate.MainMenu;
		backgroundcolor = background.Blue;
		PlayerPrefManager.setbackground ("Blue");
	}
	void Update()
	{
		switch (Currentstate)
		{
		case Mainstate.MainMenu:
			mainmenu.SetActive (true);
			settingmenu.SetActive (false);
			backgroundchangemenu.SetActive (false);
			break;
		case Mainstate.Backgroundcolorchange:
			mainmenu.SetActive (false);
			settingmenu.SetActive (false);
			backgroundchangemenu.SetActive (true);
			break;
		case Mainstate.Setting:
			mainmenu.SetActive (false);
			settingmenu.SetActive (true);
			backgroundchangemenu.SetActive (false);
			break;
		}
		switch (backgroundcolor)
		{
		case background.Blue:
			backgroundblue.SetActive (true);
			backgroundgreen.SetActive (false);
			backgroundRed.SetActive (false);
			break;
		case background.Green:
			backgroundblue.SetActive (false);
			backgroundgreen.SetActive (true);
			backgroundRed.SetActive (false);
			break;
		case background.Red:
			backgroundblue.SetActive (false);
			backgroundgreen.SetActive (false);
			backgroundRed.SetActive (true);
			break;
		}

	}

	//all the below function is use for changing state
	public void playButton()
	{
		//for staring the game
		//Debug.Log("game is start");
		SceneManager.LoadScene ("Scane2");
	}

	public void setting()
	{
		Currentstate = Mainstate.Setting;
	}

	public void gotomainmenu()
	{
		Currentstate = Mainstate.MainMenu;
	}

	public void ChangeBackground()
	{
		Currentstate = Mainstate.Backgroundcolorchange;
	}
	public void BackgroundRed()
	{
		backgroundcolor = background.Red;
		PlayerPrefManager.setbackground ("Red");
	}
	public void BackgroundGreen()
	{
		backgroundcolor = background.Green;
		PlayerPrefManager.setbackground ("Green");
	}
	public void BackgroundBlue()
	{
		backgroundcolor = background.Blue;
		PlayerPrefManager.setbackground ("Blue");
	}
}
