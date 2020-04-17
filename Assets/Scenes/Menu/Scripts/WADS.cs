using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WADS : MonoBehaviour
{

	[Range(0,50)]
	public float speed = 5f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float delta = speed * Time.deltaTime;
		transform.position += new Vector3(Input.GetAxis("Horizontal") * delta, Input.GetAxis("Vertical") * delta);
	}
}
