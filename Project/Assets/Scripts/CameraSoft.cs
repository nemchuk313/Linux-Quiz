using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSoft : MonoBehaviour
{
    //nie publiczne!
    //nazewnictwo
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float posY;
    [SerializeField]
    [Range(0,10)]
    private float speed;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, posY, -10), Time.deltaTime * speed);
    }
}
