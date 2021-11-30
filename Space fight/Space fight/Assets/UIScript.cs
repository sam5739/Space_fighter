using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject InstructionPanel;
    public GameObject HealthBar;
    public GameObject timer;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void onClickPlay()
    {
        StartPanel.SetActive(false);
        HealthBar.SetActive(true);
        timer.SetActive(true);
        Time.timeScale = 1;
    }

    public void onClickInstruction()
    {
        StartPanel.SetActive(false);
        InstructionPanel.SetActive(true);

    }

    public void onClickBack()
    {
        StartPanel.SetActive(true);
        InstructionPanel.SetActive(false);
    }

    public void replay()
    {
        Scene Sc = SceneManager.GetActiveScene();
        SceneManager.LoadScene(Sc.name);
    }
}
