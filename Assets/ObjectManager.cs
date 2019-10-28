using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{

    public GameObject ModalPanelBackdrop;

    public Button StatsButton;
    public Button SavesButton;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the main Views
        ModalPanelBackdrop = GameObject.Find("ModalPanelBackdrop");

        // Initialize the main Views Buttons.
        StatsButton = GameObject.Find("StatsButton").GetComponent<Button>();
        SavesButton = GameObject.Find("SavesButton").GetComponent<Button>();

        //Add the on click event to the Buttons
        //StatsButton.onClick.AddListener(ModalPanelBackdropShow);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //  Used to set a game object to active. eg. opening a modal window
    void ModalWindowOpen(GameObject window)
    {
        window.SetActive(true);
    }

    // used to set a game object to not active. rh. closing a modal window
    void ModalWindowClose(GameObject window)
    {
        window.SetActive(false);
    }


    // Open the StatsButton Modal window
    void ModalPanelBackdropShow()
    {
        ModalWindowOpen(ModalPanelBackdrop);
    }

    //Close the StatsButton Modal window
    void ModalPanelBackdropHide()
    {
        ModalWindowClose(ModalPanelBackdrop);
    }














}
