using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static float redScore;
    public static float blueScore;

    public Text redScoreText;
    public Text BlueScoreText;

    private void Update()
    {
        redScoreText.text = redScore.ToString();
        BlueScoreText.text = blueScore.ToString();
    }
}
