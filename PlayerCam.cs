using UnityEngine;

public class PlayerCam : MonoBehaviour
{
	public GameObject target;
	public float distance;
	public float height;
	public float rotationDamping;
	public float heightDamping;

	void LateUpdate()
	{
		var wantedRotationAngle = target.transform.eulerAngles.y;
		var wantedHeight = target.transform.position.y + height;
		var currentRotationAngle = transform.eulerAngles.y;
		var currentHeight = transform.position.y;
		currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
		currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);
		var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
		transform.position = target.transform.position;
		transform.position -= currentRotation * Vector3.forward * distance;
		transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
		transform.LookAt(target.transform);
	}
}
