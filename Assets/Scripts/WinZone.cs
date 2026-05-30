using UnityEngine;

public class WinZone : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}