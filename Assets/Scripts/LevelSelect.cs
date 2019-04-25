using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button start, right, left;
    public Image image;

    void Start()
    {
        start.onClick.AddListener(StartAnimation);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void StartAnimation()
    {
        Invoke("StartGame", 0.5f);
        image.GetComponent<Animator>().enabled = true;
    }
}
