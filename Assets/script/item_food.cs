using UnityEngine;

public class item_food : MonoBehaviour
{
    private AudioSource food_audioSource;
    public AudioClip food_audioclip;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
           if(collision.gameObject.CompareTag("Player")&&!collision.gameObject.CompareTag("Monster"))
        {
            food_audioSource.PlayOneShot(food_audioclip);
            Destroy(gameObject);
        }
    }


}
