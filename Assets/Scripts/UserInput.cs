using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UserInput : MonoBehaviour
{
    public InputField nameInputField;
    public InputField countryInputField;
    public UIManager uiManager;
    public GameManager gameManager;
  public void SaveUserInputData()
    {
        if(nameInputField.text!="" && countryInputField.text != "")
        {
            string name = nameInputField.text;
            string country = CleanseString(countryInputField.text);
            SaveData.SaveUserName(name);
            SaveData.SaveUserCountry(country);
            SaveData.MarkDataAsEntered();
            uiManager.DisplayUserInputs(false);
            gameManager.StartGame();
        }
       
    }
    string CleanseString(string inputString)
    {
        // Convert all characters to lowercase and then remove non-alphanumeric characters
        inputString = inputString.ToLower();
        return Regex.Replace(inputString, @"\s+|[^a-z0-9]", "");
    }
}
