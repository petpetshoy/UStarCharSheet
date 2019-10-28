using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideWindow : MonoBehaviour
{
    public GameObject ModalPanelBackdrop;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Modal window toggled off");
        ModalPanelBackdrop.SetActive(false);
    }

}
