using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text redScore, blueScore;

    public static int red = 0, blue = 0;

    void Update()
    {
        redScore.text = red.ToString();
        blueScore.text = blue.ToString();
    }
}
