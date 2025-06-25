using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVfx;
    [SerializeField] int hitpoints;
    [SerializeField] int scorevalue;
    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
   private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        
        hitpoints--;
        if ((hitpoints <= 0))
        {
            scoreboard.IncreaseScore(scorevalue);

            Instantiate(destroyedVfx, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
