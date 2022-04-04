using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public GameObject ObjectMove;

    public Transform StartPoint;
    public Transform EndPoint;

    public float Velocity;

    private Vector3 MoveTo;
    // Start is called before the first frame update
    void Start()
    {
        MoveTo = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjectMove.transform.position = Vector3.MoveTowards(ObjectMove.transform.position, MoveTo, Velocity * Time.deltaTime);

        if (ObjectMove.transform.position == EndPoint.position)
        {
            MoveTo = StartPoint.position;
        }
        if (ObjectMove.transform.position == StartPoint.position)
        {
            MoveTo = EndPoint.position;
        }
    }
}
