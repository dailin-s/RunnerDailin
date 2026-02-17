using UnityEngine;

public class playerJump : MonoBehaviour
{

    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        audioSource.Play();
    }
}
