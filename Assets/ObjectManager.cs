using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
// modal windows
    public GameObject ModalPanelBackdrop;
    public GameObject ModalStatsPanel;
    public GameObject ModalACPanel;
    public GameObject ModalResistancesPanel;
    public GameObject ModalHPPanel;
    public GameObject ModalNamePanel;




//buttons for panel 1 and their views
    public Button StatsButton;
    
    public GameObject strTextView;
    public GameObject strTextValue;
    public GameObject strTextMod;
    public GameObject dexTextView;
    public GameObject dexTextValue;
    public GameObject dexTextMod;
    public GameObject conTextView;
    public GameObject conTextValue;
    public GameObject conTextMod;
    public GameObject intTextView;
    public GameObject intTextValue;
    public GameObject intTextMod;
    public GameObject wisTextView;
    public GameObject wisTextValue;
    public GameObject wisTextMod;
    public GameObject chaTextView;
    public GameObject chaTextValue;
    public GameObject chaTextMod;


    public Button ResistancesButton;
    
    public GameObject drTextView;
    public GameObject drTextValue;
    public GameObject acidResistanceTextView;
    public GameObject acidResistanceTextValue;
    public GameObject coldResistanceTextView;
    public GameObject coldResistanceTextValue;
    public GameObject electricityResistanceTextView;
    public GameObject electricityResistanceTextValue;
    public GameObject fireResistanceTextView;
    public GameObject fireResistanceTextValue;
    public GameObject sonicResistanceTextView;
    public GameObject sonicResistanceTextValue;



    public Button ACButton;

    public GameObject kacLabel;
    public GameObject kacValueLabel;
    public GameObject eacLabel;
    public GameObject eacValueLabel;
    public GameObject cmdLabel;
    public GameObject cmdValueLabel;
    public GameObject fortTextView;
    public GameObject fortTextValue;
    public GameObject refTextView;
    public GameObject refTextValue;
    public GameObject willTextView;
    public GameObject willTextValue;



    public Button HPButton;

    public GameObject initValueView;
    public GameObject initLabel;
    public GameObject speedLabel;
    public GameObject speedValueView;
    public GameObject staminaLabel;
    public GameObject hpLabel;
    public GameObject resolveLabel;
    public GameObject staminaValueLabel;
    public GameObject hpValueLabel;
    public GameObject resolveValueLabel;



    public Button NameButton;

    public GameObject nameTextView;
    public GameObject levelTextView;
    public GameObject classTextView;






    // panel 2

    // panel 3

    // panel 4

    // panel 5


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
