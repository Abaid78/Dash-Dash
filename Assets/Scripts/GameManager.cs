using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    private bool isPause = false;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void PauseGame()
    {
        if (isPause == false)
        {
            uiManager.ManageUIOnPause("Resume", true);
            Time.timeScale = 0;
            isPause = true;
        }
        else
        {
            uiManager.ManageUIOnPause("Pause", false);
            Time.timeScale = 1;

            isPause = false;
        }
    }

    public void ResumeGame()
    {
    }
}