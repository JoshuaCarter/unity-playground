using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
  public GameObject TargetLocationObject;
  [Range(0.1f, 10f)]
  public float CameraFollowSpeed = 10f;

  // Start is called before the first frame update
  void Start()
  {
    this.transform.position = TargetLocationObject.transform.position;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    this.transform.position = Vector3.Lerp(this.transform.position, this.TargetLocationObject.transform.position, this.CameraFollowSpeed * Time.fixedDeltaTime);
  }
}
