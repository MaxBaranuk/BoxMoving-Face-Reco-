using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoxController : MonoBehaviour {

    [Header("Max angle of rotated object")]
    [Range(0, 90)]
    public float maxRotationAngle = 45;

    [Header("Smooth")]
    [Range(0,100)]
    public int smoothParameter;

    [Header("Smooth")]
    [Range(0, 10000)]
    public int objectMinDistanse = 500;

    [Header("Smooth")]
    [Range(0, 10000)]
    public int objectMaxDistanse = 2000;

    [Range(1f, 2f)]
    public float rotateMultiplier;


    [Range(1f, 5f)]
    public float moveMultiplier;

    GameObject positionController;
    Queue<Vector3> positions;
    Queue<Vector3> rotationsDeg;
   

    // Use this for initialization
    void Start () {
        positionController = GameObject.Find("PositionController");
        positions = new Queue<Vector3>();
        rotationsDeg = new Queue<Vector3>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 rot = SmoothedRotation(positionController.transform.forward);
        transform.rotation = Quaternion.LookRotation(rot);
        transform.position = new Vector3(0, 0, SmoothedPosition(positionController.transform.position));

    }

    float SmoothedPosition(Vector3 position) {
        if (positions.Count > smoothParameter) positions.Dequeue();
        positions.Enqueue(position);

        float posZ = 0;
        foreach (Vector3 v in positions) posZ += v.z;
        posZ /= positions.Count;
        return  Mathf.Clamp(posZ*moveMultiplier, objectMinDistanse, objectMaxDistanse);
    }

    Vector3 SmoothedRotation(Vector3 rotation)
    {
        if (rotationsDeg.Count > smoothParameter) rotationsDeg.Dequeue();
        rotationsDeg.Enqueue(rotation);
        Vector3 rot = Vector3.zero;
        foreach (Vector3 v in rotationsDeg) rot+=v;
        rot /= rotationsDeg.Count;
        rot *= rotateMultiplier;
        rot.x = Mathf.Clamp(rot.x, -maxRotationAngle, maxRotationAngle);
        rot.y = Mathf.Clamp(rot.y, -maxRotationAngle, maxRotationAngle);
        return rot;
    }
}
