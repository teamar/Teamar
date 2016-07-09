﻿using UnityEngine;
using System.Collections;
using System.IO;
//触摸放大缩小 旋转
//dreamemarket
public class ScaleAndRotate : MonoBehaviour
{
	private Touch oldTouch1;  //上次触摸点1(手指1)
	private Touch oldTouch2;  //上次触摸点2(手指2)
	public float getBigScaleRate =100f;//变大系数
	public float getSmallScaleRate = 100f;//变小系数
	void Start()
	{
		
	}
	
	
	
	
	void Update () {
		
		//没有触摸
		if ( Input.touchCount <= 0 ){
			return;
		}
		
		//单点触摸， 水平上下旋转
		//if( 1 == Input.touchCount ){
			//Touch touch = Input.GetTouch (0);
			//Vector2 deltaPos = touch.deltaPosition;			
			//transform.Rotate(Vector3.down  * deltaPos.x , Space.World); 
			//transform.Rotate(Vector3.right * deltaPos.y , Space.World);
		//}
		
		//多点触摸, 放大缩小
		Touch newTouch1 = Input.GetTouch (0);
		Touch newTouch2 = Input.GetTouch (1);
		
		//第2点刚开始接触屏幕, 只记录，不做处理
		if( newTouch2.phase == TouchPhase.Began ){
			oldTouch2 = newTouch2;
			oldTouch1 = newTouch1;
			return;
		}
		
		//计算老的两点距离和新的两点间距离，变大要放大模型，变小要缩放模型
		float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
		float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);
		
		//两个距离之差，为正表示放大手势， 为负表示缩小手势
		float offset = newDistance - oldDistance;
		
		//放大因子， 一个像素按 缩小getBigScaleRate 倍来算(
		float scaleFactor = offset / getBigScaleRate;
		Vector3 localScale = transform.localScale;
		Vector3 scale = new Vector3(localScale.x + scaleFactor,
		                            localScale.y + scaleFactor, 
		                            localScale.z + scaleFactor);
		
		//最小缩放到 getSmallScaleRate 倍
		if (scale.x > getSmallScaleRate && scale.y > getSmallScaleRate && scale.z > getSmallScaleRate) {
			transform.localScale = scale;
		}
		
		//记住最新的触摸点，下次使用
		oldTouch1 = newTouch1;
		oldTouch2 = newTouch2;
	}
	
}