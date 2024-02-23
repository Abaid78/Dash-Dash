using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Text coinsText;
  public void CoinCountUpdateUI(int coins)
    {
        coinsText.text = coins.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
