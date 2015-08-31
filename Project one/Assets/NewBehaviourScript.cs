using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{

	int charlie = 3;


	// Use this for initialization
	void Start () 
	{
		charlie= code(charlie);
		Debug.Log (charlie);


	}
	int code (int wow)
	{
		int ret;
		ret = wow * 5;
		return ret;
	}

	    


}
