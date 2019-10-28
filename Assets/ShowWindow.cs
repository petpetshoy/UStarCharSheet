using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWindow : MonoBehaviour
{
    public GameObject ModalPanelBackdrop;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Modal window toggled on");
        ModalPanelBackdrop.SetActive(true);
    }

    public void clicked(Button button)
    {
     
    }

}
