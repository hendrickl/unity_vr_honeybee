using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRHandGrabAttachPoint : MonoBehaviour
{
    // * * *
    // Variables related to hand grabbing and attach point
    private Transform handGrabbing;  // The transform representing the hand currently grabbing the object.
    [SerializeField] private Transform _attachPoint;  // Set this attach point in the XR Grab Interactable.
    [SerializeField] private Transform _rightHand;
    [SerializeField] private Transform _leftHand;


    public void Grabbed(SelectEnterEventArgs interactor)
    {
        handGrabbing = interactor.interactorObject.transform;

        // Determine which hand is grabbing the object and set the attachment point position and rotation accordingly.
        if (handGrabbing.name == _rightHand.name)
        {
            _attachPoint.position = _rightHand.position;
            _attachPoint.rotation = _rightHand.rotation;
        }
        else if (handGrabbing.name == _leftHand.name)
        {
            _attachPoint.position = _leftHand.position;
            _attachPoint.rotation = _leftHand.rotation;
        }
    }
}
