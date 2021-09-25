using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUpdater : MonoBehaviour
{   
    [SerializeField] eventControllerSO eventoToggle;

    private void Start()
    {

    }
    private void OnEnable()
    {
        eventoToggle.toggleActivity += toggleUpdateState;
    }
    private void OnDisable()
    {
        eventoToggle.toggleActivity -= toggleUpdateState;
    }
    public void toggleUpdateState()
    {
        Debug.Log("entre en estado Toggle");
    }
}
