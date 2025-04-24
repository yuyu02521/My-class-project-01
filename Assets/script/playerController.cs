using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    private Rigidbody2D force;
    public float  jumpHeight;
    private bool isGround;
    public int coinCount;
    public int HP;
    private AudioSource audioSource;
    public AudioClip[] player_AudioClip;
    private SpriteRenderer player_sprite;

    //private Vector3 newPos;

    void Start()
    {
        force = GetComponent<Rigidbody2D>();
        Debug.Log("Player HP:" + HP);
        audioSource=GetComponent<AudioSource>();
        player_sprite=GetComponent<SpriteRenderer>();   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }

        if (collision.gameObject.tag=="Monster")
        {
            HP = HP - 1;
            Debug.Log("Player HP:" + HP);
            audioSource.PlayOneShot(player_AudioClip[1]);
            player_sprite.color = Color.red;
        }
        else
        {
            player_sprite.color = Color.white;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            coinCount++;
            Debug.Log("You got a coin!:"+coinCount);
        }
        else if (collision.gameObject.tag=="Food" && HP <10)
        {
            HP += 1;
            Debug.Log("HP:" + HP);
        }

        if (collision.gameObject.tag == "DeadZone")
        {
            SceneManager.LoadScene(1);
        }

    }

    private void Update()
    {
        Vector2 NoMovement = new Vector2(0f, 0f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHorizontal * 5f * Time.deltaTime, 0);

        jump();

        if(HP<=0)
        {
            SceneManager.LoadScene(1);
        }
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround == true)
            {
                force.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
                audioSource.PlayOneShot(player_AudioClip[0]);
                isGround = false;
            }

        }
    }
}


