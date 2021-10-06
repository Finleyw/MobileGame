using UnityEngine;
using System.Collections;

public class MovePlayers : MonoBehaviour 
{

	public float moveSpeed = 0.1f;
	public JoyStick jsMovement;

	
	private Vector3 direction;
	private float xMin,xMax,yMin,yMax;
	

	void Update () 
    {
		
		direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project
		
		if(direction.magnitude != 0){
		
			transform.position += direction * moveSpeed;
			transform.position = new Vector3(Mathf.Clamp(transform.position.x,xMin,xMax),Mathf.Clamp(transform.position.y,yMin,yMax),0f);//to restric movement of player

		}
		/*if(jsMovement.InputDirection.y>0);
        {
			transform.rotation = 0;
        }
		if (jsMovement.InputDirection.y < 0)
        {
			transform.rotation = 180;
		}*/
	}	
	
	void Start()
    {
		
		//Initialization of boundaries
		xMax = 10; // I used 50 because the size of player is 100*100
		xMin = -10; 
		yMax = 5;
		yMin = -5;
	}
}