using UnityEngine;
using UnityEngine.SceneManagement;

public class point_goal : MonoBehaviour
{
    private int scene_number;

    void Start()
    {
        scene_number = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        SceneManager.LoadScene(scene_number + 1);
    }

    void Update()
    {
        
    }

}
