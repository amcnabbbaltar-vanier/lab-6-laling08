using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();

        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1); // Add 1 point per hit
        }
    }
}
