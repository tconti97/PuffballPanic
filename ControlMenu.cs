using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour {

    public GameObject puffObjs;
    //public GameObject puffUIs;
    public GameObject animObjs;
   // public GameObject animUIs;


    public void puffControls()
    {
        puffObjs.SetActive(true);
      //  puffUIs.SetActive(true);

        animObjs.SetActive(false);
       // animUIs.SetActive(false);
    }
    public void animControls()
    {
        puffObjs.SetActive(false);
      //  puffUIs.SetActive(false);

        animObjs.SetActive(true);
      //  animUIs.SetActive(true);
    }
}
