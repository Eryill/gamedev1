﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    void Start()
    {

    }

    private void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
