using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaretakerInteraction : MonoBehaviour
{
    ButtonNames buttonNames;
    [SerializeField] GameObject buttons;
    MainButtons mainButtons;
    [SerializeField] GameObject talkingButtons;

    void Awake(){
        buttonNames = buttons.GetComponent<ButtonNames>();
        mainButtons = talkingButtons.GetComponent<MainButtons>();
    }
    private void OnTriggerStay(Collider other){
        if(other.gameObject.CompareTag("Player")){
            if(Input.GetKeyDown(KeyCode.T)){
                buttonNames.ButtonUpActions();
            }
            else if(Input.GetKeyDown(KeyCode.H)){
                buttonNames.ButtonDownActions();
            }
        }   
    }
    void OnTriggerExit(Collider other)
    {
        mainButtons.DisableButtons();
        buttonNames.DisableButtons();
    }
    void OnTriggerEnter(Collider other)
    {
        buttonNames.CareTakerInteraction();
        buttonNames.EnableButtons();
    }
    
}
