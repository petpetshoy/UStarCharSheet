using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{

    public GameObject ModalPanelBackdrop;
    public GameObject ModalStatsPanel;
    public GameObject ModalACPanel;
    public GameObject ModalResistancesPanel;
    public GameObject ModalHPPanel;
    public GameObject ModalNamePanel;

    public Button StatsButton;
    public Button ResistancesButton;
    public Button ACButton;
    public Button HPButton;
    public Button NameButton;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the main Views
        ModalPanelBackdrop = GameObject.Find("ModalPanelBackdrop");
        ModalStatsPanel = GameObject.Find("ModalStatsPanel");
        ModalACPanel = GameObject.Find("ModalACPanel");
        ModalResistancesPanel = GameObject.Find("ModalResistancesPanel");
        ModalHPPanel = GameObject.Find("ModalHPPanel");
        ModalNamePanel = GameObject.Find("ModalNamePanel");

        // Initialize the main Views Buttons.
        StatsButton = GameObject.Find("StatsButton").GetComponent<Button>();
        ResistancesButton = GameObject.Find("ResistancesButton").GetComponent<Button>();
        ACButton = GameObject.Find("ACButton").GetComponent<Button>();
        HPButton = GameObject.Find("HPButton").GetComponent<Button>();
        NameButton = GameObject.Find("NameButton").GetComponent<Button>();

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
