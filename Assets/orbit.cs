using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {

	
	public Transform followObj;
    public Transform followTransform;
    public Transform rotationPivot;
    public Camera camera;
    public float Offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
      followTransform.position = followObj.position;
      camera.position = new Vector3(rotationPivot.position.x + Offset, rotationPivot.position.y, rotationPivot.position.z)
      if (Input.GetButtonDown ("E"))
      {
          transform.RotateAround (rotationPivot.position, new Vector3(0.0f, 1.0f, 0.0f), 90.0f);
      }

		
	}
}
