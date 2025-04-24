using UnityEngine;

public class itemCoin : MonoBehaviour
{
    public Sprite img;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    private Animator item_animation_controller;
    private Collider2D item_collider;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource= GetComponent<AudioSource>();
        item_animation_controller= GetComponent<Animator>();
        item_collider= GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            Destroy(item_animation_controller);
            Destroy(item_collider);
            spriteRenderer.sprite = img;
            transform.position += new Vector3(0, 0.7f, 0);
            Destroy(gameObject,0.5f);
        }
    }

}
