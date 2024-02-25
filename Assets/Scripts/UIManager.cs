using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject playersDashBord;
    public GameObject manueButtonsPanel;
    public Button dashBordButton;
    public Button pauseButton;
    public Text pauseBtnText;
    public Text coinsText;

    public void CoinCountUpdateUI(int coins)
    {
        coinsText.text = coins.ToString();
    }

    private void Start()
    {
        playersDashBord.SetActive(false);
        HideAndShowDashBordButton(false);
    }

    public void ClosePlayersDashBord()
    {
        playersDashBord.SetActive(false);
        pauseButton.interactable = true;
    }

    public void OpenPlayersDashBord()
    {
        playersDashBord.SetActive(true);
        pauseButton.interactable = false;
    }

    public void ManageUIOnPause(string text, bool isHideDashBordButton)
    {
        pauseButton.interactable = true;
        pauseBtnText.text = text;
        HideAndShowDashBordButton(isHideDashBordButton);
    }

    public void HideAndShowDashBordButton(bool isHide)
    {
        if (isHide)
        {
            dashBordButton.gameObject.SetActive(true);
        }
        else
        {
            dashBordButton.gameObject.SetActive(false);
        }
    }

    //show these buttuns are placed to the corner of screen
    public void ShowManuButtonsPanel()
    {
        manueButtonsPanel.SetActive(true);
        //Auto disable after some Time
        StartCoroutine(DisableAfterDelay(manueButtonsPanel, 3f));
    }

    private IEnumerator DisableAfterDelay(GameObject panelObject, float time)
    {
        yield return new WaitForSeconds(time);
        panelObject.SetActive(false);
    }
}