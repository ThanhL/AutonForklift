﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

	public bool walkable;
	public Vector3 worldPos;

	public Node(bool _walkable, Vector3 _worldPos) {
		this.walkable = _walkable;
		this.worldPos = _worldPos;
	}
		
}
