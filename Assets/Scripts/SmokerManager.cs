using UnityEngine;

public class SmokerManager : MonoBehaviour
{
    [SerializeField] private GameObject _smokeParticle;

    public void ActivateSmoke()
    {
        _smokeParticle.SetActive(true);
    }

    public void DeactivateSmoke()
    {
        _smokeParticle.SetActive(false);
    }
}
