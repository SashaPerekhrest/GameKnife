using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static bool life;
    public static int Score;
    public GameObject restart;
    public GameObject fon;
    public GameObject knife;
    public GameObject tray;
    public GameObject gold;
    private bool first = true;
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
        if (!life && first)
        {
            knife.GetComponent<Animator>().enabled = true;
            fon.GetComponent<Animator>().SetBool("EndGame", true);
            tray.GetComponent<Animator>().SetBool("EndGame", true);
            StartCoroutine(Spawn());
            first = !first;
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);
        while (Score > 0)
        {
            var bonbon = Instantiate(gold, Vector3.zero, Quaternion.identity);
            bonbon.transform.parent = tray.transform;
            Score -= 50;
            yield return new WaitForSeconds(1f);
        }
        restart.SetActive(true);
    }

}
