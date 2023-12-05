using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Bed : MonoBehaviour
{
    public Transform XrRoot;
    public float posY;

    private TeleportationAnchor m_Anchor;

    // Start is called before the first frame update
    void Start()
    {
        m_Anchor = gameObject.GetComponent<TeleportationAnchor>();
        m_Anchor.selectExited.AddListener(OnTeleporting);
    }

    private void OnTeleporting(SelectExitEventArgs arg0)
    {
        StopCoroutine("CoDelayTeleport");
        StartCoroutine("CoDelayTeleport");
    }

    IEnumerator CoDelayTeleport()
    {
        yield return new WaitForSeconds(0.2f);
        var pos = XrRoot.position;
        pos.y = posY;
        XrRoot.position = pos;
    }
}
