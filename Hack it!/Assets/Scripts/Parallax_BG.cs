using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_BG : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
    	cameraTransform = Camera.main.transform;
    	lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
    	Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        float parallaxEffectMultiplierX = .9f;
        float parallaxEffectMultiplierY = .2f;
    	transform.position += new Vector3 (deltaMovement.x * parallaxEffectMultiplierX,
                                           deltaMovement.y * parallaxEffectMultiplierY);
    	lastCameraPosition = cameraTransform.position;
    }
}
