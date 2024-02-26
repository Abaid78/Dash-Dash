using UnityEngine;
using UnityEngine.UI;
public class DisplayUserInputs : MonoBehaviour
{
    public Image flagImage;
    public Text playerNameText;
    private readonly string flagsFolderPath = "Flags/";

    private void Start()
    {
        // Load the flag sprite based on the cleaned country name
        LoadFlag(SaveData.GetUserCountry());
        LoadUserName(SaveData.GetUserName());
    }

    void LoadUserName(string name)
    {
        playerNameText.text = name;
    }

    // Method to load the flag sprite based on the entered country name
    void LoadFlag(string countryName)
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
