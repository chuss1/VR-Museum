using UnityEngine;

public class RotateAndHold : MonoBehaviour {
    public Vector3 targetRotation;
    public float rotationSpeed = 1.0f;
    public float holdDuration = 2.0f;

    private Quaternion originalRotation;
    private Vector3 currentTargetRotation;
    private bool rotating = false;
    private bool rotatedOnce = false;
    private float holdTimer = 0.0f;

    void Start() {
        originalRotation = transform.rotation;
        currentTargetRotation = targetRotation;
    }

    void Update() {
        if (rotating) {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(currentTargetRotation), Time.deltaTime * rotationSpeed);

            // Check if rotation has reached the target
            if (Quaternion.Angle(transform.rotation, Quaternion.Euler(currentTargetRotation)) < 0.1f) {
                rotating = false;
                holdTimer = 0.0f;
                rotatedOnce = !rotatedOnce;
                currentTargetRotation = rotatedOnce ? originalRotation.eulerAngles : targetRotation;
            }
        } else {
            // Hold the rotation for a set duration
            holdTimer += Time.deltaTime;
            if (holdTimer >= holdDuration && !rotating) {
                rotating = true;

            }
        }
    }
}
