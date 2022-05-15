using UnityEngine;

public class MoveClen : MonoBehaviour
{
    [SerializeField] public float fallSpeed = 6f;
    void Update()
    {
        if (Game.life)
        {
            if (transform.position.y < -6f)
                Destroy(gameObject);
            transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && this.tag == "BadRock")
            Game.life = false;
        if (other.gameObject.tag == "Player" && this.tag == "GoodRock" && Game.life)
        {
            Game.Score++;
            Destroy(gameObject);
        }
        if(PlayerPrefs.GetInt("High") < Game.Score)
            PlayerPrefs.SetInt("High", Game.Score);
    }
}
