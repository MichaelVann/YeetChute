using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour {

    public GameObject m_ballRef;

    GameObject[] m_balls;
    float m_tunnelRadius = 12f;
    public int m_ballCount = 42;

	// Use this for initialization
	void Start () {
        m_balls = new GameObject[m_ballCount];
        for (int i = 0; i < m_ballCount; i++)
        {
            m_balls[i] = Instantiate<GameObject>(m_ballRef, transform);
            float angle = i * 2*Mathf.PI / (m_ballCount);
            m_balls[i].transform.position = new Vector3(Mathf.Cos(angle) * m_tunnelRadius, Mathf.Sin(angle) * m_tunnelRadius, 0);// - new Vector3(-6,-6,0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
