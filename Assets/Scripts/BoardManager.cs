﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BoardManager : MonoBehaviour {

	private const float TILE_SIZE = 1.0f;
	private const float TILE_OFFSET = 0.5f;

	private int selectionX = -1;
	private int selectionY = -1;

	public List<GameObject> chessPiecesPrefabs;

	private void Update(){
		UpdateSelection ();
		DrawChessboard ();
	}
	private void UpdateSelection(){
		if (!Camera.main)
			return;

		RaycastHit hit;
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 25.0f, LayerMask.GetMask ("ChessPlane"))) {
			selectionX = (int)hit.point.x;
			selectionY = (int)hit.point.z;
		} else {
			selectionX = -1;
			selectionY = -1;
		}
	}

	private void DrawChessboard(){
		Vector3 widthLine = Vector3.right * 8;
		Vector3 heightLine = Vector3.forward * 8;

		for (int i = 0; i <= 8; i++) {
			Vector3 start = Vector3.forward * i;
			Debug.DrawLine (start, start + widthLine);
			for (int j = 0; j <= 8; j++) {
				start = Vector3.right * j;
				Debug.DrawLine (start, start + heightLine);

			}
		}

			if(selectionX >=0 && selectionY >=0){
				Debug.DrawLine(
					Vector3.forward * selectionY + Vector3.right * selectionY,
					Vector3.forward * (selectionY + 1) + Vector3.right *(selectionX + 1));

				Debug.DrawLine(
					Vector3.forward * (selectionY +1) + Vector3.right * selectionY,
					Vector3.forward * (selectionY + 1) + Vector3.right *(selectionX + 1));
			}
	}
}
