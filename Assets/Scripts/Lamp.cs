using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public GameObject m_light;

    public void LightOn()
    {
        m_light.gameObject.SetActive(!m_light.gameObject.activeSelf);
    }
}