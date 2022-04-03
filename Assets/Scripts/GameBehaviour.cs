using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    LandscapeGenerator _lg;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        _lg = gameObject.GetComponent<LandscapeGenerator>();
        _lg.generateLandscape();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
