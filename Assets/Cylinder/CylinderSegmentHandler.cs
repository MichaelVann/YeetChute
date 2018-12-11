using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSegmentHandler : MonoBehaviour {

    public float m_rotateSpeed = 0.5f;

    public GameObject m_barrierRef;
    GameObject[] m_barriers;
    int m_sideCapacity = 32;

    void GenerateBarriers()
    {
        List<int> barrierSlots = new List<int>(m_sideCapacity);//Create a list containing the potential random positions
        for (int i = 0; i < m_sideCapacity; i++)
        {
            barrierSlots.Add(i);
        }

        m_barriers = new GameObject[m_sideCapacity];//Instantiate Barrier list

        for (int i = 0; i < m_sideCapacity;)//For all the barrier slots
        {
            m_barriers[i] = Instantiate<GameObject>(m_barrierRef, transform);//Instantiate the barrier 

            float segmentRotation = (i + 1) * (360 / m_sideCapacity);//Rotate it to the appropriate position
            m_barriers[i].transform.rotation = Quaternion.Euler(new Vector3(0, 0, segmentRotation));//..
        }
    }

	// Use this for initialization
	void Start ()
    {
        GenerateBarriers();
    }

    void HandleInput()
    {
        float deltaRot = 0;
        if (Input.GetKey(KeyCode.A))
            deltaRot -= m_rotateSpeed;

        if (Input.GetKey(KeyCode.D))
            deltaRot += m_rotateSpeed;

        transform.Rotate(0, 0, deltaRot);
    }

	// Update is called once per frame
	void Update ()
    {
        HandleInput();
    }

}
