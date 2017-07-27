using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	[SerializeField] bool shakeMe = false;
	[SerializeField]float shakeDur = .5f;
	[SerializeField]float shakeOffset = 10f;

	Transform t;
	Vector2 originalPos;
	float shakeTimer;

	void Awake()
	{
		t = transform;
	}

	public void Shake()
	{
		originalPos = t.position;
		shakeMe = true;
		shakeTimer = 0;
	}
	void Update()
	{
		if(!shakeMe)
		{
			return;
		}

		Vector2 shakePos = originalPos + Random.insideUnitCircle * shakeOffset;
		t.position = new Vector3(shakePos.x, shakePos.y, t.position.z);

		shakeTimer += Time.deltaTime;
		if(shakeTimer > shakeDur)
		{
			shakeMe = false;
			t.position = new Vector3(originalPos.x, originalPos.y, t.position.z);
		}
	}
}