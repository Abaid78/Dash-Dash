using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    private bool isPause = false;

    private void Start()
    {
        HasUserEnteredData();
    }

    public void PauseGame()
    {
        if (isPause == false)
        {
            uiManager.UpdatePauseUI("Resume", true);
            StartGame();
            isPause = true;
        }
        else
        {
            uiManager.UpdatePauseUI("Pause", false);
            StopGame();
            isPause = false;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CancelQuit()
    {
        uiManager.HideQuitPanel();
    }
    public void StartGame()
    {
        Time.timeScale = 1;
    }
    public void StopGame()
    {
        Time.timeScale = 0;
    }
    public void HasUserEnteredData()
    {
        bool hasEnteredData = SaveData.HasUserEnteredData();
        if (hasEnteredData==true)
        {
            // Display the result using the UIManager
            uiManager.DisplayUserInputs(!hasEnteredData);
        }
        else
        {
            uiManager.DisplayUserInputs(true);
            StopGame();
        }
    }
}