using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;

    Vector2 startPos;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 스와이프의 길이를 구한다. 
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표 
            Debug.Log("마우스 눌렀다!!");
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("마우스 눌렀던거 뗐다!!");
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            // 스와이프 길이를 처음 속도로 변경한다. 
            this.speed = swipeLength / 500.0f;
        }

        transform.Translate(this.speed, 0, 0); // 이동
        this.speed *= 0.98f;
    }
}
