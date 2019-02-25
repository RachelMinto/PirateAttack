using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] float movementSpeed = 5f;

    void Update () {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime, Space.World);
    }
}
