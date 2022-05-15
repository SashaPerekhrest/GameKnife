using UnityEngine;

public class Game : MonoBehaviour
{
    public static bool life;
    public static int Score;
    public GameObject restart;
    private void Awake()
    {
        life = true;
        Score = 0;
        if (!PlayerPrefs.HasKey("High"))
        {
            PlayerPrefs.SetInt("High", Score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!life)
        {
            restart.SetActive(true);
        }
    }
}
