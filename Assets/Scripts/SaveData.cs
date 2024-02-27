using UnityEngine;

public class SaveData
{
    public static void SaveCoins(int coins)
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.Save();
    }public static int GetCoins()
    {
       return PlayerPrefs.GetInt("Coins");
        
    }
    public  static bool HasUserEnteredData()
    {
        // Retrieve the value from PlayerPrefs
        return PlayerPrefs.HasKey("DataEntered") && PlayerPrefs.GetInt("DataEntered") == 1;
    }

    // Function to mark that the user has entered data
    public static void MarkDataAsEntered()
    {
        // Store a boolean value in PlayerPrefs
        PlayerPrefs.SetInt("DataEntered", 1);
        PlayerPrefs.Save(); // Ensure changes are saved immediately
    }

    public static void SaveUserName(string name)
    {
        PlayerPrefs.SetString("Name", name);
        PlayerPrefs.Save();
    } 
    public static string GetUserName()
    {
       return PlayerPrefs.GetString("Name");
       
    }

    public static void SaveUserCountry(string country)
    {
        PlayerPrefs.SetString("Country", country);
        PlayerPrefs.Save();
    }

    public static string GetUserCountry()
    {
        return PlayerPrefs.GetString("Country");
    }
}