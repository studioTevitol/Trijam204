using NavMeshPlus.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeRuntime : MonoBehaviour
{
    public NavMeshSurface Surface2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Surface2D.BuildNavMeshAsync();
        }
    }
}
