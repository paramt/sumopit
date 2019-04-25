using UnityEngine;
using System.Collections.Generic;

public class GroundMovement : MonoBehaviour
{
    public float rotateSpeed = 0.1f, rotateDelay = 0f, rotateTime = 1f, shrinkSpeed = 0.008f;

    private Vector3 direction;
    private Vector3 shrinkVector;

    void Start()
    {
        shrinkVector = transform.localScale;
        InvokeRepeating("ChangeDirection", rotateDelay, rotateTime);
    }

    void Update()
    {
        transform.Rotate(direction, rotateSpeed);
        ReduceArea();
    }

    void ReduceArea()
    {
        shrinkVector += new Vector3(-shrinkSpeed, 0, -shrinkSpeed);
        transform.localScale = shrinkVector;
    }

    void ChangeDirection()
    {
        direction = GetRandomDirection();
    }

    private Vector3 GetRandomDirection()
    {
        var possibleDirections = new List<Vector3> { Vector3.right, Vector3.left, new Vector3(0, 0, 1), new Vector3(0, 0, -1) };
        int index = new System.Random().Next(possibleDirections.Count);
        return possibleDirections[index];
    }
}
