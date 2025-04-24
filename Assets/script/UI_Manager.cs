using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    private float Gametimer = 25;
    public TMP_Text timer;
    public TMP_Text get_Coin;
    public TMP_Text get_Scene;
    public TMP_Text player_hp;
    public GameObject player;
    public GameObject point_goal;
    private int playerHP;
    private int coin_number;
    private int entire_scene;
    private int scene_number;
   
    void Start()
    {
        point_goal.SetActive(false);
    }

   
    void Update()
    {
        if (Gametimer > 0)
        {
            Gametimer -= Time.deltaTime;
            // Debug.Log((int)Gametimer);
            timer.text = "TIME:" + (int)Gametimer;
        }
        else if(Gametimer<0)
        {
            SceneManager.LoadScene("ending scene");
        }

        playerHP=player.GetComponent<playerController>().HP;
        player_hp.text = "HP:" + playerHP;
        player_hp.transform.position = Camera.main.WorldToScreenPoint(player.transform.position + new Vector3(-0.3f, 1f, 0));
        if(playerHP < 0)
        {
            SceneManager.LoadScene("ending scene");
        }

        coin_number=player.GetComponent<playerController>().coinCount;
        get_Coin.text = "X" + coin_number;

        scene_number = SceneManager.GetActiveScene().buildIndex;
        entire_scene = SceneManager.sceneCountInBuildSettings;
        get_Scene.text = scene_number + "/" + entire_scene;

        if(coin_number>=3)
        {
            point_goal.SetActive(true);
        }

    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

}
