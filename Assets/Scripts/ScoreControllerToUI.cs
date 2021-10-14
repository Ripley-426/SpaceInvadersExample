using UnityEngine;
using UnityEngine.UI;

public class ScoreControllerToUI : MonoBehaviour
{
    [SerializeField] private ScoreController scoreController;
    [SerializeField] private Text scoreLabel;

    private void Update()
    {
        scoreLabel.text = "Score: " + scoreController.GetScore().ToString("0000");
    }
}
