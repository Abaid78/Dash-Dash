using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject playersDashBoard;
    public Animator dashBoardAnimator;
    public GameObject quitPanel;
    public GameObject userInputPanel;
    public Button dashBoardButton;
    public Button showQuitPanelButton;
    public Button pauseButton;
    public Text pauseButtonText;
    public Text coinsText;

    private void Start()
    {
        InitializeUI();
    }

    private void InitializeUI()
    {
        playersDashBoard.SetActive(false);
        quitPanel.SetActive(false);
        ToggleButtonInteractability(dashBoardButton, false);
        ToggleButtonInteractability(showQuitPanelButton, false);
        
    }

    // Update UI when game is paused or resumed
    public void UpdatePauseUI(string buttonText, bool interactable)
    {
        pauseButtonText.text = buttonText;
        ToggleButtonInteractability(dashBoardButton, interactable);
        ToggleButtonInteractability(showQuitPanelButton, interactable);
    }

    // Toggle interactability of a button
    private void ToggleButtonInteractability(Button button, bool interactable)
    {
        if (button != null)
        {
            button.interactable = interactable;
        }
    }

    // Show the quit panel
    public void ShowQuitPanel()
    {
        quitPanel.SetActive(true);
        ToggleButtonInteractability(dashBoardButton, false);
        ToggleButtonInteractability(pauseButton, false);
    }

    // Hide the quit panel
    public void HideQuitPanel()
    {
        quitPanel.SetActive(false);
        ToggleButtonInteractability(dashBoardButton, true);
        ToggleButtonInteractability(pauseButton, true);
    }

    // Update the coin count displayed in the UI
    public void UpdateCoinCountUI(int coins)
    {
        coinsText.text = coins.ToString();
    }

    // Open the player's dashboard
    public void OpenPlayersDashboard()
    {
        playersDashBoard.SetActive(true);
        ToggleButtonInteractability(pauseButton, false);
        ToggleButtonInteractability(showQuitPanelButton, false);
    }

    // Close the player's dashboard
    public void ClosePlayersDashboard()
    {
        dashBoardAnimator.SetTrigger("CloseDashboard");
        ToggleButtonInteractability(pauseButton, true);
        ToggleButtonInteractability(showQuitPanelButton, true);
    }

    public void DisplayUserInputs(bool isDisplay)
    {
        if (isDisplay)
        {
           
            userInputPanel.SetActive(true);
        }
        else
        {
            userInputPanel.SetActive(false);
        }
    }
}