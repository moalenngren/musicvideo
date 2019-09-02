using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyroManager : MonoBehaviour
{
    [SerializeField] GameObject[] pyros;

    // Start is called before the first frame update
    void Start()
    { 
        Invoke("PyroOn", 2);
        Invoke("PyroOff", 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PyroOn()
    {
        foreach (GameObject pyro in pyros)
        {
            //pyro.gameObject.SetActive(true);
            pyro.transform.GetChild(0).gameObject.SetActive(true);
            pyro.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
            pyro.transform.GetChild(1).GetComponent<ParticleSystem>().Play();
            pyro.transform.GetChild(2).GetComponent<ParticleSystem>().Play();
            pyro.transform.GetChild(3).GetComponent<ParticleSystem>().Play();
            pyro.transform.GetChild(4).GetComponent<ParticleSystem>().Play();
            pyro.transform.GetChild(5).GetComponent<ParticleSystem>().Play();
        }
    }

    public void PyroOff()
    {
        foreach (GameObject pyro in pyros)
        {
            //pyro.gameObject.SetActive(false);
            pyro.transform.GetChild(0).GetComponent<ParticleSystem>().Stop();
            pyro.transform.GetChild(0).gameObject.SetActive(false);
            pyro.transform.GetChild(1).GetComponent<ParticleSystem>().Stop();
            pyro.transform.GetChild(2).GetComponent<ParticleSystem>().Stop();
            pyro.transform.GetChild(3).GetComponent<ParticleSystem>().Stop();
            pyro.transform.GetChild(4).GetComponent<ParticleSystem>().Stop();
            pyro.transform.GetChild(5).GetComponent<ParticleSystem>().Stop();
        }
    }
}
