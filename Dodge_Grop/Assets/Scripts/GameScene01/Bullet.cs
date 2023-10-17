using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform m_Target = null;
    float m_Speed = 6;

    void Update()
    {
        transform.LookAt(m_Target);
        transform.position += transform.forward * m_Speed * Time.deltaTime;
    }

    public void Initialize()
    {

    }
}
