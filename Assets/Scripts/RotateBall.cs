﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour {

    public float RotateSpeed;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(-5.0f, 0.0f, 0.0f));
    }
}
