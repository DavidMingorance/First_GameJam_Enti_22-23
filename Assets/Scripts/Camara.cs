using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    GameObject player;
    public Vector3 offset;
    public float smoothness;

    Vector3 vel;

    private void Start()
    {
        player = GameObject.Find("player");
    }
    private void Update()
    {
        Vector3 targetPos = player.transform.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel, smoothness);
    }
}