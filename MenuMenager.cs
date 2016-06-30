using UnityEngine;
using System.Collections;

public class MenuMenager : MonoBehaviour {


    public MenuBehavior CurrentMenu;

	// Use this for initialization
	void Start () {
        if(CurrentMenu != null)
        {
            ShowMenu(CurrentMenu);
        }
        
	}
	

    public void ShowMenu(MenuBehavior menu)
    {
        if(CurrentMenu != null)
        {
            CurrentMenu.IsOpen = false;
        }

        CurrentMenu = menu;
        CurrentMenu.IsOpen = true;
    }
}
