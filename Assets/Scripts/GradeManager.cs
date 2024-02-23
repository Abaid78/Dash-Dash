using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GradeManager : MonoBehaviour
{
    // Store scores of all players
    public List<int> playerScores = new List<int>();
    // Store UI Text components for displaying scores
    public List<Text> scoreTexts = new List<Text>();
    // Store RectTransforms for all players
    public List<RectTransform> playerTransforms = new List<RectTransform>();

    void Start()
    {
        // Update UI with current scores
        UpdateUIText();
        // Sort player scores and update positions accordingly
        SortPlayers();
    }

    // Update UI with current scores
    void UpdateUIText()
    {
        for (int i = 0; i < playerScores.Count; i++)
        {
            // Update the text of each player's score display
            scoreTexts[i].text = "Player " + (i + 1) + ": " + playerScores[i].ToString();
        }
    }

    // Sort players based on their scores
    void SortPlayers()
    {
        // Create a sorted copy of the player scores
        List<int> sortedScores = new List<int>(playerScores);
        // Sort the scores in descending order
        sortedScores.Sort();
        sortedScores.Reverse();

        // Rearrange player positions based on sorted scores
        for (int i = 0; i < playerScores.Count; i++)
        {
            // Find the index of the player with the current score in the original list
            int currentIndex = playerScores.IndexOf(sortedScores[i]);
            if (currentIndex != i)
            {
                // Swap the positions of the corresponding RectTransforms
                SwapPositions(playerTransforms[currentIndex], playerTransforms[i]);
                // Update the playerTransforms list to reflect the new positions
                playerTransforms[currentIndex] = playerTransforms[i];
                playerTransforms[i] = playerTransforms[currentIndex];
            }
        }
    }

    // Swap anchored positions of player UI elements
    void SwapPositions(RectTransform player1, RectTransform player2)
    {
        Vector3 tempPosition = player1.anchoredPosition;
        player1.anchoredPosition = player2.anchoredPosition;
        player2.anchoredPosition = tempPosition;
    }
}
