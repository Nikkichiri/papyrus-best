using UnityEngine;
using System.Collections;

public class BoxBehaviour : MonoBehaviour 
{
	int BoxClicks;

	// Use this for initialization
	void Start () 
	{
	}
	//Max clicks per second == 10
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			CastRay();
		}
	}
	void CastRay()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast (ray.origin, ray.direction, Mathf.Infinity);
		if(hit)
		{
			BoxClicks++;
		}
	}
	//GUI (No shit?)
	void OnGUI()
	{
		GUI.Box(new Rect(10,10,150,50), "You clicked " + BoxClicks + " boxes.");
	}
}