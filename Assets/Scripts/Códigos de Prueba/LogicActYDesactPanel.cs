using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicActYDesactPanel : MonoBehaviour
{
    [SerializeField] private GameObject panelObjetivo;
    private bool activarObjeto;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activarObjeto = !activarObjeto;
            panelObjetivo.SetActive(activarObjeto);
            
            
        }
    }
}
