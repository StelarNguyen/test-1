using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject gameOverObject;
    private void OnTriggerEnter2D(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            collider.gameObject.SetActive(false);
            gameObject.SetActive(true);
        }
    }
}
