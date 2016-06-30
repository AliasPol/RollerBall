using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour {

    public Text winText;
    public Crystal crystal;

    public MenuBehavior menuShow;
    public MenuMenager menuMenager;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(LeaveCrystal() == 0)
        {
            Win();
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

            winText.text = "Congratulation" + "\n" + "You Lose!!";

            menuMenager.ShowMenu(menuShow);

        }
    }

    int LeaveCrystal()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();

        return crystals.Length;

    }
    public void Win()
    {
        this.gameObject.SetActive(false);
    }
}
