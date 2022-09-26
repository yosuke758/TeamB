using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float force_To_Fly;           //コインを飛ばす力
    public float angle_Of_Flight;        //コインを飛ばす角度
    private Rigidbody _rigidbody;

    public Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
