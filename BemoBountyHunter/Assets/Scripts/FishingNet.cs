using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class FishingNet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject net;
    [SerializeField] InputActionReference toggleBtn;
    bool isOpen;
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(toggleBtn.action.triggered && !isOpen){
            net.SetActive(true);
            isOpen = true;
        }
        else if(toggleBtn.action.triggered){
            net.SetActive(false);
            isOpen = false;            
        }
    }
}
