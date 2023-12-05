using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lamp : MonoBehaviour
{
    public GameObject m_light;

    private XRSimpleInteractable m_XRSimple;
    
    private void Awake()
    {
        m_XRSimple = gameObject.GetComponent<XRSimpleInteractable>();
        m_XRSimple.selectEntered.AddListener(OnLightOn);
    }

    private void OnLightOn(SelectEnterEventArgs arg0)
    {
        m_light.gameObject.SetActive(!m_light.gameObject.activeSelf);
    }

}