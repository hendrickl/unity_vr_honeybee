using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokerManager : MonoBehaviour
{
    [SerializeField] private GameObject _smokeParticle;

    public void ActivateSmoke()
    {
        print("Smoke is activated");
        _smokeParticle.SetActive(true);
    }

    public void DeactivateSmoke()
    {
        print("Smoke is off");
        _smokeParticle.SetActive(false);
    }
}
