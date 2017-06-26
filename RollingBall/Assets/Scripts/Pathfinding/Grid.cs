using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

	// Forklift position
	public Transform forkLift;


	// Unwalkable areas
	public LayerMask unwalkableMask;

	// Defines the area of wold coord that grid is gonna cover
	public Vector2 gridWorldSize;

	// Radius that each individual node covers
	public float nodeRadius;

	// 2D array of nodes
	Node[,] grid;

	// Check how many nodes can we fit in grib
	float nodeDiameter;
	int gridSizeX, gridSizeY;

	void Start() {
		nodeDiameter = nodeRadius * 2;
		gridSizeX = Mathf.RoundToInt(gridWorldSize.x / 2);
		gridSizeY = Mathf.RoundToInt(gridWorldSize.y / 2);;
		createGrid ();
	}

	void createGrid() {
		grid = new Node[gridSizeX, gridSizeY];

		// Left edge of world
		Vector3 worldBotLeft = transform.position - (Vector3.right*gridWorldSize.x/2) -  (Vector3.forward*gridWorldSize.y/2);

		// Collision check to see if walkable or not
		for (int x = 0; x < gridSizeX; x++) {
			for (int y = 0; y < gridSizeY; y++) {
				Vector3 worldPoint = worldBotLeft + Vector3.right * (x * nodeDiameter + nodeRadius) + Vector3.forward * (y * nodeDiameter + nodeRadius);

				// If there is collision
				bool walkable = !(Physics.CheckSphere(worldPoint, nodeRadius, unwalkableMask));

				grid [x, y] = new Node (walkable, worldPoint);
			}
		}
	}

	// Locate node its standing on from world positon
	public Node NodeFromWorldPoint(Vector3 worldPos) {
		float percentX = (worldPos.x + gridWorldSize.x / 2) / gridWorldSize.x;
		float percentY = (worldPos.z + gridWorldSize.y / 2) / gridWorldSize.y;

		// Bounds
		percentX = Mathf.Clamp01 (percentX);
		percentY = Mathf.Clamp01 (percentY);


		int x = Mathf.RoundToInt((gridSizeX - 1) * percentX);
		int y = Mathf.RoundToInt((gridSizeY - 1) * percentY);
		return grid [x, y];
	}

	// Draws Grid Cube
	void OnDrawGizmos() {
		// Draw Big Grid
		Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));

		// Draw grid partions
		if (grid != null) {
			foreach (Node n in grid) {
				// Get forklift position
				Node forkNode = NodeFromWorldPoint(forkLift.position);

				// Set walkable to white otherwise unwalkable to red
				Gizmos.color = (n.walkable)?Color.white:Color.red;

				// Set forklift colour to green
				if (forkNode == n) {
					Gizmos.color = Color.green;
				}

				// Subtract by .1 for area
				Gizmos.DrawCube(n.worldPos, Vector3.one * (nodeDiameter-.1f));


			}
		}
	}
		



}
