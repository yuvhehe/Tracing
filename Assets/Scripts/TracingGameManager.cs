using UnityEngine;
using UnityEngine.UI;

public class TracingGameManager : MonoBehaviour
{
    public Sprite[] letterSprites;
    public Image letterImage;
    private int currentLetterIndex = 0;

    void Start()
    {
        // Show the first letter when the game starts
        letterImage.sprite = letterSprites[currentLetterIndex];
    }

    public void NextLetter()
    {
        currentLetterIndex++;
        if (currentLetterIndex >= letterSprites.Length)
            currentLetterIndex = 0;

        letterImage.sprite = letterSprites[currentLetterIndex];
    }
}
