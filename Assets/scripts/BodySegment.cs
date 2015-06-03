using UnityEngine;
using System.Collections;

public class BodySegment : BodyPart {
	private BodyPart forwardSegment;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, forwardSegment.transform.position) > 1f) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, forwardSegment.transform.position, step);
		}
	}

	public void Initialize(BodyPart segment) {
		forwardSegment = segment;
	}
}
