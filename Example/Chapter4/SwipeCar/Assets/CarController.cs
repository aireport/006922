﻿using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	float speed = 0;
	Vector2 startPos;

	void Start() {
	}

	void Update() {

        // 스와이프 길이를 구한다 (추가)
        if (Input.GetMouseButtonDown(0)) {
            // 마우스를 클릭한 좌표
            this.startPos = Input.mousePosition;
		} else if(Input.GetMouseButtonUp(0)) {
            // 마우스를 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
			float swipeLength = (endPos.x - this.startPos.x);

            // 스와이프 길이를 처음 속도로 변경한다
            this.speed = swipeLength / 500.0f;

			// 효과재생음(추가)
			GetComponent<AudioSource>().Play();
		}

		transform.Translate(this.speed, 0, 0);
		this.speed *= 0.98f;
	}
}
