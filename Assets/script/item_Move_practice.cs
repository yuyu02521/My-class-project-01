using UnityEngine;

public class item_Move_practice : MonoBehaviour
{

    private float itemXposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemXposition = Mathf.PingPong(Time.time * 2f, 1f);
        transform.position = new Vector3(itemXposition, transform.position.y, transform.position.z);
    }
}
