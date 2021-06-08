using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackground : MonoBehaviour
{
    static AudioBackground stop = null;
    void Awake()
    {
        if (stop != null)
        {
            Destroy(gameObject);
        }
        else
        {
            stop = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    
void Start()
{ }

    // Update is called once per frame
    void Update()
    {
        
    }
}
