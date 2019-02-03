using System.Collections;
using UnityEngine;

public class Particles : MonoBehaviour
{
    private ParticleSystem exp;
    void Start()
    {
         exp = GetComponent<ParticleSystem>();
         exp.Stop();
    }
    public void OnTriggerEnter(Collider other)
    {

        exp.Play();
    }
}
