using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRHandGrabAttachPoint : MonoBehaviour
{
    [SerializeField] private Transform _attachPoint;     // Don't forget to set this attach point in the XR Grab Interactable too.
    [Space(10)]
    [SerializeField] private Transform _rightHand;
    [SerializeField] private Transform _leftHand;

    private Transform handGrabbing;

    public void Grabbed(SelectEnterEventArgs interactor)
    {
        handGrabbing = interactor.interactorObject.transform;

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
