using UnityEngine;

public class sound_Practice : MonoBehaviour
{
    private AudioSource audioSource;
  //  public AudioClip[] next_clip;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        audioSource.Play();
     //   Invoke("cliptest", 3f);
    }

    void Update()
    {
        
    }

  //  viod cliptest()
  //  {
  //      Debug.Log("calling cliptest");
  //      audioSource.Stop();
  //     audioSource.loop= false;
  //      audioSource.clip = next_clip[];
   //     audioSource.Play();
   // }
}
