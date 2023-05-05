using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ApproachPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Swimmer swim;
    private Vector3 movement;
    private float step;
    // Start is called before the first frame update
    void Start()
    {
        step = 0;
        swim.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        step += .008f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        float dist = Vector3.Distance(player.position, transform.position);
        if(dist < .5f){
            SceneManager.LoadScene("Level1-BemoVer");
        }
    }
}
