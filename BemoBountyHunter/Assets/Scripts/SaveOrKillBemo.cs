using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOrKillBemo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject badEnding;
    public void Ending1()
    {
        goodEnding.SetActive(true);
        GameObject obj = GameObject.Find("Options");
        Destroy(obj);
    }
    public void Ending2()
    {
        badEnding.SetActive(true);
        GameObject obj = GameObject.Find("Options");
        Destroy(obj);
    }
}
