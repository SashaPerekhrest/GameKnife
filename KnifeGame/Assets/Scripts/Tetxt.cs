using UnityEngine;
using UnityEngine.UI;

public class Tetxt : MonoBehaviour
{
    public Text scoreTxt;

    void Update()
    {
        if (Game.life)
        {
            scoreTxt.text ="Score = " + Game.Score.ToString();
        }
    }
}
