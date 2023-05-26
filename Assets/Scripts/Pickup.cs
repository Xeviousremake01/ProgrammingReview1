using System.Collections;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public PlayerController player;
    public float duration;
    public float score;
    public GameManager gm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject.GetComponent<PlayerController>();
            Activate();
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Invoke(nameof(DelayedDestroy), duration);
        }
    }

    public virtual void Activate()
    {
        GameObject.Find("GameManager");
        // Look a Fish ><)))*>
    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }
}
