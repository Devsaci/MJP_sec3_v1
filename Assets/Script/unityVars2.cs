using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityVars2 : MonoBehaviour
{

    public GameObject go;
    public Transform goTransforme;
    public Vector3 goPos;

    public Renderer rend;
    public Material mat;
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
       goPos = goTransforme.position;
        transform.position = goPos;

        rend = GetComponent<Renderer>();
        mat = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
