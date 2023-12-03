using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BookInteraction : XRGrabInteractable
{
    private Vector3 originalScale;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        originalScale = transform.localScale;
        transform.localScale *= 1.2f;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        transform.localScale = originalScale;
    }
}


