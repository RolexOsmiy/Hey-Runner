using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

    public float rotateSpeed = 30f;
	public AudioClip sound;
    bool flag = true;

    void Start()
    {

    }
    void Update()
    {
        if (transform.eulerAngles.z >= 170)
        {
            flag = true;
        }
        if(transform.eulerAngles.z <= 10)
        {
            flag = false;
        }
        if (flag == true)
        {
            more();
        }
        else
        {
            less();
        }
    }

    void more()
    {
        transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime, Space.Self);
    }
    void less()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime, Space.Self);
    }
}
