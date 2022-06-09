using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UnityEngine.Object NPSRef;
    [SerializeField] GameObject Resp;
    // Start is called before the first frame update
    void Start()
    {
        NPSRef = Resources.Load("NPS");
    }

    // Update is called once per frame
    void Update()
    {
        //Respawn();
    }

    void Respawn()
    {
        GameObject NPSCopy = (GameObject)Instantiate(NPSRef);
        NPSCopy.transform.position = Resp.transform.position;
    }
}
