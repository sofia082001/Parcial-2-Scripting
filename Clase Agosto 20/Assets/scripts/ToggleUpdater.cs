using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleUpdater : MonoBehaviour
{   
    [SerializeField] eventControllerSO eventoToggle;
    [SerializeField] GameObject esfera;
    ToggleController togglEstado = new ToggleController();
    public Text textoprincipal;

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
        if(esfera.gameObject.activeSelf)
        {
            togglEstado.Activado(textoprincipal);
        }
        if (!esfera.gameObject.activeSelf)
        {
            togglEstado.Apagado(textoprincipal);
        }
    }
}
