using UnityEngine;
using UnityEngine.InputSystem;
public class TreeDMoveAnim : MonoBehaviour
{
    [SerializeField] float rotationFactorPerFrame;
    [SerializeField] float moveSpeed;
    PlayerTestInput inputSystem;
    //CharacterController controller;
    Rigidbody rigidbody;
    Animator animator;
    Vector3 currentInputMovement;
    bool isMovementPressed;
    private void Awake()
    {
        inputSystem = new PlayerTestInput();
        rigidbody = GetComponent<Rigidbody>();
        //controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        inputSystem.TestInput.Move.performed += OnMovementInputs;

    }
    private void OnEnable() => inputSystem.TestInput.Enable();
    private void OnDisable() => inputSystem.TestInput.Disable();
    private void Update()
    {
        HandleRotation();
        HandleAnimation();
        //controller.Move(currentInputMovement * Time.deltaTime * moveSpeed);
    }
    private void OnMovementInputs(InputAction.CallbackContext context)
    {
        Vector2 inputMovement = context.ReadValue<Vector2>();
        currentInputMovement.x = inputMovement.x;
        currentInputMovement.z = inputMovement.y;
        isMovementPressed = inputMovement.x != 0 || inputMovement.y != 0;
    }

    private void FixedUpdate()
    {
        rigidbody.linearVelocity = currentInputMovement * moveSpeed;
    }
    private void HandleAnimation()
    {
        if (isMovementPressed)
            animator.SetBool("isWalking", true);
        else
            animator.SetBool("isWalking", false);
    }
    private void HandleRotation()
    {
        Vector3 positionToLookAt;
        positionToLookAt.x = currentInputMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentInputMovement.z;
        Quaternion currentRotation = transform.rotation;
        if (isMovementPressed)
        {
            Quaternion targetRot = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRot,
            rotationFactorPerFrame * Time.deltaTime);
        }
    }

}
