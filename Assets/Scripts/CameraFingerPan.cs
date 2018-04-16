using UnityEngine;
using System.Collections;


//0.07 & 7.07
public class CameraFingerPan : MonoBehaviour {
	public float speed = 0.1F;
	public float minPos = 0.07f;
	public float maxPos = 7.07f;

	public GameObject brainCavity;
	private Animator bcAnim; //brain cavity animator
	void Start(){
		bcAnim = brainCavity.GetComponent<Animator> ();
	}
	void Update() {
		if (bcAnim.GetBool ("isSmall") == false) {
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
				Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
				if (transform.position.x - touchDeltaPosition.x * speed > minPos && transform.position.x - touchDeltaPosition.x * speed < maxPos)
					transform.Translate (-touchDeltaPosition.x * speed, 0, 0);
			}
		}
		else
		{
			transform.position = new Vector3(3.12f, 1, -10);
		}
}
}
