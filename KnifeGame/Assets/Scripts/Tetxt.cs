using UnityEngine;
using UnityEngine.UI;

public class Tetxt : MonoBehaviour
{
    public Text scoreTxt;

    void Update()
    {
        scoreTxt.text ="Score = " + Game.Score.ToString();
    }
}
