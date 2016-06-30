using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PiontsCount : MonoBehaviour {

    public Text countText;
    public Text crystalText;
    public Text winText;
    public Crystal krysztal;
    public MenuBehavior menuShow;
    public MenuMenager menuMenager;

    public int highScore = 0;

    public string highScoreKey = "HighScore";


    private GameObject finish;
    private int count;
    private int crystal;



    void Start()
    {

        count = 0;
        setCountText();
        winText.text = "";
        crystal = LeaveCrystal();
        setCrystalText();

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);

    }




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            crystal = LeaveCrystal();
            setCountText();
            setCrystalText();

            
            if(crystal == 1)
            {                
                finish = GameObject.Find("Finish");
                finish.SetActive(false);
                
            }

        }

        if (other.gameObject.CompareTag("Wall"))
        {
            count = count - 2;
            setCountText();
            
        }

    }




    int LeaveCrystal()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();

        return crystals.Length;

    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    void setCrystalText()
    {
        crystalText.text = "Crystals: " + crystal;

        if (crystal == 0)
        {
            winText.text = "Congratulation!!!" + "\n" + "Score: " + count.ToString();
            
            menuMenager.ShowMenu(menuShow);


            if (count > highScore)
            {
                PlayerPrefs.SetInt(highScoreKey, count);
                PlayerPrefs.Save();
            }


        }

    }
}
