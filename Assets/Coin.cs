using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Audio"))
        {
            audioManager.PlaySFX(audioManager.coinClip);
            Destroy(gameObject);
        }
    }
}
