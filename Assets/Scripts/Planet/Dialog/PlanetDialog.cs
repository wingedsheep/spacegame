using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetDialog : MonoBehaviour {

	public GameObject planet;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);

		// Draw a triangle to connect the dialog to the planet
//		GameObject m_goTriangle = new GameObject();
//		m_goTriangle.AddComponent<MeshFilter>();
//		m_goTriangle.AddComponent<MeshRenderer>();
//		Mesh m_meshTriangle = m_goTriangle.GetComponent<MeshFilter>().mesh;
//		m_meshTriangle.Clear();
//		Vector3 bottom = planetScreenCoordinate;
//		bottom.y -= 40;
//		Vector3 left = planetScreenCoordinate;
//		left.x -= 5;
//		left.y -= 25;
//		Vector3 right = planetScreenCoordinate;
//		right.x += 5;
//		right.y -= 25;
//		m_meshTriangle.vertices = new Vector3[] { bottom, left, right };
//		m_meshTriangle.uv = new Vector2[] { new Vector2(0, 0), new Vector2(0, 0.25f), new Vector2(0.25f, 0.25f) };
//		m_meshTriangle.triangles = new int[] { 0, 1, 2 };
////		Graphics.DrawMesh(m_meshTriangle, Vector3.zero, Quaternion.identity, newMat, 0);
//
//
//		Material material = new Material (Shader.Find("UI/Default"));
//		material.SetColor("_TintColor", Color.white);
//
//		CanvasRenderer pCanvasRenderer = gameObject.GetComponent<CanvasRenderer>();
//
//		RectTransform pRectTransform = gameObject.GetComponent<RectTransform>();
//		if(pRectTransform == null)
//		{
//			Vector3 pos = gameObject.transform.localPosition;
//			Quaternion rot = gameObject.transform.localRotation;
//			Vector3 scale = gameObject.transform.localScale;
//
//			pRectTransform = gameObject.AddComponent<RectTransform>();
//			pRectTransform.localPosition = pos;
//			pRectTransform.localRotation = rot;
//			pRectTransform.localScale = scale;
//		}
//
//		pCanvasRenderer = gameObject.AddComponent<CanvasRenderer>();
//
//		UIVertex uiVertexBottom = new UIVertex ();
//		uiVertexBottom.position = bottom;
//		UIVertex uiVertexLeft = new UIVertex ();
//		uiVertexLeft.position = left;
//		UIVertex uiVertexRight = new UIVertex ();
//		uiVertexRight.position = right;
//		List<UIVertex> vertices = new List<UIVertex> ();
//		vertices.Add (uiVertexBottom);
//		vertices.Add (uiVertexLeft);
//		vertices.Add (uiVertexRight);
//
//		pCanvasRenderer.Clear();
//		pCanvasRenderer.SetMaterial(material, null);
//		pCanvasRenderer.SetVertices(vertices);
	}

	public void UpdatePosition(GameObject planet) {
		gameObject.SetActive (true);

		// Put the dialog above the planet
		Vector3 planetScreenCoordinate = Camera.main.WorldToScreenPoint (planet.transform.position);
		planetScreenCoordinate.y += 50;
		gameObject.transform.position = planetScreenCoordinate;
	}

	public void Hide() {
		gameObject.SetActive (false);
	}
}
