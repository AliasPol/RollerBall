using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour {

    public MenuBehavior menuShow;
    public MenuMenager menuMenager;

    private int a = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuMenager.ShowMenu(menuShow);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {

            if(a == 1)
            {
                Time.timeScale = 0;
                a = 0;
            }
            else if(a == 0)
            {
                Time.timeScale = 1;
                a = 1;
            }
        }
	}


    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Repeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
