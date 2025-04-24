using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager_mainScene : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void button_Start()
    {
        SceneManager.LoadScene(1);
    }

    public void button_Manual()
    {
        //image sprite getactive(true);
    }

    public void Exit()
    {
    Application.Quit();
    }
}
