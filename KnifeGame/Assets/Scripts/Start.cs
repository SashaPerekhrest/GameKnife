using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }
}
