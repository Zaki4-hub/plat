using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneswith : MonoBehaviour
{
	int levelUnLock; 
	public Button[] buttons;

	public void Start() 
	{
		levelUnLock = PlayerPrefs.GetInt("levels", 1); 

		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i].interactable = false;
		}

		for (int i = 0; i < levelUnLock; i++)
		{
			buttons[i].interactable = true;
		}
	}

	public void LoadLevel(int LevelIndex) 
	{
		SceneManager.LoadScene(LevelIndex);
	}

	public void DelAll()
	{
		PlayerPrefs.DeleteAll();
	}
}
