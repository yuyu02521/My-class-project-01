using UnityEngine;

public class monster_01 : MonoBehaviour
{

    public GameObject monster;
    private Vector3 spawnPos;
    private GameObject spawnMonster;
    private float speed = 2f;


    void Start()
    {
        spawnPos = new Vector3(0, 0, 0);
        InvokeRepeating("startMonster", 2f,5f);
    }


    void startMonster()
    {
        spawnMonster = Instantiate(monster, spawnPos, Quaternion.identity);
    }


    void Update()
    {
        if(spawnMonster!=null)
        {
            spawnMonster.transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
