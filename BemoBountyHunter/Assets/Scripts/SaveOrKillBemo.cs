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
    }
    public void Ending2()
    {
        badEnding.SetActive(true);;
    }
}
