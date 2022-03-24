using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewChanger : MonoBehaviour
{

    public Camera MenuCam;
    public Camera P1Cam;
    public Camera P2Cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void P2View()
    {
        P1Cam.gameObject.SetActive(false);
        P2Cam.gameObject.SetActive(true);
    }

    public void P1View()
    {
        P2Cam.gameObject.SetActive(false);
        P1Cam.gameObject.SetActive(true);
    }
    public void POVChanger()
    {
        MenuCam.gameObject.SetActive(false);
        P1Cam.gameObject.SetActive(true);
    }

}
