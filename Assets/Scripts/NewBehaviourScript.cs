using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float m_Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axis_h = Input.GetAxis("Horizontal");

		if (axis_h != 0)
		{
			Vector3 pos =transform.position;
			pos.x += axis_h * m_Speed * Time.deltaTime;
			transform.position= pos;
		}   
    }
}
