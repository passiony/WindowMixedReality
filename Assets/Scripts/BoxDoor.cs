using DG.Tweening;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BoxDoor : MonoBehaviour
{
    private XRSimpleInteractable m_XRGrab;
    
    public bool open;

    public Vector3 OpenEuler;
    public Vector3 CloseEuler;

    private void Awake()
    {
        m_XRGrab = gameObject.GetComponent<XRSimpleInteractable>();
        m_XRGrab.selectEntered.AddListener(OnSelectEntered);
    }

    protected void OnSelectEntered(SelectEnterEventArgs args)
    {
        open = !open;
        transform.DOKill();
        transform.DORotate(open ? OpenEuler : CloseEuler,1f);
    }
}