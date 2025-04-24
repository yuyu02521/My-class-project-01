using UnityEngine;

public class hiddenitem : MonoBehaviour
{

    public GameObject coin;
    private Vector3 pos;
    private Quaternion rotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos = GetComponent<Transform>().position;
        pos = pos + new Vector3(0, 0.3f, 0);
        rotation = GetComponent<Transform>().rotation;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(GetComponent<Animation>());
            gameObject.SetActive(false);
          //  Instantiate(coin, pos, rotation);
        }
        
    }
}
