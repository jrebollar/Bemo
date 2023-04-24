using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NetScript : MonoBehaviour
{
    
    [SerializeField] private AudioSource audioPlayer;

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
        GameObject obj = collision.gameObject;
        if (obj.tag == "Fish")
        {
            Debug.Log("it hit");
            Destroy(obj);
            audioPlayer.Play();
        }
        if (obj.tag == "BEMO")
        {
            Debug.Log("it hit");
            SceneManager.LoadScene("MainMenu");
        }

    }
}