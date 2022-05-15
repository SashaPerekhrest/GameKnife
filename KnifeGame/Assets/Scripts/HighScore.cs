using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text scoreTxt;
    void Update()
    {
        scoreTxt.text ="High Score = " + PlayerPrefs.GetInt("High").ToString();
    }
}
