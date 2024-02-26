using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class FlagDisplay : MonoBehaviour
{
    public Image flagImage;
    public string countryName; 
    private readonly string flagsFolderPath = "Flags/"; // Folder path where flag sprites are stored

    private void Start()
    {
        string cleanedCountryName = CleanseString(countryName);
        
        // Load the flag sprite based on the cleaned country name
        LoadFlag(cleanedCountryName);
    }

    // Method to remove spaces and symbols from a string
    string CleanseString(string inputString)
    {
        return Regex.Replace(inputString, @"\s+|[^a-zA-Z0-9]", "");
    }

    // Method to load the flag sprite based on the entered country name
    public void LoadFlag(string countryName)
    {
        // Load the flag sprite based on the country name
        Sprite flagSprite = Resources.Load<Sprite>(flagsFolderPath + countryName);

        // If the sprite is found, assign it to the image component
        if (flagSprite != null)
        {
            flagImage.sprite = flagSprite;
        }
        else
        {
            // If the sprite is not found, assign a default flag sprite or handle it as needed
            Debug.LogWarning("Flag for " + countryName + " not found. Default flag assigned.");
        }
    }
}
