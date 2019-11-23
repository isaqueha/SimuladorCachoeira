using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NVIDIA.Flex;

public class Gather : MonoBehaviour
{
    public GameObject flexObj;
    public NVIDIA.Flex.FlexContainer container;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(container);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
