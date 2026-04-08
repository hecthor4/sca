using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monthChooser : MonoBehaviour
{
    public static int itineratedMonth;
    public static bool canFetch;

    public GameObject month1;
    public GameObject month2;
    public GameObject month3;
    public GameObject month4;

    private float waitTime = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        month1.SetActive(false);
        month2.SetActive(false);
        month3.SetActive(false);
        month4.SetActive(false);
        
        itineratedMonth = 0;
        
        StartCoroutine(ControlEverything());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ControlEverything()
    {
        canFetch = true;
        month1.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        itineratedMonth++;
        canFetch = false;
        yield return new WaitForSeconds(waitTime);

        month2.SetActive(true);
        canFetch = true;
        yield return new WaitForSeconds(waitTime);
        itineratedMonth++;
        canFetch = false;
        yield return new WaitForSeconds(waitTime);
        
        month3.SetActive(true);
        canFetch = true;
        yield return new WaitForSeconds(waitTime);
        itineratedMonth++;
        canFetch = false;
        yield return new WaitForSeconds(waitTime);
        
        month4.SetActive(true);
        canFetch = true;
        yield return new WaitForSeconds(waitTime);
        itineratedMonth++;
        canFetch = false;
        yield return new WaitForSeconds(waitTime);
    }
}
