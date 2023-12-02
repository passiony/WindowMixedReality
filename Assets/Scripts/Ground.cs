using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Ground : MonoBehaviour
{
    public Transform m_XRRoot;
    private TeleportationArea m_Area;
    public float posY;
    
    // Start is called before the first frame update
    void Awake()
    {
        m_Area = gameObject.GetComponent<TeleportationArea>();
        m_Area.teleporting.AddListener(OnTeleport);
    }

    private void OnTeleport(TeleportingEventArgs arg0)
    {
         StopCoroutine("CoTeleport");
         StartCoroutine("CoTeleport");
    }
    private IEnumerator CoTeleport()
    {
        yield return new WaitForSeconds(0.1f);
        // arg0.teleportRequest.destinationPosition;
        var pos = m_XRRoot.position;
        pos.y = posY;
        m_XRRoot.position = pos;
    }
}
