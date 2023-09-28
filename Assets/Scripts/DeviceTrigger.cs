using UnityEngine;
using System.Collections;
public class DeviceTrigger : MonoBehaviour {
	[SerializeField] private GameObject target;
	[SerializeField] private Vector3 dPos;
	public bool requireKey;
	private bool _open;
	void OnTriggerEnter(Collider other) {
		if (requireKey && Managers.Inventory.equippedItem != "key")
		{
			return;
		}
		else {
			Vector3 pos = target.transform.position + dPos;
			target.transform.position = pos;
			_open = true;
		}
	}
	void OnTriggerExit(Collider other) {
		if (_open) {
			Vector3 pos = target.transform.position - dPos;
			target.transform.position = pos;
			_open = false;
		}
	}
}