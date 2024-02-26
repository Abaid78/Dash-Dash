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