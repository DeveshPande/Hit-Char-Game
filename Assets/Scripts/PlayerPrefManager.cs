using UnityEngine;
using System.Collections;

public static class PlayerPrefManager {

	public static string[] st=new string[30];
    public static int len=0;
	public static int ind=0;
	public static int x=20;
	public static int stringindex=0;
	public static string bg;
	public static int t=0;
	public static int s=0;

	public static int GetScore() {
		return s;
	}

	public static void SetScore(int score) {
		s =s+ score;
	}

	public static int GetHighscore() {
		if (PlayerPrefs.HasKey("Highscore")) {
			return PlayerPrefs.GetInt("Highscore");
		} else {
			return 0;
		}
	}

	public static void SetHighscore(int highscore) {
		PlayerPrefs.SetInt("Highscore",highscore);
	}


	// story the current player state info into PlayerPrefs
	public static void SavePlayerState(int score, int highScore) {
		// save currentscore and lives to PlayerPrefs for moving to next level
		PlayerPrefs.SetInt("Score",score);
		PlayerPrefs.SetInt("Highscore",highScore);
	}

	// reset stored player state and variables back to defaults
	public static void ResetPlayerState(int startLives, bool resetHighscore) {
		Debug.Log ("Player State reset.");
		PlayerPrefs.SetInt("Lives",startLives);
		PlayerPrefs.SetInt("Score", 0);

		if (resetHighscore)
			PlayerPrefs.SetInt("Highscore", 0);
	}

	// output the defined Player Prefs to the console
	public static void ShowPlayerPrefs() {
		// store the PlayerPref keys to output to the console
		string[] values = {"Score","Highscore","Lives"};

		// loop over the values and output to the console
		foreach(string value in values) {
			if (PlayerPrefs.HasKey(value)) {
				Debug.Log (value+" = "+PlayerPrefs.GetInt(value));
			} else {
				Debug.Log (value+" is not set.");
			}
		}
	}
	public static void getstring()
	{
		st [0] = "ABC";
		st [1] = "PLAY";
		st [2] = "DOG";
		st [3] = "CAT";
		st [4] = "RAT";
		st [5] = "PIG";
		st [6] = "GOT";
		st [7] = "LAND";
		st [8] = "CAR";
		st [9] = "WIRE";
		st [10] = "FIRE";
		st [11] = "GAME";
		st [12] = "FAME";
		st [13] = "NAME";
		st [14] = "BIRD";
		st [15] = "SHE";
		st [16] = "THEY";
		st [17] = "FEET";
		st [18] = "BEET";
		st [19] = "SING";
		st [20] = "SONG";
		st [21] = "DEATH";

	}
	public static void setvalue(int mainstringindex,int stilength,int l){
		ind = mainstringindex;
		len = stilength;
		stringindex = l;
	}
	public static int getlength()  // getting the lenght of st[i]
	{
		return len;
	}
	public static int getstringindex() //get the stringindex of s[i][j]
	{
		return stringindex;
	}
	public static int getind() //get the index of st
	{
		return ind;
	}
	public static void setbackground(string color)
	{
		bg = color;
	}
	public static string getbackground()
	{
		return bg;
	}
	public static void SetUi(int value)
	{
		t = value;
	}
	public static int GetUi()
	{
		return t; 
	}

}

