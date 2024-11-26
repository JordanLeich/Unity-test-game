using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            health--;
            if (health <= 0)
            {
                Debug.Log("You Lose!");
                // Optionally restart the level
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
}
