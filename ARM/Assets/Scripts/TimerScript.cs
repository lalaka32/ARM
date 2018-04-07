
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    static public float timer = 25;
    static public bool switcher = true;
    public GameObject LoseMenu;
    public GameObject ImageTarget;
    public Text timerText;
    void timerOn()
    {
        if (switcher)
        {
            timer -= Time.deltaTime;
        }
    }

	void Update () {
        if (timer >0)
        {
            timerOn();
        }
        
        if (timer<0)
        {
            LoseMenu.active = true;
            ImageTarget.active = false;
            switcher = false;
            
        }
        string minutes = ((int)timer / 60).ToString();
        string seconsds = (timer % 60).ToString("f2");
        timerText.text = minutes + ":" + seconsds;
        
    }
}
