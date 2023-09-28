using UnityEngine;
using System.Collections;
public class BaseDevice : MonoBehaviour {
	public float radius = 3.5f;
	void OnMouseDown() 
	{
		Transform player = GameObject.FindWithTag("Player").transform;
		if (Vector3.Distance(player.position, transform.position) < radius) 
		{
			Operate();
		}
	}
	public virtual void Operate() {
	}
}