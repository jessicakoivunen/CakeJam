using UnityEngine;

public class RenderOrderController : MonoBehaviour
{
    private GameObject player;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Assuming your player has a "Player" tag, replace it with the actual tag used for your player object.
        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Player not found!");
        }

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer not found on this object!");
        }
    }

    void Update()
    {
        if (player != null && spriteRenderer != null)
        {
            // Check if player is behind the current object
            if (player.transform.position.y > transform.position.y)
            {
                // Render behind player
                spriteRenderer.sortingOrder = player.GetComponent<SpriteRenderer>().sortingOrder + 1;
            }
            else
            {
                // Render on top of player
                spriteRenderer.sortingOrder = player.GetComponent<SpriteRenderer>().sortingOrder - 1;
            }
        }
    }
}