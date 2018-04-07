
using UnityEngine;


public class beckTomenu : MonoBehaviour {

    public GameObject winMenu;
    public GameObject loseMenu;
    public GameObject ImageTarget;
    
    public void BackToMenu()
    {
        Application.LoadLevel(0);
        TimerScript.switcher = true;
        TimerScript.timer = 25;

    }
    public void RestartWinLvl()
    {
        winMenu.active = false;
        ImageTarget.active = true;
        TimerScript.switcher = true;
        TimerScript.timer = 25;
        
    }
    public void RestartLoseLvl()
    {
        loseMenu.active = false;
        ImageTarget.active = true;
        TimerScript.switcher = true;
        TimerScript.timer = 25;

    }
    public void NextLvl()
    {
        Application.LoadLevel(2);
    }
}
