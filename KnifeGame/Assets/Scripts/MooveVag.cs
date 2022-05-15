using UnityEngine;

public class MooveVag : MonoBehaviour
{
    public Transform player;

    private void OnMouseDrag()
    {
        if (Game.life)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2f ? 2f : mousePos.x;
            mousePos.x = mousePos.x < -2f ? -2f : mousePos.x;
            player.position = new Vector3(mousePos.x, player.position.y);
        }
    }
}