using UnityEngine;

public class playerJump : MonoBehaviour
{
    //jump settings
    public float jumpForce = 3f;
    private Rigidbody2D rb;
    private AudioSource audioSource;

    //landing dust
    public GameObject landingDustPrefab;
    private bool isGrounded;

    private DamageFlash damageFlash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        damageFlash = FindFirstObjectByType<DamageFlash>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.linearVelocity = Vector2.up * jumpForce;
            audioSource.Play();
            //isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
            Vector3 dustPosition = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            
            if(landingDustPrefab != null){
                Instantiate(landingDustPrefab, transform.position, Quaternion.identity);
            }

            if(collision.gameObject.CompareTag("Obstacle")){
                if(damageFlash != null)
                damageFlash.Flash();
            }
        }
    }

}
