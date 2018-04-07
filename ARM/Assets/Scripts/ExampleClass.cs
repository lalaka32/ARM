
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject imageTarget;
    
    void OnTriggerEnter(Collider other)
    {
            TimerScript.switcher = false;
            imageTarget.active = false;
            winMenu.active = true;
    }
}