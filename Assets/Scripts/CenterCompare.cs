using UnityEngine;
using System.Collections;
using C5;

public class CenterCompare : MonoBehaviour {

	[SerializeField]
	private RectTransform centerObject;

	[SerializeField]
	private RectTransform scrollablePanel;

	private ArrayList<RectTransform> list;

	void Awake() {
		list = new ArrayList<RectTransform> ();
		list.AddAll (scrollablePanel.GetComponents<RectTransform> ());
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(TouchPhase.
	}
}
