using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOrKillBemo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Bemo;
    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject badEnding;
    public Timer timer;

    public void Ending1() // save bemo
    {
        timer.isTimerRunning = false;
        goodEnding.SetActive(true);
        GameObject obj = GameObject.Find("Options");
        Destroy(obj);
        StartCoroutine(BemoAscend());
    }
    public void Ending2() // kill bemo
    {
        timer.isTimerRunning = false;
        Destroy(Bemo);
        badEnding.SetActive(true);
        GameObject obj = GameObject.Find("Options");
        Destroy(obj);
    }

    IEnumerator BemoAscend()
    {
        yield return new WaitForSeconds(2);
        Destroy(Bemo);
    }
}
