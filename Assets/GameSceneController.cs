using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    public GameObject HelpPanel;
    public GameObject BackPanel;
    // Start is called before the first frame update
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Help()
    {
        HelpPanel.SetActive(true);
    }
    public void BackButton()
    {
        HelpPanel.SetActive(false);
        BackPanel.SetActive(true);
    }


}
