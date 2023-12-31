﻿using UnityEngine;
using System.Collections;
public class DoorOpenDevice : BaseDevice {
	[SerializeField] private Vector3 dPos;
	private bool _open;
	public void Activate() {
		if (!_open) {
			Vector3 pos = transform.position + dPos;
			transform.position = pos;
			_open = true;
		}
	}
	public void Deactivate() {
		if (_open) {
			Vector3 pos = transform.position - dPos;
			transform.position = pos;
			_open = false;
		}
	}
	public override void Operate() {
		if (_open) {
			Vector3 pos = transform.position - dPos;
			transform.position = pos;
		} else {
			Vector3 pos = transform.position + dPos;
			transform.position = pos;
		}
		_open = !_open;
	}
}