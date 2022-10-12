using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Swimmer : MonoBehaviour
{
    [Header("Values")]
    [SerializeField] float swimforce = 2f;
    [SerializeField] float dragforce = 1f;
    [SerializeField] float minforce;
    [SerializeField] float mintime; //min time between strokes

    [SerializeField] InputActionReference leftCtrlSwimRef;
    [SerializeField] InputActionReference leftCtrlVelocity;
    [SerializeField] InputActionReference rightCtrlSwimRef;
    [SerializeField] InputActionReference rightCtrlVelocity;
    [SerializeField] Transform forwardReference;

    Rigidbody _rigidbody;
    float _cooldowntimer;

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate(){
        _cooldowntimer += Time.fixedDeltaTime;
        if(_cooldowntimer > mintime && leftCtrlSwimRef.action.IsPressed() && rightCtrlSwimRef.action.IsPressed()){
            var leftHandVelocity = leftCtrlVelocity.action.ReadValue<Vector3>();
            var rightHandVelocity = rightCtrlVelocity.action.ReadValue<Vector3>();
        }
    }
}
