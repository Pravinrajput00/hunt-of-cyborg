using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speedV = 2f;
    public float speedH = 2f;
    private float yaw = 0f;
    private float pitch = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
    }
}
