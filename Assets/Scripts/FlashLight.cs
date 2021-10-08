using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    public bool isOn = false;
    public GameObject lightSource;
    public GameObject phoneScreen;
    public AudioSource clickSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (isOn == false)
            {
                lightSource.SetActive(true);
                clickSound.Play();
                phoneScreen.SetActive(true);
                isOn = true;
            }
            else
            {
                lightSource.SetActive(false);
                clickSound.Play();
                phoneScreen.SetActive(false);
                isOn = false;
            }

        }
    }
}
