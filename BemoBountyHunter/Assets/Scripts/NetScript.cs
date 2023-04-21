using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NetScript : MonoBehaviour
{
    [SerializeField] private SceneSelection a;
 //   public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
 //       audioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("something happened");
        GameObject obj = collision.gameObject;
        if (obj.tag == "Fish")
        {
            Debug.Log("it hit");
            Destroy(obj);
        }
        if (obj.tag == "BEMO")
        {
            Debug.Log("it hit");
            //           audioPlayer.Play();

            SceneManager.LoadScene("EndGame");
            //a.LoadEnd();
        }

    }
}