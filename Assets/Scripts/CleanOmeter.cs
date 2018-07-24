using UnityEngine;
using UnityEngine.UI;

public class CleanOmeter : MonoBehaviour
{
    private Text amountClean;
    private float initialDirt;
    private GameObject cleanIndicator;
    private GameObject gameOver;

    void Start()
    {
        amountClean = GetComponent<Text>();
        initialDirt = GetInteractables();
        cleanIndicator = GameObject.Find("Clean");
        gameOver = GameObject.Find("GameOver");
        gameOver.SetActive(false);
    }

    void Update ()
    {
        float dirtLeft = GetInteractables();

        float clean = Mathf.Round(100 - ((dirtLeft / initialDirt) * 100));

        amountClean.text = (clean + "% Cleaned");

        if(clean >= 98)
        {
            GameOver();
        }
    }

    int GetInteractables()
    {
        return GameObject.FindGameObjectsWithTag("Interactable").Length;
    }

    void GameOver()
    {
        cleanIndicator.SetActive(false);
        gameOver.SetActive(true);
    }

}
