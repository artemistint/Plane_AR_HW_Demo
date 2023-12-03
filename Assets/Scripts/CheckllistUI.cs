using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class CheckllistUI : MonoBehaviour
{

    public Toggle checklist_toggle;
    public bool playersReady;

    public void Start()
    {
        checklist_toggle = GameObject.Find("toggle1").GetComponent<Toggle>();
    }

    public void EnableDisable()
    {
        if (checklist_toggle.interactable == true)
        {
            checklist_toggle.interactable = false;
        }
    }
}