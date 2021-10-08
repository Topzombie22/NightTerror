using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScrn : MonoBehaviour
{
    public GameObject Endscrn;

    public void OnTriggerEnter(Collider other)
    {  
        Endscrn.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        AudioListener.volume = 0;
    }
}