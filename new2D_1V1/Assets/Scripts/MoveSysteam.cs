using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSysteam : MonoBehaviour
{
    [SerializeField, Header("���ʳt��"), Range(0, 50)]
    private float speed = 3.5f;

    private void Update()
    {
        Move();
    }
    /// <summary>
    /// ����
    /// </summary>
    private void Move()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}

