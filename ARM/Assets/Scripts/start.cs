
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
    public GameObject info;
    public GameObject globalMenu;
    public GameObject selectLvl;
    public void SelectLvlMenu()
    {
        globalMenu.active = false;
        selectLvl.active = true;
    }
    public void SelectLvl1()
    {
        SceneManager.LoadScene(1);
    }
    public void SelectLvl2()
    {
        SceneManager.LoadScene(2);
    }
    public void ExitSelectLvl()
    {
        globalMenu.active = true;
        selectLvl.active = false;
    }
    public void Info()
    {
        info.SetActive(!info.activeSelf);
    }
    public void ExitInfo()
    {
        info.SetActive(!info.activeSelf);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
