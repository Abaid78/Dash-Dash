using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UserInput : MonoBehaviour
{
    public InputField nameInputField;
    public InputField countryInputField;
  public void SaveUserInputData()
    {
        string name = CleanseString(nameInputField.text);
        string country = CleanseString(countryInputField.text);
        SaveData.SaveUserName(name);
        SaveData.SaveUserCountry(country);
    }
    string CleanseString(string inputString)
    {
        // Convert all characters to lowercase and then remove non-alphanumeric characters
        inputString = inputString.ToLower();
        return Regex.Replace(inputString, @"\s+|[^a-z0-9]", "");
    }
}
