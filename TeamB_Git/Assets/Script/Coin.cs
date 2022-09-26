using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject m_deadZone;
    private GameObject m_getZone;
    // Start is called before the first frame update
    void Start()
    {
        m_deadZone = GameObject.Find("DeadZone");
        m_getZone = GameObject.Find("GetZone");
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "DeadZone")
		{

		}
        if(other.gameObject.tag == "GetZone")
		{

		}
	}
}
