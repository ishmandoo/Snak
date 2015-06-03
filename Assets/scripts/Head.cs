using UnityEngine;
using System.Collections;

public class Head : BodyPart {
	private int horizontal = 0;
	private int vertical = 0;
	public BodySegment bodySegment;
	private BodyPart tail;

	// Use this for initialization
	void Start () {
		tail = this;
	}
	
	// Update is called once per frame
	void Update () {
		int newHorizontal = (int) (Input.GetAxisRaw ("Horizontal"));
		int newVertical = (int) (Input.GetAxisRaw ("Vertical"));
		if (newHorizontal != 0) {
			horizontal = newHorizontal;
			vertical = 0;
		} else if (newVertical != 0) {
			vertical = newVertical;
			horizontal = 0;
		}

		if(horizontal != 0 || vertical != 0)
		{
			transform.position = new Vector3(transform.position.x + horizontal*speed*Time.deltaTime, transform.position.y + vertical*speed*Time.deltaTime, 0);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			BodySegment newBody = Instantiate(bodySegment);
			newBody.Initialize(tail);
			tail = newBody;
		}
	}
}
